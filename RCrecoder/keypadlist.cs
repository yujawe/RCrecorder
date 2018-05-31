using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCrecoder
{
    public partial class keypadlist : Form
    {
        int select_item;
        public keypadlist()
        {
            InitializeComponent();
        }

        private void keyadd_btn_Click(object sender, EventArgs e)
        {
            key_listbox.Items.Add(addkey_text.Text);
            addkey_text.Clear();
            key_listbox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void addkey_ok_btn_Click(object sender, EventArgs e)
        {
            StreamWriter key_config = new StreamWriter("key.config", false, System.Text.Encoding.Default);
            List<string> key_list = new List<string>();
            foreach (string key_name in key_listbox.Items)
            {
                key_list.Add(key_name);
                key_config.Write(key_name + "\n");
            }
            key_config.Close();
            RCrecorderForm.main_form.keyload(key_list);

            this.Close();
        }

        private void keydelete_btn_Click(object sender, EventArgs e)
        {
            key_listbox.Items.RemoveAt(select_item);
        }

        private void key_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_item = key_listbox.SelectedIndex;
        }

        private void keypadlist_Load(object sender, EventArgs e)
        {
            if (File.Exists("key.config"))
            {
                var key_array = File.ReadAllLines("key.config");
                foreach (var key_name in key_array)
                key_listbox.Items.Add(key_name);
            }
        }
    }
}
