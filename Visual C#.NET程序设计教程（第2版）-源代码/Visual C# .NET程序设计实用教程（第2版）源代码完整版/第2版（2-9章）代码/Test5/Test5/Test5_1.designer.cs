﻿namespace Test5_1
{
    partial class Test5_1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名：";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(58, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(75, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "价格：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(306, 9);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(306, 43);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "统计";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(15, 79);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(366, 79);
            this.lblShow.TabIndex = 3;
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "计算机",
            "小说"});
            this.cbbType.Location = new System.Drawing.Point(182, 9);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(75, 20);
            this.cbbType.TabIndex = 4;
            // 
            // Test5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 176);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test5_1";
            this.Text = "Test5_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.ComboBox cbbType;
    }
}

