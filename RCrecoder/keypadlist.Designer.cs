namespace RCrecoder
{
    partial class keypadlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addkey_ok_btn = new System.Windows.Forms.Button();
            this.addkey_text = new System.Windows.Forms.TextBox();
            this.key_name_label = new System.Windows.Forms.Label();
            this.keydelete_btn = new System.Windows.Forms.Button();
            this.keyadd_btn = new System.Windows.Forms.Button();
            this.key_listbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addkey_ok_btn);
            this.panel1.Controls.Add(this.addkey_text);
            this.panel1.Controls.Add(this.key_name_label);
            this.panel1.Controls.Add(this.keydelete_btn);
            this.panel1.Controls.Add(this.keyadd_btn);
            this.panel1.Controls.Add(this.key_listbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 391);
            this.panel1.TabIndex = 0;
            // 
            // addkey_ok_btn
            // 
            this.addkey_ok_btn.Location = new System.Drawing.Point(57, 341);
            this.addkey_ok_btn.Name = "addkey_ok_btn";
            this.addkey_ok_btn.Size = new System.Drawing.Size(161, 38);
            this.addkey_ok_btn.TabIndex = 5;
            this.addkey_ok_btn.Text = "OK";
            this.addkey_ok_btn.UseVisualStyleBackColor = true;
            this.addkey_ok_btn.Click += new System.EventHandler(this.addkey_ok_btn_Click);
            // 
            // addkey_text
            // 
            this.addkey_text.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addkey_text.Location = new System.Drawing.Point(156, 40);
            this.addkey_text.Name = "addkey_text";
            this.addkey_text.Size = new System.Drawing.Size(218, 36);
            this.addkey_text.TabIndex = 4;
            // 
            // key_name_label
            // 
            this.key_name_label.AutoSize = true;
            this.key_name_label.Location = new System.Drawing.Point(68, 51);
            this.key_name_label.Name = "key_name_label";
            this.key_name_label.Size = new System.Drawing.Size(82, 18);
            this.key_name_label.TabIndex = 3;
            this.key_name_label.Text = "Key Name";
            // 
            // keydelete_btn
            // 
            this.keydelete_btn.Location = new System.Drawing.Point(400, 176);
            this.keydelete_btn.Name = "keydelete_btn";
            this.keydelete_btn.Size = new System.Drawing.Size(115, 37);
            this.keydelete_btn.TabIndex = 2;
            this.keydelete_btn.Text = "Delete";
            this.keydelete_btn.UseVisualStyleBackColor = true;
            this.keydelete_btn.Click += new System.EventHandler(this.keydelete_btn_Click);
            // 
            // keyadd_btn
            // 
            this.keyadd_btn.Location = new System.Drawing.Point(400, 40);
            this.keyadd_btn.Name = "keyadd_btn";
            this.keyadd_btn.Size = new System.Drawing.Size(115, 29);
            this.keyadd_btn.TabIndex = 1;
            this.keyadd_btn.Text = "Add";
            this.keyadd_btn.UseVisualStyleBackColor = true;
            this.keyadd_btn.Click += new System.EventHandler(this.keyadd_btn_Click);
            // 
            // key_listbox
            // 
            this.key_listbox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.key_listbox.FormattingEnabled = true;
            this.key_listbox.ItemHeight = 24;
            this.key_listbox.Location = new System.Drawing.Point(57, 87);
            this.key_listbox.Name = "key_listbox";
            this.key_listbox.Size = new System.Drawing.Size(317, 220);
            this.key_listbox.TabIndex = 0;
            this.key_listbox.SelectedIndexChanged += new System.EventHandler(this.key_listbox_SelectedIndexChanged);
            // 
            // keypadlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(527, 391);
            this.Controls.Add(this.panel1);
            this.Name = "keypadlist";
            this.Text = "Add New Key";
            this.Load += new System.EventHandler(this.keypadlist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button keydelete_btn;
        private System.Windows.Forms.Button keyadd_btn;
        private System.Windows.Forms.ListBox key_listbox;
        private System.Windows.Forms.TextBox addkey_text;
        private System.Windows.Forms.Label key_name_label;
        private System.Windows.Forms.Button addkey_ok_btn;
    }
}