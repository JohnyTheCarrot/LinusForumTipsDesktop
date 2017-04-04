namespace SpecsBoss.Components
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aluminiumcoreLibVersionLabel = new System.Windows.Forms.Label();
            this.specsverLabel = new System.Windows.Forms.Label();
            this.buildLabel = new System.Windows.Forms.Label();
            this.ossLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aluminiumcoreLibVersionLabel
            // 
            this.aluminiumcoreLibVersionLabel.AutoSize = true;
            this.aluminiumcoreLibVersionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aluminiumcoreLibVersionLabel.Location = new System.Drawing.Point(14, 65);
            this.aluminiumcoreLibVersionLabel.Name = "aluminiumcoreLibVersionLabel";
            this.aluminiumcoreLibVersionLabel.Size = new System.Drawing.Size(209, 20);
            this.aluminiumcoreLibVersionLabel.TabIndex = 56;
            this.aluminiumcoreLibVersionLabel.Text = "AluminiumCoreLibrary Version";
            // 
            // specsverLabel
            // 
            this.specsverLabel.AutoSize = true;
            this.specsverLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specsverLabel.Location = new System.Drawing.Point(14, 21);
            this.specsverLabel.Name = "specsverLabel";
            this.specsverLabel.Size = new System.Drawing.Size(218, 20);
            this.specsverLabel.TabIndex = 55;
            this.specsverLabel.Text = "LinusForumTipsDesktop Version";
            // 
            // buildLabel
            // 
            this.buildLabel.AutoSize = true;
            this.buildLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildLabel.Location = new System.Drawing.Point(14, 113);
            this.buildLabel.Name = "buildLabel";
            this.buildLabel.Size = new System.Drawing.Size(79, 20);
            this.buildLabel.TabIndex = 54;
            this.buildLabel.Text = "Build Date";
            // 
            // ossLabel
            // 
            this.ossLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ossLabel.AutoSize = true;
            this.ossLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ossLabel.Location = new System.Drawing.Point(8, 162);
            this.ossLabel.Name = "ossLabel";
            this.ossLabel.Size = new System.Drawing.Size(634, 231);
            this.ossLabel.TabIndex = 57;
            this.ossLabel.Text = resources.GetString("ossLabel.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 400);
            this.Controls.Add(this.ossLabel);
            this.Controls.Add(this.aluminiumcoreLibVersionLabel);
            this.Controls.Add(this.specsverLabel);
            this.Controls.Add(this.buildLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aluminiumcoreLibVersionLabel;
        private System.Windows.Forms.Label specsverLabel;
        private System.Windows.Forms.Label buildLabel;
        private System.Windows.Forms.Label ossLabel;
    }
}