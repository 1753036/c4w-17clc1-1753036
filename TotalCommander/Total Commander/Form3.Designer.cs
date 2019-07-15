namespace Total_Commander
{
    partial class Form3
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
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.labelFileCopyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSkip
            // 
            this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.buttonSkip.Location = new System.Drawing.Point(13, 60);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 23);
            this.buttonSkip.TabIndex = 0;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // buttonReplace
            // 
            this.buttonReplace.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonReplace.Location = new System.Drawing.Point(127, 60);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 2;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            // 
            // labelFileCopyInfo
            // 
            this.labelFileCopyInfo.AutoSize = true;
            this.labelFileCopyInfo.Location = new System.Drawing.Point(13, 13);
            this.labelFileCopyInfo.Name = "labelFileCopyInfo";
            this.labelFileCopyInfo.Size = new System.Drawing.Size(46, 17);
            this.labelFileCopyInfo.TabIndex = 3;
            this.labelFileCopyInfo.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 93);
            this.ControlBox = false;
            this.Controls.Add(this.labelFileCopyInfo);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonSkip);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label labelFileCopyInfo;
    }
}