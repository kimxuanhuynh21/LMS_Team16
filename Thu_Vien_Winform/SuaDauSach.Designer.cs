﻿namespace Thu_Vien_Winform
{
    partial class SuaDauSach
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_sumnumber = new System.Windows.Forms.TextBox();
            this.txt_republish = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_summary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_state = new System.Windows.Forms.ComboBox();
            this.cbb_producer = new System.Windows.Forms.ComboBox();
            this.cbb_author = new System.Windows.Forms.ComboBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 374);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(73, 374);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Lưu";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_sumnumber
            // 
            this.txt_sumnumber.Location = new System.Drawing.Point(156, 269);
            this.txt_sumnumber.Name = "txt_sumnumber";
            this.txt_sumnumber.Size = new System.Drawing.Size(180, 20);
            this.txt_sumnumber.TabIndex = 18;
            // 
            // txt_republish
            // 
            this.txt_republish.Location = new System.Drawing.Point(156, 188);
            this.txt_republish.Name = "txt_republish";
            this.txt_republish.Size = new System.Drawing.Size(180, 20);
            this.txt_republish.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tình Trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tổng Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhà Sản Xuất";
            // 
            // txt_summary
            // 
            this.txt_summary.Location = new System.Drawing.Point(156, 148);
            this.txt_summary.Name = "txt_summary";
            this.txt_summary.Size = new System.Drawing.Size(180, 20);
            this.txt_summary.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tái bản";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(156, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 20);
            this.txt_name.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tóm Tắt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tác Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên";
            // 
            // cbb_state
            // 
            this.cbb_state.FormattingEnabled = true;
            this.cbb_state.Location = new System.Drawing.Point(156, 309);
            this.cbb_state.Name = "cbb_state";
            this.cbb_state.Size = new System.Drawing.Size(180, 21);
            this.cbb_state.TabIndex = 6;
            // 
            // cbb_producer
            // 
            this.cbb_producer.FormattingEnabled = true;
            this.cbb_producer.Location = new System.Drawing.Point(156, 228);
            this.cbb_producer.Name = "cbb_producer";
            this.cbb_producer.Size = new System.Drawing.Size(180, 21);
            this.cbb_producer.TabIndex = 5;
            // 
            // cbb_author
            // 
            this.cbb_author.FormattingEnabled = true;
            this.cbb_author.Location = new System.Drawing.Point(156, 107);
            this.cbb_author.Name = "cbb_author";
            this.cbb_author.Size = new System.Drawing.Size(180, 21);
            this.cbb_author.TabIndex = 7;
            // 
            // cbb_category
            // 
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(156, 66);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(180, 21);
            this.cbb_category.TabIndex = 4;
            // 
            // SuaDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 422);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_sumnumber);
            this.Controls.Add(this.txt_republish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_summary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_state);
            this.Controls.Add(this.cbb_producer);
            this.Controls.Add(this.cbb_author);
            this.Controls.Add(this.cbb_category);
            this.Name = "SuaDauSach";
            this.Text = "SuaDauSach";
            this.Load += new System.EventHandler(this.SuaDauSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_sumnumber;
        private System.Windows.Forms.TextBox txt_republish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_summary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_state;
        private System.Windows.Forms.ComboBox cbb_producer;
        private System.Windows.Forms.ComboBox cbb_author;
        private System.Windows.Forms.ComboBox cbb_category;

    }
}