namespace RCrecoder
{
    partial class setting
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
            this.setting_panel = new System.Windows.Forms.Panel();
            this.setting_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.max_num_len_label = new System.Windows.Forms.Label();
            this.sig_mem_size_label = new System.Windows.Forms.Label();
            this.peri_count_label = new System.Windows.Forms.Label();
            this.len_delta_label = new System.Windows.Forms.Label();
            this.sig_timeout_label = new System.Windows.Forms.Label();
            this.mini_pause_label = new System.Windows.Forms.Label();
            this.hsc_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.max_num_len_textBox = new System.Windows.Forms.TextBox();
            this.sig_mem_size_textBox = new System.Windows.Forms.TextBox();
            this.peri_count_textBox = new System.Windows.Forms.TextBox();
            this.len_delta_textBox = new System.Windows.Forms.TextBox();
            this.sig_timeout_textBox = new System.Windows.Forms.TextBox();
            this.mini_pause_textBox = new System.Windows.Forms.TextBox();
            this.hsc_checkBox = new System.Windows.Forms.CheckBox();
            this.setting_panel.SuspendLayout();
            this.setting_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_panel
            // 
            this.setting_panel.Controls.Add(this.cancel_button);
            this.setting_panel.Controls.Add(this.ok_button);
            this.setting_panel.Controls.Add(this.setting_tableLayoutPanel);
            this.setting_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setting_panel.Location = new System.Drawing.Point(0, 0);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(519, 401);
            this.setting_panel.TabIndex = 0;
            // 
            // setting_tableLayoutPanel
            // 
            this.setting_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_tableLayoutPanel.ColumnCount = 2;
            this.setting_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.07212F));
            this.setting_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.92788F));
            this.setting_tableLayoutPanel.Controls.Add(this.mini_pause_textBox, 1, 5);
            this.setting_tableLayoutPanel.Controls.Add(this.sig_timeout_textBox, 1, 4);
            this.setting_tableLayoutPanel.Controls.Add(this.len_delta_textBox, 1, 3);
            this.setting_tableLayoutPanel.Controls.Add(this.peri_count_textBox, 1, 2);
            this.setting_tableLayoutPanel.Controls.Add(this.sig_mem_size_textBox, 1, 1);
            this.setting_tableLayoutPanel.Controls.Add(this.max_num_len_label, 0, 0);
            this.setting_tableLayoutPanel.Controls.Add(this.sig_mem_size_label, 0, 1);
            this.setting_tableLayoutPanel.Controls.Add(this.peri_count_label, 0, 2);
            this.setting_tableLayoutPanel.Controls.Add(this.len_delta_label, 0, 3);
            this.setting_tableLayoutPanel.Controls.Add(this.sig_timeout_label, 0, 4);
            this.setting_tableLayoutPanel.Controls.Add(this.mini_pause_label, 0, 5);
            this.setting_tableLayoutPanel.Controls.Add(this.hsc_label, 0, 6);
            this.setting_tableLayoutPanel.Controls.Add(this.max_num_len_textBox, 1, 0);
            this.setting_tableLayoutPanel.Controls.Add(this.hsc_checkBox, 1, 6);
            this.setting_tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.setting_tableLayoutPanel.Name = "setting_tableLayoutPanel";
            this.setting_tableLayoutPanel.RowCount = 7;
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.setting_tableLayoutPanel.Size = new System.Drawing.Size(513, 324);
            this.setting_tableLayoutPanel.TabIndex = 0;
            // 
            // max_num_len_label
            // 
            this.max_num_len_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.max_num_len_label.AutoSize = true;
            this.max_num_len_label.Location = new System.Drawing.Point(3, 14);
            this.max_num_len_label.Name = "max_num_len_label";
            this.max_num_len_label.Size = new System.Drawing.Size(255, 18);
            this.max_num_len_label.TabIndex = 0;
            this.max_num_len_label.Text = "Max Number of Lengths:";
            this.max_num_len_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sig_mem_size_label
            // 
            this.sig_mem_size_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sig_mem_size_label.AutoSize = true;
            this.sig_mem_size_label.Location = new System.Drawing.Point(3, 60);
            this.sig_mem_size_label.Name = "sig_mem_size_label";
            this.sig_mem_size_label.Size = new System.Drawing.Size(255, 18);
            this.sig_mem_size_label.TabIndex = 1;
            this.sig_mem_size_label.Text = "Signal Memory Size (bytes):";
            this.sig_mem_size_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peri_count_label
            // 
            this.peri_count_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.peri_count_label.AutoSize = true;
            this.peri_count_label.Location = new System.Drawing.Point(3, 106);
            this.peri_count_label.Name = "peri_count_label";
            this.peri_count_label.Size = new System.Drawing.Size(255, 18);
            this.peri_count_label.TabIndex = 2;
            this.peri_count_label.Text = "Mod. Freq. Period to Count:";
            this.peri_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // len_delta_label
            // 
            this.len_delta_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.len_delta_label.AutoSize = true;
            this.len_delta_label.Location = new System.Drawing.Point(3, 152);
            this.len_delta_label.Name = "len_delta_label";
            this.len_delta_label.Size = new System.Drawing.Size(255, 18);
            this.len_delta_label.TabIndex = 3;
            this.len_delta_label.Text = "Length Delta (fuzz value):";
            this.len_delta_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sig_timeout_label
            // 
            this.sig_timeout_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sig_timeout_label.AutoSize = true;
            this.sig_timeout_label.Location = new System.Drawing.Point(3, 198);
            this.sig_timeout_label.Name = "sig_timeout_label";
            this.sig_timeout_label.Size = new System.Drawing.Size(255, 18);
            this.sig_timeout_label.TabIndex = 4;
            this.sig_timeout_label.Text = "End of Signal Timeout (ms):";
            this.sig_timeout_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mini_pause_label
            // 
            this.mini_pause_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mini_pause_label.AutoSize = true;
            this.mini_pause_label.Location = new System.Drawing.Point(3, 244);
            this.mini_pause_label.Name = "mini_pause_label";
            this.mini_pause_label.Size = new System.Drawing.Size(255, 18);
            this.mini_pause_label.TabIndex = 5;
            this.mini_pause_label.Text = "Minimum Pause Size (ms):";
            this.mini_pause_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsc_label
            // 
            this.hsc_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hsc_label.AutoSize = true;
            this.hsc_label.Location = new System.Drawing.Point(3, 291);
            this.hsc_label.Name = "hsc_label";
            this.hsc_label.Size = new System.Drawing.Size(255, 18);
            this.hsc_label.TabIndex = 6;
            this.hsc_label.Text = "High Speed Capture:";
            this.hsc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(210, 342);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(129, 39);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(378, 342);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(129, 39);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // max_num_len_textBox
            // 
            this.max_num_len_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.max_num_len_textBox.Location = new System.Drawing.Point(264, 8);
            this.max_num_len_textBox.Name = "max_num_len_textBox";
            this.max_num_len_textBox.Size = new System.Drawing.Size(246, 29);
            this.max_num_len_textBox.TabIndex = 7;
            // 
            // sig_mem_size_textBox
            // 
            this.sig_mem_size_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sig_mem_size_textBox.Location = new System.Drawing.Point(264, 54);
            this.sig_mem_size_textBox.Name = "sig_mem_size_textBox";
            this.sig_mem_size_textBox.Size = new System.Drawing.Size(246, 29);
            this.sig_mem_size_textBox.TabIndex = 8;
            // 
            // peri_count_textBox
            // 
            this.peri_count_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.peri_count_textBox.Location = new System.Drawing.Point(264, 100);
            this.peri_count_textBox.Name = "peri_count_textBox";
            this.peri_count_textBox.Size = new System.Drawing.Size(246, 29);
            this.peri_count_textBox.TabIndex = 9;
            // 
            // len_delta_textBox
            // 
            this.len_delta_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.len_delta_textBox.Location = new System.Drawing.Point(264, 146);
            this.len_delta_textBox.Name = "len_delta_textBox";
            this.len_delta_textBox.Size = new System.Drawing.Size(246, 29);
            this.len_delta_textBox.TabIndex = 10;
            // 
            // sig_timeout_textBox
            // 
            this.sig_timeout_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sig_timeout_textBox.Location = new System.Drawing.Point(264, 192);
            this.sig_timeout_textBox.Name = "sig_timeout_textBox";
            this.sig_timeout_textBox.Size = new System.Drawing.Size(246, 29);
            this.sig_timeout_textBox.TabIndex = 11;
            // 
            // mini_pause_textBox
            // 
            this.mini_pause_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mini_pause_textBox.Location = new System.Drawing.Point(264, 238);
            this.mini_pause_textBox.Name = "mini_pause_textBox";
            this.mini_pause_textBox.Size = new System.Drawing.Size(246, 29);
            this.mini_pause_textBox.TabIndex = 12;
            // 
            // hsc_checkBox
            // 
            this.hsc_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hsc_checkBox.AutoSize = true;
            this.hsc_checkBox.Location = new System.Drawing.Point(264, 289);
            this.hsc_checkBox.Name = "hsc_checkBox";
            this.hsc_checkBox.Size = new System.Drawing.Size(22, 21);
            this.hsc_checkBox.TabIndex = 13;
            this.hsc_checkBox.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 401);
            this.Controls.Add(this.setting_panel);
            this.Name = "setting";
            this.Text = "Paramater Setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.setting_panel.ResumeLayout(false);
            this.setting_tableLayoutPanel.ResumeLayout(false);
            this.setting_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TableLayoutPanel setting_tableLayoutPanel;
        private System.Windows.Forms.TextBox mini_pause_textBox;
        private System.Windows.Forms.TextBox sig_timeout_textBox;
        private System.Windows.Forms.TextBox len_delta_textBox;
        private System.Windows.Forms.TextBox peri_count_textBox;
        private System.Windows.Forms.TextBox sig_mem_size_textBox;
        private System.Windows.Forms.Label max_num_len_label;
        private System.Windows.Forms.Label sig_mem_size_label;
        private System.Windows.Forms.Label peri_count_label;
        private System.Windows.Forms.Label len_delta_label;
        private System.Windows.Forms.Label sig_timeout_label;
        private System.Windows.Forms.Label mini_pause_label;
        private System.Windows.Forms.Label hsc_label;
        private System.Windows.Forms.TextBox max_num_len_textBox;
        private System.Windows.Forms.CheckBox hsc_checkBox;
    }
}