using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Timers;
using MaterialSkin.Controls;
using RedRat;
using RedRat.RedRat3;
using RedRat.RedRat3.USB;
using RedRat.AVDeviceMngmt;



namespace RCrecoder
{
    public partial class RCrecorderForm : MaterialForm
    {
        public static RCrecorderForm main_form = null;
        private AVDeviceDB avDeviceDB;
        protected IRedRat3 redRat3;
        List<string> all_button_name = new List<string>();
        StreamWriter RCscript;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public RCrecorderForm()
        {
            InitializeComponent();
            main_form = this;
            OpenRedRat3();
            if (redRat3 != null)
            {
                // Add listener for incoming signals.
                redRat3.RCDetectorSignalIn += RCSignalDataIn;
            }
        }


        private void LoadDBButton1_Click(object sender, EventArgs e)
        {
            // Read signal database from XML file.
            var openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            string FW = redRat3.FirmwareVersion;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var fName = openFileDialog.FileName;
            var ser = new XmlSerializer(typeof(AVDeviceDB));
            FileStream fs = null;
            try
            {
                fs = new FileStream((new FileInfo(fName)).FullName, FileMode.Open);
                var newAVDeviceDB = (AVDeviceDB)ser.Deserialize(fs);
                avDeviceDB = newAVDeviceDB;
                Text = avDeviceDB.AVDevices[0].Name + " READY!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            var button_count = avDeviceDB.AVDevices[0].Signals.Count();
            all_button_name.Clear();
            for (int i = 0; i < button_count; i++)
                all_button_name.Add(avDeviceDB.AVDevices[0].Signals[i].Name.ToString());
            RecorderStartButton2.Enabled = true;
            richTextBoxScript.Clear();
            richTextBoxLineNumber.Clear();

        }

        private void RecorderStartButton2_Click(object sender, EventArgs e)
        {
            newline_btn.Enabled = true;
            keypad_btn.Enabled = true;
            RecorderStartButton2.Enabled = false;
            RecorderendButton1.Enabled = true;
            redRat3.RCDetectorEnabled = true;
            redRat3.Connect();
            this.Text = "Recording.....";
            richTextBoxScript.Clear();
        }
        protected void signal_decode(SignalKey sigKey)
        {
            if (sigKey.Signal != null)
            {
                redRat3.RCDetectorEnabled = false;
                bool key_exist = all_button_name.Contains(sigKey.Signal.Name);
                if (key_exist)
                {
                    BeginInvoke((MethodInvoker)delegate
                    {
                        if (richTextBoxScript.Lines.Length<1 || !sw.IsRunning)
                        {
                            sw.Restart();
                            richTextBoxScript.Text += ("redrat " + sigKey.Signal.Name + " ");
                        }
                        else
                            richTextBoxScript.Text += (Convert.ToInt32(sw.Elapsed.TotalMilliseconds) + "\n" + "redrat " + sigKey.Signal.Name + " ");
                        sw.Restart();
                        richTextBoxScript.SelectionStart = richTextBoxScript.TextLength;
                        // Scrolls the contents of the control to the current caret position.
                        richTextBoxScript.ScrollToCaret();
                    });
                    signal_receive_Delay(50); //防止接收重複信號
                    redRat3.ClearRCSignalInQueue();
                }
                redRat3.RCDetectorEnabled = true;
            }
        }

        public void RCSignalDataIn(object sender, EventArgs e)
        {
            
            var siea = e as SignalEventArgs;
            if (siea == null) return;         // Who called this then???

            switch (siea.Action)
            {
                case SignalEventAction.EXCEPTION:
                    //MessageBox.Show(siea.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case SignalEventAction.MODULATED_SIGNAL:
                    if (avDeviceDB != null)
                    {
                        // Decode signal if have DB.
                        try
                        {
                            var sigKey = avDeviceDB.DecodeSignal(siea.ModulatedSignal);
                            signal_decode(sigKey);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "\n" + ex.StackTrace + "\n");
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        protected void OpenRedRat3()
        {
            try
            {
                // Find the no. of RR3s connected.
                var devices = RedRat3USBImpl.FindDevices();
                if (devices.Count > 0)
                {

                    // Just take the first device found.
                    redRat3 = (IRedRat3)devices[0].GetRedRat();

                }
                else
                {
                    MessageBox.Show("No RedRat3 devices found.", "Warning",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RCrecorderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Try and ensure we don't get the RR3 hanging.
            if (redRat3 != null)
            {
                redRat3.RCDetectorEnabled = false;
                redRat3.Dispose();
            }
            this.Dispose();
        }

        private void RecorderendButton1_Click(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
                BeginInvoke((MethodInvoker)delegate
                {
                    richTextBoxScript.Text += (Convert.ToInt32(sw.Elapsed.TotalMilliseconds));
                });
            }
            this.Text = "Finish !";
            if (redRat3 != null && redRat3.IsConnected())
            redRat3.Disconnect();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save an script File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != "")
            {
                if(File.Exists(dlg.FileName))
                RCscript = new StreamWriter(dlg.FileName , false, System.Text.Encoding.Default);
                else
                RCscript = new StreamWriter(dlg.FileName + (".tpvts"), false, System.Text.Encoding.Default);
                RCscript.Write(richTextBoxScript.Text);
                RCscript.Close();
            }
            if(avDeviceDB != null)
            RecorderStartButton2.Enabled = true;
        }

        static bool BlueRatDevViewer_Delay_TimeOutIndicator = false;
        private static void BlueRatDevViewer_Delay_OnTimedEvent(object source, ElapsedEventArgs e)
        {
            BlueRatDevViewer_Delay_TimeOutIndicator = true;
        }

        private void signal_receive_Delay(int delay_ms)
        {
            if (delay_ms <= 0) return;
            System.Timers.Timer aTimer = new System.Timers.Timer(delay_ms);
            aTimer.Elapsed += new ElapsedEventHandler(BlueRatDevViewer_Delay_OnTimedEvent);
            BlueRatDevViewer_Delay_TimeOutIndicator = false;
            aTimer.Enabled = true;
            while ((BlueRatDevViewer_Delay_TimeOutIndicator == false)) { Application.DoEvents(); Thread.Sleep(1); }
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void AddLineNumbers()
        {
            // create & set Point pt to (0,0)
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1
            int First_Index = richTextBoxScript.GetCharIndexFromPosition(pt);
            int First_Line = richTextBoxScript.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1
            int Last_Index = richTextBoxScript.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBoxScript.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox
            richTextBoxLineNumber.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value
            richTextBoxLineNumber.Text = "";
            richTextBoxLineNumber.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line
            for (int i = First_Line; i <= Last_Line; i++)
                richTextBoxLineNumber.Text += i + 1 + "\n";
            richTextBoxLineNumber.Text += "\n\n\n\n";
        }
        private int getWidth()
        {
            int width = 25;
            // get total lines of richTextBox1
            int line = richTextBoxScript.Lines.Length;

            if (line <= 99)
                width = 20 + (int)richTextBoxScript.Font.Size;
            else if (line <= 999)
                width = 30 + (int)richTextBoxScript.Font.Size;
            else
                width = 50 + (int)richTextBoxScript.Font.Size;
            return width;
        }

        private void richTextBoxScript_TextChanged(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBoxScript_FontChanged(object sender, EventArgs e)
        {
            richTextBoxLineNumber.Font = richTextBoxScript.Font;
            richTextBoxScript.Select();
            AddLineNumbers();
        }

        private void richTextBoxScript_VScroll(object sender, EventArgs e)
        {
            richTextBoxLineNumber.Text = "";
            AddLineNumbers();
            richTextBoxLineNumber.Invalidate();
        }

        private void richTextBoxScript_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = richTextBoxScript.GetPositionFromCharIndex(richTextBoxScript.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadmacroFlatButton_Click(object sender, EventArgs e)
        {
 

            var openFileDialog = new OpenFileDialog
            {
                Filter = "tpvts files (*.tpvts)|*.tpvts|rcmacro files (*.rcmacro)|*.rcmacro|All files (*.*)|*.*",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var fName = openFileDialog.FileName;
            try
            {
                RecorderendButton1.Enabled = true;
                richTextBoxScript.Clear();
                richTextBoxScript.Text =  File.ReadAllText(fName);             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void createmacroFlatButton1_Click(object sender, EventArgs e)
        {
            sw.Stop();
            richTextBoxScript.Text += (Convert.ToInt32(sw.Elapsed.TotalMilliseconds));
            if (redRat3 != null && redRat3.IsConnected())
                redRat3.Disconnect();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save an macro File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != "")
            {
                if (File.Exists(dlg.FileName))
                    RCscript = new StreamWriter(dlg.FileName, false, System.Text.Encoding.Default);
                else
                    RCscript = new StreamWriter(dlg.FileName + (".rcmacro"), false, System.Text.Encoding.Default);
                string[] macrotext = richTextBoxScript.Text.Split('\n');
                for (int i = 0; i < macrotext.Length - 1; i++)
                RCscript.Write(macrotext[i] + '\n');
                RCscript.Close();
            }
            if (avDeviceDB != null)
            RecorderStartButton2.Enabled = true;
        }

        private void RCrecorderForm_Load(object sender, EventArgs e)
        {
            if (redRat3 != null && redRat3.IsConnected())
            redRat3.MinPauseSize = 10;
        }

        private void keypad_btn_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            if (File.Exists("key.config"))
            {
                var key = File.ReadAllLines("key.config");
                List<string> key_list = new List<string>(key);
                keyload(key_list);
            }
        }

        private void addkey_btn_Click(object sender, EventArgs e)
        {
            if (keypad_btn.Enabled)
            {
                var keypad_list = new keypadlist();
                keypad_list.Show();
            }
        }
        public void keyload(List<string> key_list)
        {
            panel.Controls.Clear();
            int btnwidth = 150;
            int btnheight = 50;
            for (int i = 0; i < key_list.Count; i++)
            {
                Button key_button = new Button();
                key_button = new Button();
                panel.Controls.Add(key_button);
                key_button.Size = new Size(btnwidth,btnheight);
                key_button.Location = new Point(0,key_button.Height*i);
                key_button.Name = key_list[i]+"_btn";
                key_button.Text = key_list[i];
                key_button.Font = new Font("Times New Roman", 12, key_button.Font.Style);
                key_button.Click += new EventHandler(btn_Click);
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (keypad_btn.Enabled)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    if (!sw.IsRunning)
                    {
                        richTextBoxScript.Text += ((Button)sender).Text + " ";
                        sw.Restart();
                    }
                    else
                        richTextBoxScript.Text += (Convert.ToInt32(sw.Elapsed.TotalMilliseconds) + "\n" + ((Button)sender).Text + " ");
                    sw.Restart();
                    richTextBoxScript.SelectionStart = richTextBoxScript.TextLength;
                // Scrolls the contents of the control to the current caret position.
                richTextBoxScript.ScrollToCaret();
                });
            }
        }

        private void newline_btn_Click(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                if (sw.IsRunning)
                {
                    richTextBoxScript.Text += (Convert.ToInt32(sw.Elapsed.TotalMilliseconds) + "\n#############################\n");
                    sw.Reset();
                    richTextBoxScript.SelectionStart = richTextBoxScript.TextLength;
                    // Scrolls the contents of the control to the current caret position.
                    richTextBoxScript.ScrollToCaret();
                }
            });
        }
    }
}
