using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
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
        }

        private void RecorderStartButton2_Click(object sender, EventArgs e)
        {
            RecorderStartButton2.Enabled = false;
            RecorderendButton1.Enabled = true;
            redRat3.RCDetectorEnabled = true;
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
                    RCscript.Write(sigKey.Signal.Name + ";");
                    BeginInvoke((MethodInvoker)delegate
                    {
                        keyLineTextField1.Text = sigKey.Signal.Name;
                    });
                    Thread.Sleep(500); //防止接收重複信號
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
                            redRat3.ClearRCSignalInQueue();
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
            }
        }

        private void RecorderendButton1_Click(object sender, EventArgs e)
        {
            this.Text = "Finish !";
            RCscript.Close();
            this.Dispose();
        }

      
    }
}
