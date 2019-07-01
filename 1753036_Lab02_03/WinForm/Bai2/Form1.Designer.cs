namespace WindowsForms_Table
{
    partial class Form1
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
            this.tbDong = new System.Windows.Forms.TextBox();
            this.tbCot = new System.Windows.Forms.TextBox();
            this.btnTaoForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDong
            // 
            this.tbDong.Location = new System.Drawing.Point(90, 23);
            this.tbDong.Name = "tbDong";
            this.tbDong.Size = new System.Drawing.Size(100, 22);
            this.tbDong.TabIndex = 0;
            // 
            // tbCot
            // 
            this.tbCot.Location = new System.Drawing.Point(90, 52);
            this.tbCot.Name = "tbCot";
            this.tbCot.Size = new System.Drawing.Size(100, 22);
            this.tbCot.TabIndex = 1;
            // 
            // btnTaoForm
            // 
            this.btnTaoForm.Location = new System.Drawing.Point(41, 81);
            this.btnTaoForm.Name = "btnTaoForm";
            this.btnTaoForm.Size = new System.Drawing.Size(149, 30);
            this.btnTaoForm.TabIndex = 2;
            this.btnTaoForm.Text = "Tạo form";
            this.btnTaoForm.UseVisualStyleBackColor = true;
            this.btnTaoForm.Click += new System.EventHandler(this.btnTaoForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cột";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoForm);
            this.Controls.Add(this.tbCot);
            this.Controls.Add(this.tbDong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDong;
        private System.Windows.Forms.TextBox tbCot;
        private System.Windows.Forms.Button btnTaoForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

