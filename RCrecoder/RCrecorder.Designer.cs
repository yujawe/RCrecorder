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
            this.keyLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.LoadDBButton1.Location = new System.Drawing.Point(2, 124);
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
            this.RecorderStartButton2.Location = new System.Drawing.Point(140, 124);
            this.RecorderStartButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RecorderStartButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecorderStartButton2.Name = "RecorderStartButton2";
            this.RecorderStartButton2.Primary = false;
            this.RecorderStartButton2.Size = new System.Drawing.Size(186, 36);
            this.RecorderStartButton2.TabIndex = 2;
            this.RecorderStartButton2.Text = "Recorder Start";
            this.RecorderStartButton2.UseVisualStyleBackColor = true;
            this.RecorderStartButton2.Click += new System.EventHandler(this.RecorderStartButton2_Click);
            // 
            // RecorderendButton1
            // 
            this.RecorderendButton1.AutoSize = true;
            this.RecorderendButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RecorderendButton1.Depth = 0;
            this.RecorderendButton1.Enabled = false;
            this.RecorderendButton1.Location = new System.Drawing.Point(334, 124);
            this.RecorderendButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RecorderendButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecorderendButton1.Name = "RecorderendButton1";
            this.RecorderendButton1.Primary = false;
            this.RecorderendButton1.Size = new System.Drawing.Size(162, 36);
            this.RecorderendButton1.TabIndex = 3;
            this.RecorderendButton1.Text = "RECORDER END";
            this.RecorderendButton1.UseVisualStyleBackColor = true;
            this.RecorderendButton1.Click += new System.EventHandler(this.RecorderendButton1_Click);
            // 
            // keyLineTextField1
            // 
            this.keyLineTextField1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyLineTextField1.Depth = 0;
            this.keyLineTextField1.Hint = "";
            this.keyLineTextField1.Location = new System.Drawing.Point(306, 83);
            this.keyLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyLineTextField1.Name = "keyLineTextField1";
            this.keyLineTextField1.PasswordChar = '\0';
            this.keyLineTextField1.SelectedText = "";
            this.keyLineTextField1.SelectionLength = 0;
            this.keyLineTextField1.SelectionStart = 0;
            this.keyLineTextField1.Size = new System.Drawing.Size(190, 32);
            this.keyLineTextField1.TabIndex = 4;
            this.keyLineTextField1.Text = "keytext";
            this.keyLineTextField1.UseSystemPasswordChar = false;
            // 
            // RCrecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 163);
            this.Controls.Add(this.keyLineTextField1);
            this.Controls.Add(this.RecorderendButton1);
            this.Controls.Add(this.RecorderStartButton2);
            this.Controls.Add(this.LoadDBButton1);
            this.Name = "RCrecorderForm";
            this.Text = "RCrecoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RCrecorderForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton LoadDBButton1;
        private MaterialSkin.Controls.MaterialFlatButton RecorderStartButton2;
        private MaterialSkin.Controls.MaterialFlatButton RecorderendButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField keyLineTextField1;
    }
}

