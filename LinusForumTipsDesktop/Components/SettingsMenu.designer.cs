namespace Lithium_Browser.Components
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.settingdTab = new System.Windows.Forms.TabControl();
            this.thirdPartyPage = new System.Windows.Forms.TabPage();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.preferencedPage = new System.Windows.Forms.TabPage();
            this.theme = new System.Windows.Forms.CheckBox();
            this.tellemtryPage = new System.Windows.Forms.TabPage();
            this.tellemtry = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.settingdTab.SuspendLayout();
            this.thirdPartyPage.SuspendLayout();
            this.preferencedPage.SuspendLayout();
            this.tellemtryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingdTab
            // 
            this.settingdTab.Controls.Add(this.thirdPartyPage);
            this.settingdTab.Controls.Add(this.preferencedPage);
            this.settingdTab.Controls.Add(this.tellemtryPage);
            this.settingdTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingdTab.Location = new System.Drawing.Point(3, 3);
            this.settingdTab.Name = "settingdTab";
            this.settingdTab.SelectedIndex = 0;
            this.settingdTab.Size = new System.Drawing.Size(681, 368);
            this.settingdTab.TabIndex = 44;
            // 
            // thirdPartyPage
            // 
            this.thirdPartyPage.Controls.Add(this.aboutLabel);
            this.thirdPartyPage.Location = new System.Drawing.Point(4, 26);
            this.thirdPartyPage.Name = "thirdPartyPage";
            this.thirdPartyPage.Padding = new System.Windows.Forms.Padding(3);
            this.thirdPartyPage.Size = new System.Drawing.Size(673, 338);
            this.thirdPartyPage.TabIndex = 0;
            this.thirdPartyPage.Text = "Use of third party software";
            this.thirdPartyPage.UseVisualStyleBackColor = true;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.Black;
            this.aboutLabel.Location = new System.Drawing.Point(20, 21);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(624, 147);
            this.aboutLabel.TabIndex = 3;
            this.aboutLabel.Text = resources.GetString("aboutLabel.Text");
            // 
            // preferencedPage
            // 
            this.preferencedPage.Controls.Add(this.theme);
            this.preferencedPage.Location = new System.Drawing.Point(4, 26);
            this.preferencedPage.Name = "preferencedPage";
            this.preferencedPage.Padding = new System.Windows.Forms.Padding(3);
            this.preferencedPage.Size = new System.Drawing.Size(673, 338);
            this.preferencedPage.TabIndex = 2;
            this.preferencedPage.Text = "Preferences";
            this.preferencedPage.UseVisualStyleBackColor = true;
            // 
            // theme
            // 
            this.theme.AutoSize = true;
            this.theme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme.Location = new System.Drawing.Point(29, 28);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(163, 25);
            this.theme.TabIndex = 43;
            this.theme.Text = "Enable Dark Theme";
            this.theme.UseVisualStyleBackColor = true;
            this.theme.CheckedChanged += new System.EventHandler(this.theme_CheckedChanged);
            // 
            // tellemtryPage
            // 
            this.tellemtryPage.Controls.Add(this.tellemtry);
            this.tellemtryPage.Location = new System.Drawing.Point(4, 26);
            this.tellemtryPage.Name = "tellemtryPage";
            this.tellemtryPage.Padding = new System.Windows.Forms.Padding(3);
            this.tellemtryPage.Size = new System.Drawing.Size(673, 338);
            this.tellemtryPage.TabIndex = 5;
            this.tellemtryPage.Text = "Tellemetry Data";
            this.tellemtryPage.UseVisualStyleBackColor = true;
            // 
            // tellemtry
            // 
            this.tellemtry.AutoSize = true;
            this.tellemtry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellemtry.ForeColor = System.Drawing.Color.Black;
            this.tellemtry.Location = new System.Drawing.Point(21, 28);
            this.tellemtry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tellemtry.Name = "tellemtry";
            this.tellemtry.Size = new System.Drawing.Size(599, 231);
            this.tellemtry.TabIndex = 4;
            this.tellemtry.Text = resources.GetString("tellemtry.Text");
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(434, 377);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(109, 36);
            this.doneBtn.TabIndex = 45;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.Done_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(280, 377);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(127, 36);
            this.applyBtn.TabIndex = 47;
            this.applyBtn.Text = "Apply Settings";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 425);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.settingdTab);
            this.Controls.Add(this.doneBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsMenu_FormClosing);
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            this.settingdTab.ResumeLayout(false);
            this.thirdPartyPage.ResumeLayout(false);
            this.thirdPartyPage.PerformLayout();
            this.preferencedPage.ResumeLayout(false);
            this.preferencedPage.PerformLayout();
            this.tellemtryPage.ResumeLayout(false);
            this.tellemtryPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingdTab;
        private System.Windows.Forms.TabPage thirdPartyPage;
        private System.Windows.Forms.TabPage preferencedPage;
        private System.Windows.Forms.CheckBox theme;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TabPage tellemtryPage;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label tellemtry;
    }
}