using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RCrecoder
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
                max_num_len_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.MaxNumLengths);
                sig_mem_size_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.SignalMemorySize);
                peri_count_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.ModFreqPeriodsToMeasure);
                len_delta_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.LengthMeasurementDelta);
                sig_timeout_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.EndOfSignalTimeout);
                mini_pause_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.MinPauseSize);
                hsc_checkBox.Checked = RCrecorderForm.redRat3.HiSpeedMode;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            try
            {
                RCrecorderForm.redRat3.MaxNumLengths = Convert.ToInt32(max_num_len_textBox.Text);
                RCrecorderForm.redRat3.SignalMemorySize = Convert.ToInt32(sig_mem_size_textBox.Text);
                RCrecorderForm.redRat3.ModFreqPeriodsToMeasure = Convert.ToInt32(peri_count_textBox.Text);
                RCrecorderForm.redRat3.LengthMeasurementDelta = Convert.ToInt32(len_delta_textBox.Text);
                RCrecorderForm.redRat3.EndOfSignalTimeout = Convert.ToDouble(sig_timeout_textBox.Text);
                RCrecorderForm.redRat3.MinPauseSize = Convert.ToDouble(mini_pause_textBox.Text);
                RCrecorderForm.redRat3.HiSpeedMode = hsc_checkBox.Checked;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                max_num_len_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.MaxNumLengths);
                sig_mem_size_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.SignalMemorySize);
                peri_count_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.ModFreqPeriodsToMeasure);
                len_delta_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.LengthMeasurementDelta);
                sig_timeout_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.EndOfSignalTimeout);
                mini_pause_textBox.Text = Convert.ToString(RCrecorderForm.redRat3.MinPauseSize);
                hsc_checkBox.Checked = RCrecorderForm.redRat3.HiSpeedMode;
            }
        }
    }
}
