namespace Total_Commander
{
    partial class Form4
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
            this.labelFileCopyInfo = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileCopyInfo
            // 
            this.labelFileCopyInfo.AutoSize = true;
            this.labelFileCopyInfo.Location = new System.Drawing.Point(18, 22);
            this.labelFileCopyInfo.Name = "labelFileCopyInfo";
            this.labelFileCopyInfo.Size = new System.Drawing.Size(46, 17);
            this.labelFileCopyInfo.TabIndex = 9;
            this.labelFileCopyInfo.Text = "label1";
            // 
            // buttonReplace
            // 
            this.buttonReplace.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonReplace.Location = new System.Drawing.Point(132, 69);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 8;
            this.buttonReplace.Text = "Yes";
            this.buttonReplace.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.buttonSkip.Location = new System.Drawing.Point(18, 69);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 23);
            this.buttonSkip.TabIndex = 7;
            this.buttonSkip.Text = "No";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 114);
            this.ControlBox = false;
            this.Controls.Add(this.labelFileCopyInfo);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonSkip);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileCopyInfo;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonSkip;
    }
}