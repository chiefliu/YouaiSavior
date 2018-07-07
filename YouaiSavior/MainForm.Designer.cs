namespace YouaiSavior
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateClientBtn = new MetroFramework.Controls.MetroButton();
            this.NgaBtn = new MetroFramework.Controls.MetroButton();
            this.WebLinkBtn1 = new MetroFramework.Controls.MetroButton();
            this.WebLinkBtn2 = new MetroFramework.Controls.MetroButton();
            this.EverykeyBtn = new MetroFramework.Controls.MetroButton();
            this.EveryLabel = new MetroFramework.Controls.MetroLabel();
            this.ClientVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.AddonVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.HowToUseBtn = new MetroFramework.Controls.MetroButton();
            this.bodyInfo = new MetroFramework.Controls.MetroTextBox();
            this.settingPicture = new System.Windows.Forms.PictureBox();
            this.wowPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateClientBtn
            // 
            this.UpdateClientBtn.Location = new System.Drawing.Point(700, 13);
            this.UpdateClientBtn.Name = "UpdateClientBtn";
            this.UpdateClientBtn.Size = new System.Drawing.Size(51, 23);
            this.UpdateClientBtn.TabIndex = 4;
            this.UpdateClientBtn.Text = "升级";
            this.UpdateClientBtn.UseSelectable = true;
            this.UpdateClientBtn.Visible = false;
            this.UpdateClientBtn.Click += new System.EventHandler(this.UpdateClientBtn_Click);
            // 
            // NgaBtn
            // 
            this.NgaBtn.Location = new System.Drawing.Point(12, 438);
            this.NgaBtn.Name = "NgaBtn";
            this.NgaBtn.Size = new System.Drawing.Size(102, 23);
            this.NgaBtn.TabIndex = 6;
            this.NgaBtn.Text = "NGA主贴";
            this.NgaBtn.UseSelectable = true;
            this.NgaBtn.Click += new System.EventHandler(this.NgaBtn_Click);
            // 
            // WebLinkBtn1
            // 
            this.WebLinkBtn1.Location = new System.Drawing.Point(152, 438);
            this.WebLinkBtn1.Name = "WebLinkBtn1";
            this.WebLinkBtn1.Size = new System.Drawing.Size(125, 23);
            this.WebLinkBtn1.TabIndex = 7;
            this.WebLinkBtn1.Text = "插件下载1";
            this.WebLinkBtn1.UseSelectable = true;
            this.WebLinkBtn1.Visible = false;
            this.WebLinkBtn1.Click += new System.EventHandler(this.WebLinkBtn1_Click);
            // 
            // WebLinkBtn2
            // 
            this.WebLinkBtn2.Location = new System.Drawing.Point(313, 438);
            this.WebLinkBtn2.Name = "WebLinkBtn2";
            this.WebLinkBtn2.Size = new System.Drawing.Size(125, 23);
            this.WebLinkBtn2.TabIndex = 8;
            this.WebLinkBtn2.Text = "插件下载2";
            this.WebLinkBtn2.UseSelectable = true;
            this.WebLinkBtn2.Visible = false;
            this.WebLinkBtn2.Click += new System.EventHandler(this.WebLinkBtn2_Click);
            // 
            // EverykeyBtn
            // 
            this.EverykeyBtn.Location = new System.Drawing.Point(568, 167);
            this.EverykeyBtn.Name = "EverykeyBtn";
            this.EverykeyBtn.Size = new System.Drawing.Size(99, 29);
            this.EverykeyBtn.TabIndex = 11;
            this.EverykeyBtn.Text = "主交互";
            this.EverykeyBtn.UseSelectable = true;
            this.EverykeyBtn.Visible = false;
            this.EverykeyBtn.Click += new System.EventHandler(this.EverykeyBtn_Click);
            // 
            // EveryLabel
            // 
            this.EveryLabel.AutoSize = true;
            this.EveryLabel.Location = new System.Drawing.Point(580, 237);
            this.EveryLabel.Name = "EveryLabel";
            this.EveryLabel.Size = new System.Drawing.Size(51, 19);
            this.EveryLabel.TabIndex = 12;
            this.EveryLabel.Text = "主交互";
            this.EveryLabel.Visible = false;
            // 
            // ClientVersionLabel
            // 
            this.ClientVersionLabel.AutoSize = true;
            this.ClientVersionLabel.Location = new System.Drawing.Point(613, 13);
            this.ClientVersionLabel.Name = "ClientVersionLabel";
            this.ClientVersionLabel.Size = new System.Drawing.Size(81, 19);
            this.ClientVersionLabel.TabIndex = 13;
            this.ClientVersionLabel.Text = "metroLabel1";
            // 
            // AddonVersionLabel
            // 
            this.AddonVersionLabel.AutoSize = true;
            this.AddonVersionLabel.Location = new System.Drawing.Point(509, 106);
            this.AddonVersionLabel.Name = "AddonVersionLabel";
            this.AddonVersionLabel.Size = new System.Drawing.Size(81, 19);
            this.AddonVersionLabel.TabIndex = 14;
            this.AddonVersionLabel.Text = "metroLabel1";
            // 
            // HowToUseBtn
            // 
            this.HowToUseBtn.Location = new System.Drawing.Point(669, 438);
            this.HowToUseBtn.Name = "HowToUseBtn";
            this.HowToUseBtn.Size = new System.Drawing.Size(82, 23);
            this.HowToUseBtn.TabIndex = 15;
            this.HowToUseBtn.Text = "使用指南";
            this.HowToUseBtn.UseSelectable = true;
            // 
            // bodyInfo
            // 
            // 
            // 
            // 
            this.bodyInfo.CustomButton.Image = null;
            this.bodyInfo.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.bodyInfo.CustomButton.Name = "";
            this.bodyInfo.CustomButton.Size = new System.Drawing.Size(197, 197);
            this.bodyInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bodyInfo.CustomButton.TabIndex = 1;
            this.bodyInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bodyInfo.CustomButton.UseSelectable = true;
            this.bodyInfo.CustomButton.Visible = false;
            this.bodyInfo.Lines = new string[] {
        "无法解析插件信息。"};
            this.bodyInfo.Location = new System.Drawing.Point(12, 132);
            this.bodyInfo.MaxLength = 32767;
            this.bodyInfo.Multiline = true;
            this.bodyInfo.Name = "bodyInfo";
            this.bodyInfo.PasswordChar = '\0';
            this.bodyInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bodyInfo.SelectedText = "";
            this.bodyInfo.SelectionLength = 0;
            this.bodyInfo.SelectionStart = 0;
            this.bodyInfo.ShortcutsEnabled = true;
            this.bodyInfo.Size = new System.Drawing.Size(376, 202);
            this.bodyInfo.TabIndex = 16;
            this.bodyInfo.Text = "无法解析插件信息。";
            this.bodyInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bodyInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bodyInfo.UseSelectable = true;
            this.bodyInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bodyInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // settingPicture
            // 
            this.settingPicture.Image = global::YouaiSavior.Properties.Resources.settings;
            this.settingPicture.InitialImage = global::YouaiSavior.Properties.Resources.settings;
            this.settingPicture.Location = new System.Drawing.Point(23, 60);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(53, 41);
            this.settingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingPicture.TabIndex = 17;
            this.settingPicture.TabStop = false;
            this.settingPicture.Click += new System.EventHandler(this.settingPicture_Click);
            // 
            // wowPath
            // 
            this.wowPath.AutoSize = true;
            this.wowPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wowPath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wowPath.ForeColor = System.Drawing.Color.DodgerBlue;
            this.wowPath.Location = new System.Drawing.Point(91, 72);
            this.wowPath.Name = "wowPath";
            this.wowPath.Size = new System.Drawing.Size(76, 16);
            this.wowPath.TabIndex = 18;
            this.wowPath.Text = "选择目录";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 484);
            this.Controls.Add(this.wowPath);
            this.Controls.Add(this.settingPicture);
            this.Controls.Add(this.bodyInfo);
            this.Controls.Add(this.HowToUseBtn);
            this.Controls.Add(this.AddonVersionLabel);
            this.Controls.Add(this.ClientVersionLabel);
            this.Controls.Add(this.EveryLabel);
            this.Controls.Add(this.EverykeyBtn);
            this.Controls.Add(this.WebLinkBtn2);
            this.Controls.Add(this.WebLinkBtn1);
            this.Controls.Add(this.NgaBtn);
            this.Controls.Add(this.UpdateClientBtn);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "有爱复刻版";
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel ClientVersionLabel;
        private MetroFramework.Controls.MetroLabel AddonVersionLabel;
        private MetroFramework.Controls.MetroButton HowToUseBtn;
        private MetroFramework.Controls.MetroTextBox bodyInfo;
        private System.Windows.Forms.PictureBox settingPicture;
        private MetroFramework.Controls.MetroButton UpdateClientBtn;
        private MetroFramework.Controls.MetroButton NgaBtn;
        private MetroFramework.Controls.MetroButton WebLinkBtn1;
        private MetroFramework.Controls.MetroButton WebLinkBtn2;
        private MetroFramework.Controls.MetroButton EverykeyBtn;
        private MetroFramework.Controls.MetroLabel EveryLabel;
        private System.Windows.Forms.Label wowPath;
    }
}

