namespace SpecsBoss.FirstTimeSetup
{
    partial class ThemeSelector
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
            this.themeSelectorTitle = new System.Windows.Forms.Label();
            this.previewDark = new System.Windows.Forms.Button();
            this.previewLight = new System.Windows.Forms.Button();
            this.selectDark = new System.Windows.Forms.Button();
            this.selectLight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themeSelectorTitle
            // 
            this.themeSelectorTitle.AutoSize = true;
            this.themeSelectorTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeSelectorTitle.Location = new System.Drawing.Point(67, 20);
            this.themeSelectorTitle.Name = "themeSelectorTitle";
            this.themeSelectorTitle.Size = new System.Drawing.Size(331, 30);
            this.themeSelectorTitle.TabIndex = 0;
            this.themeSelectorTitle.Text = "Select the theme you\'d like to use.";
            // 
            // previewDark
            // 
            this.previewDark.Location = new System.Drawing.Point(280, 76);
            this.previewDark.Name = "previewDark";
            this.previewDark.Size = new System.Drawing.Size(184, 39);
            this.previewDark.TabIndex = 1;
            this.previewDark.Text = "Preview Dark Theme";
            this.previewDark.UseVisualStyleBackColor = true;
            this.previewDark.Click += new System.EventHandler(this.previewDark_Click);
            // 
            // previewLight
            // 
            this.previewLight.Location = new System.Drawing.Point(25, 76);
            this.previewLight.Name = "previewLight";
            this.previewLight.Size = new System.Drawing.Size(184, 39);
            this.previewLight.TabIndex = 2;
            this.previewLight.Text = "Preview Light Theme";
            this.previewLight.UseVisualStyleBackColor = true;
            this.previewLight.Click += new System.EventHandler(this.previewLight_Click);
            // 
            // selectDark
            // 
            this.selectDark.Location = new System.Drawing.Point(280, 178);
            this.selectDark.Name = "selectDark";
            this.selectDark.Size = new System.Drawing.Size(184, 39);
            this.selectDark.TabIndex = 3;
            this.selectDark.Text = "Select Dark Theme";
            this.selectDark.UseVisualStyleBackColor = true;
            this.selectDark.Click += new System.EventHandler(this.selectDark_Click);
            // 
            // selectLight
            // 
            this.selectLight.Location = new System.Drawing.Point(25, 178);
            this.selectLight.Name = "selectLight";
            this.selectLight.Size = new System.Drawing.Size(184, 39);
            this.selectLight.TabIndex = 4;
            this.selectLight.Text = "Select Light Theme";
            this.selectLight.UseVisualStyleBackColor = true;
            this.selectLight.Click += new System.EventHandler(this.selectLight_Click);
            // 
            // ThemeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 239);
            this.Controls.Add(this.selectLight);
            this.Controls.Add(this.selectDark);
            this.Controls.Add(this.previewLight);
            this.Controls.Add(this.previewDark);
            this.Controls.Add(this.themeSelectorTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme Selector";
            this.Load += new System.EventHandler(this.ThemeSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label themeSelectorTitle;
        private System.Windows.Forms.Button previewDark;
        private System.Windows.Forms.Button previewLight;
        private System.Windows.Forms.Button selectDark;
        private System.Windows.Forms.Button selectLight;
    }
}