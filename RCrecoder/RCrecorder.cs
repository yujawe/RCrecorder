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
using Microsoft.WindowsAPICodePack.Dialogs;


namespace RCrecoder
{
    public partial class RCrecorderForm : MaterialForm
    {
        private AVDeviceDB avDeviceDB;
        protected IRedRat3 redRat3;
        List<string> all_button_name = new List<string>();
        StreamWriter RCscript;

        public RCrecorderForm()
        {
            InitializeComponent();
            OpenRedRat3();
            if (redRat3 != null)
            {
                // Add listener for incoming signals.
                redRat3.RCDetectorSignalIn += RCSignalDataIn;
                redRat3.RCDetectorEnabled = true;
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

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var fName = openFileDialog.FileName;
            var ser = new XmlSerializer(typeof(AVDeviceDB));
            FileStream fs = null;
            try
            {
                fs = new FileStream((new FileInfo(fName)).FullName, FileMode.Open);
                var newAVDeviceDB = (AVDeviceDB)ser.Deserialize(fs);
                avDeviceDB = newAVDeviceDB;
                Text = "";
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
            RecorderStartButton2.Enabled = false;
            RecorderendButton1.Enabled = true;
            redRat3.RCDetectorEnabled = true;
            redRat3.Connect();
            this.Text = "Recording.....";
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save an Script File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != "")
            {
                RCscript = new StreamWriter(dlg.FileName + (".tpvts"), false, System.Text.Encoding.Default);
            }
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
                        richTextBoxScript.Text += (sigKey.Signal.Name + "\n");
                    });
                    signal_receive_Delay(200); //防止接收重複信號
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
                    MessageBox.Show(siea.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("No RedRat3 devices found.", "TestRemote Warning",
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
            this.Text = "Finish !";
            redRat3.Disconnect();
            RCscript.Write(richTextBoxScript.Text);
            RCscript.Close();
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
            richTextBoxScript.SelectionStart = richTextBoxScript.TextLength;
            richTextBoxLineNumber.SelectionLength = richTextBoxLineNumber.TextLength;
            // Scrolls the contents of the control to the current caret position.
            richTextBoxScript.ScrollToCaret();
            richTextBoxLineNumber.ScrollToCaret();
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
    }
}
