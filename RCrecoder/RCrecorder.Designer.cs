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
            this.LoadDBButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.RecorderStartButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.RecorderendButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLineNumber = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loadmacroFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.createmacroFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.richTextBoxScript.Size = new System.Drawing.Size(576, 364);
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
            this.richTextBoxLineNumber.Size = new System.Drawing.Size(138, 364);
            this.richTextBoxLineNumber.TabIndex = 6;
            this.richTextBoxLineNumber.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(221, 110);
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
            this.splitContainer1.Size = new System.Drawing.Size(718, 364);
            this.splitContainer1.SplitterDistance = 138;
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
            // RCrecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 486);
            this.Controls.Add(this.createmacroFlatButton1);
            this.Controls.Add(this.loadmacroFlatButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.RecorderendButton1);
            this.Controls.Add(this.RecorderStartButton2);
            this.Controls.Add(this.LoadDBButton1);
            this.Name = "RCrecorderForm";
            this.Text = "RCrecoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RCrecorderForm_FormClosing);
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
    }
}

