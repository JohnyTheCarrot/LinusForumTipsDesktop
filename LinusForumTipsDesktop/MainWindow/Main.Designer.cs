namespace LinusForumTipsDesktop.MainWindow
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.title = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.paneView = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.fullscreenSwitcherButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(68, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(111, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Title Size";
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 21);
            this.label.TabIndex = 1;
            this.label.Text = "Label Size";
            // 
            // paneView
            // 
            this.paneView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneView.Location = new System.Drawing.Point(3, 125);
            this.paneView.Name = "paneView";
            this.paneView.Size = new System.Drawing.Size(1013, 592);
            this.paneView.TabIndex = 2;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::LinusForumTipsDesktop.Properties.Resources.Logo_50;
            this.logoBox.Location = new System.Drawing.Point(12, 9);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(50, 50);
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(932, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fullscreenSwitcherButton
            // 
            this.fullscreenSwitcherButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullscreenSwitcherButton.Location = new System.Drawing.Point(851, 9);
            this.fullscreenSwitcherButton.Name = "fullscreenSwitcherButton";
            this.fullscreenSwitcherButton.Size = new System.Drawing.Size(75, 50);
            this.fullscreenSwitcherButton.TabIndex = 5;
            this.fullscreenSwitcherButton.Text = "Fullscreen";
            this.fullscreenSwitcherButton.UseVisualStyleBackColor = true;
            this.fullscreenSwitcherButton.Click += new System.EventHandler(this.fullscreenSwitcherButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(770, 9);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 50);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // feedbackButton
            // 
            this.feedbackButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackButton.Location = new System.Drawing.Point(689, 9);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(75, 50);
            this.feedbackButton.TabIndex = 7;
            this.feedbackButton.Text = "Feedback";
            this.feedbackButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 748);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.fullscreenSwitcherButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.paneView);
            this.Controls.Add(this.label);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel paneView;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button fullscreenSwitcherButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button feedbackButton;
    }
}