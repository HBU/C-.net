﻿namespace Test7_5
{
    partial class Test7_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnChackEmail = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 21);
            this.txtEmail.TabIndex = 1;
            // 
            // btnChackEmail
            // 
            this.btnChackEmail.Location = new System.Drawing.Point(152, 37);
            this.btnChackEmail.Name = "btnChackEmail";
            this.btnChackEmail.Size = new System.Drawing.Size(75, 23);
            this.btnChackEmail.TabIndex = 2;
            this.btnChackEmail.Text = "检查";
            this.btnChackEmail.UseVisualStyleBackColor = true;
            this.btnChackEmail.Click += new System.EventHandler(this.btnChackEmail_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(13, 74);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 12);
            this.lblShow.TabIndex = 0;
            // 
            // Test7_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 95);
            this.Controls.Add(this.btnChackEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.Name = "Test7_5";
            this.Text = "Test7_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnChackEmail;
        private System.Windows.Forms.Label lblShow;
    }
}