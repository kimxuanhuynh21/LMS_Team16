﻿namespace Thu_Vien_Winform
{
    partial class QuanLyDocGia
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_dateend = new System.Windows.Forms.DateTimePicker();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_daterelease = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numberbooks = new System.Windows.Forms.TextBox();
            this.txt_yeargraduate = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_changeimage = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 458);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.dateTimePicker_dateend);
            this.groupBox1.Controls.Add(this.cbb_category);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_daterelease);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_key);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_numberbooks);
            this.groupBox1.Controls.Add(this.txt_yeargraduate);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_changeimage);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(562, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 463);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dateTimePicker_dateend
            // 
            this.dateTimePicker_dateend.Location = new System.Drawing.Point(25, 202);
            this.dateTimePicker_dateend.Name = "dateTimePicker_dateend";
            this.dateTimePicker_dateend.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker_dateend.TabIndex = 29;
            // 
            // cbb_category
            // 
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(25, 319);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(186, 21);
            this.cbb_category.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số lượng sách được mượn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Loại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày hết hạn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Năm tốt nghiệp :";
            // 
            // label_daterelease
            // 
            this.label_daterelease.AutoSize = true;
            this.label_daterelease.Location = new System.Drawing.Point(248, 377);
            this.label_daterelease.Name = "label_daterelease";
            this.label_daterelease.Size = new System.Drawing.Size(10, 13);
            this.label_daterelease.TabIndex = 21;
            this.label_daterelease.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày cấp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên :";
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(252, 95);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(23, 13);
            this.label_key.TabIndex = 26;
            this.label_key.Text = "DG";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(285, 34);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 13);
            this.label_id.TabIndex = 26;
            this.label_id.Text = "Mới";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã thẻ :";
            // 
            // txt_numberbooks
            // 
            this.txt_numberbooks.Location = new System.Drawing.Point(25, 377);
            this.txt_numberbooks.Name = "txt_numberbooks";
            this.txt_numberbooks.Size = new System.Drawing.Size(186, 20);
            this.txt_numberbooks.TabIndex = 16;
            // 
            // txt_yeargraduate
            // 
            this.txt_yeargraduate.Location = new System.Drawing.Point(25, 264);
            this.txt_yeargraduate.Name = "txt_yeargraduate";
            this.txt_yeargraduate.Size = new System.Drawing.Size(186, 20);
            this.txt_yeargraduate.TabIndex = 13;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(252, 264);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(186, 20);
            this.txt_phone.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(252, 202);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(186, 20);
            this.txt_email.TabIndex = 10;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(252, 149);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(186, 20);
            this.txt_name.TabIndex = 9;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(281, 92);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(66, 20);
            this.txt_key.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(76, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 113);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(258, 424);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_changeimage
            // 
            this.btn_changeimage.Location = new System.Drawing.Point(90, 140);
            this.btn_changeimage.Name = "btn_changeimage";
            this.btn_changeimage.Size = new System.Drawing.Size(75, 23);
            this.btn_changeimage.TabIndex = 5;
            this.btn_changeimage.Text = "Thay đổi";
            this.btn_changeimage.UseVisualStyleBackColor = true;
            this.btn_changeimage.Click += new System.EventHandler(this.btn_changeimage_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 424);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_refresh);
            this.groupBox3.Location = new System.Drawing.Point(562, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 94);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điều khiển";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(291, 40);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(101, 40);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Địa chỉ :";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(251, 319);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(186, 20);
            this.txt_address.TabIndex = 30;
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyDocGia";
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numberbooks;
        private System.Windows.Forms.TextBox txt_yeargraduate;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label_daterelease;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Button btn_changeimage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_address;
    }
}