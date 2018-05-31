namespace RCrecoder
{
    partial class RCrecorderForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCrecorderForm));
            this.LoadDBButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.RecorderStartButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.RecorderendButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLineNumber = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loadmacroFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.createmacroFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel = new System.Windows.Forms.Panel();
            this.addkey_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.keypad_btn = new System.Windows.Forms.Button();
            this.newline_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadDBButton1
            // 
            this.LoadDBButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadDBButton1.AutoSize = true;
            this.LoadDBButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadDBButton1.Depth = 0;
            this.LoadDBButton1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoadDBButton1.Location = new System.Drawing.Point(13, 108);
            this.LoadDBButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadDBButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadDBButton1.Name = "LoadDBButton1";
            this.LoadDBButton1.Primary = false;
            this.LoadDBButton1.Size = new System.Drawing.Size(130, 36);
            this.LoadDBButton1.TabIndex = 0;
            this.LoadDBButton1.Text = "Load RC DB";
            this.LoadDBButton1.UseVisualStyleBackColor = true;
            this.LoadDBButton1.Click += new System.EventHandler(this.LoadDBButton1_Click);
            // 
            // RecorderStartButton2
            // 
            this.RecorderStartButton2.AutoSize = true;
            this.RecorderStartButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RecorderStartButton2.Depth = 0;
            this.RecorderStartButton2.Enabled = false;
            this.RecorderStartButton2.Location = new System.Drawing.Point(13, 288);
            this.RecorderStartButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RecorderStartButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecorderStartButton2.Name = "RecorderStartButton2";
            this.RecorderStartButton2.Primary = false;
            this.RecorderStartButton2.Size = new System.Drawing.Size(78, 36);
            this.RecorderStartButton2.TabIndex = 2;
            this.RecorderStartButton2.Text = "Start";
            this.RecorderStartButton2.UseVisualStyleBackColor = true;
            this.RecorderStartButton2.Click += new System.EventHandler(this.RecorderStartButton2_Click);
            // 
            // RecorderendButton1
            // 
            this.RecorderendButton1.AutoSize = true;
            this.RecorderendButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RecorderendButton1.Depth = 0;
            this.RecorderendButton1.Location = new System.Drawing.Point(13, 347);
            this.RecorderendButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RecorderendButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecorderendButton1.Name = "RecorderendButton1";
            this.RecorderendButton1.Primary = false;
            this.RecorderendButton1.Size = new System.Drawing.Size(128, 36);
            this.RecorderendButton1.TabIndex = 3;
            this.RecorderendButton1.Text = "END & SAVE";
            this.RecorderendButton1.UseVisualStyleBackColor = true;
            this.RecorderendButton1.Click += new System.EventHandler(this.RecorderendButton1_Click);
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.BackColor = System.Drawing.Color.Black;
            this.richTextBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxScript.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxScript.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxScript.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.Size = new System.Drawing.Size(283, 422);
            this.richTextBoxScript.TabIndex = 5;
            this.richTextBoxScript.Text = "";
            this.richTextBoxScript.SelectionChanged += new System.EventHandler(this.richTextBoxScript_SelectionChanged);
            this.richTextBoxScript.VScroll += new System.EventHandler(this.richTextBoxScript_VScroll);
            this.richTextBoxScript.FontChanged += new System.EventHandler(this.richTextBoxScript_FontChanged);
            this.richTextBoxScript.TextChanged += new System.EventHandler(this.richTextBoxScript_TextChanged);
            // 
            // richTextBoxLineNumber
            // 
            this.richTextBoxLineNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxLineNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLineNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxLineNumber.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLineNumber.Name = "richTextBoxLineNumber";
            this.richTextBoxLineNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLineNumber.Size = new System.Drawing.Size(84, 422);
            this.richTextBoxLineNumber.TabIndex = 6;
            this.richTextBoxLineNumber.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(172, 109);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxLineNumber);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxScript);
            this.splitContainer1.Size = new System.Drawing.Size(371, 422);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 7;
            // 
            // loadmacroFlatButton
            // 
            this.loadmacroFlatButton.AutoSize = true;
            this.loadmacroFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadmacroFlatButton.Depth = 0;
            this.loadmacroFlatButton.Location = new System.Drawing.Point(13, 169);
            this.loadmacroFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadmacroFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadmacroFlatButton.Name = "loadmacroFlatButton";
            this.loadmacroFlatButton.Primary = false;
            this.loadmacroFlatButton.Size = new System.Drawing.Size(142, 36);
            this.loadmacroFlatButton.TabIndex = 8;
            this.loadmacroFlatButton.Text = "LOAD SCRIPT";
            this.loadmacroFlatButton.UseVisualStyleBackColor = true;
            this.loadmacroFlatButton.Click += new System.EventHandler(this.loadmacroFlatButton_Click);
            // 
            // createmacroFlatButton1
            // 
            this.createmacroFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.createmacroFlatButton1.AutoSize = true;
            this.createmacroFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createmacroFlatButton1.Depth = 0;
            this.createmacroFlatButton1.Location = new System.Drawing.Point(13, 405);
            this.createmacroFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createmacroFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.createmacroFlatButton1.Name = "createmacroFlatButton1";
            this.createmacroFlatButton1.Primary = false;
            this.createmacroFlatButton1.Size = new System.Drawing.Size(143, 36);
            this.createmacroFlatButton1.TabIndex = 9;
            this.createmacroFlatButton1.Text = "MACRO SAVE";
            this.createmacroFlatButton1.UseVisualStyleBackColor = true;
            this.createmacroFlatButton1.Click += new System.EventHandler(this.createmacroFlatButton1_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(646, 110);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(285, 421);
            this.panel.TabIndex = 10;
            // 
            // addkey_btn
            // 
            this.addkey_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addkey_btn.Depth = 0;
            this.addkey_btn.Location = new System.Drawing.Point(937, 108);
            this.addkey_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addkey_btn.Name = "addkey_btn";
            this.addkey_btn.Primary = true;
            this.addkey_btn.Size = new System.Drawing.Size(123, 29);
            this.addkey_btn.TabIndex = 12;
            this.addkey_btn.Text = "Add Key";
            this.addkey_btn.UseVisualStyleBackColor = true;
            this.addkey_btn.Click += new System.EventHandler(this.addkey_btn_Click);
            // 
            // keypad_btn
            // 
            this.keypad_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keypad_btn.BackColor = System.Drawing.Color.White;
            this.keypad_btn.Enabled = false;
            this.keypad_btn.Image = ((System.Drawing.Image)(resources.GetObject("keypad_btn.Image")));
            this.keypad_btn.Location = new System.Drawing.Point(549, 462);
            this.keypad_btn.Name = "keypad_btn";
            this.keypad_btn.Size = new System.Drawing.Size(61, 69);
            this.keypad_btn.TabIndex = 11;
            this.keypad_btn.UseVisualStyleBackColor = false;
            this.keypad_btn.Click += new System.EventHandler(this.keypad_btn_Click);
            // 
            // newline_btn
            // 
            this.newline_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newline_btn.BackColor = System.Drawing.Color.White;
            this.newline_btn.Enabled = false;
            this.newline_btn.Image = ((System.Drawing.Image)(resources.GetObject("newline_btn.Image")));
            this.newline_btn.Location = new System.Drawing.Point(549, 386);
            this.newline_btn.Name = "newline_btn";
            this.newline_btn.Size = new System.Drawing.Size(60, 70);
            this.newline_btn.TabIndex = 13;
            this.newline_btn.UseVisualStyleBackColor = false;
            this.newline_btn.Click += new System.EventHandler(this.newline_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_btn.BackColor = System.Drawing.Color.White;
            this.setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("setting_btn.Image")));
            this.setting_btn.Location = new System.Drawing.Point(549, 301);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(61, 79);
            this.setting_btn.TabIndex = 14;
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // RCrecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 548);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.newline_btn);
            this.Controls.Add(this.addkey_btn);
            this.Controls.Add(this.keypad_btn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.createmacroFlatButton1);
            this.Controls.Add(this.loadmacroFlatButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.RecorderendButton1);
            this.Controls.Add(this.RecorderStartButton2);
            this.Controls.Add(this.LoadDBButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RCrecorderForm";
            this.Text = "RCrecoder v1.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RCrecorderForm_FormClosing);
            this.Load += new System.EventHandler(this.RCrecorderForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton LoadDBButton1;
        private MaterialSkin.Controls.MaterialFlatButton RecorderStartButton2;
        private MaterialSkin.Controls.MaterialFlatButton RecorderendButton1;
        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.RichTextBox richTextBoxLineNumber;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialFlatButton loadmacroFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton createmacroFlatButton1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button keypad_btn;
        private MaterialSkin.Controls.MaterialRaisedButton addkey_btn;
        private System.Windows.Forms.Button newline_btn;
        private System.Windows.Forms.Button setting_btn;
    }
}

