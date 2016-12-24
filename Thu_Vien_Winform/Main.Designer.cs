namespace Thu_Vien_Winform
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
            this.btn_docgia = new System.Windows.Forms.Button();
            this.btn_dausach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_docgia
            // 
            this.btn_docgia.Location = new System.Drawing.Point(115, 42);
            this.btn_docgia.Name = "btn_docgia";
            this.btn_docgia.Size = new System.Drawing.Size(106, 39);
            this.btn_docgia.TabIndex = 0;
            this.btn_docgia.Text = "Quản lý Độc Giả";
            this.btn_docgia.UseVisualStyleBackColor = true;
            this.btn_docgia.Click += new System.EventHandler(this.btn_docgia_Click);
            // 
            // btn_dausach
            // 
            this.btn_dausach.Location = new System.Drawing.Point(115, 115);
            this.btn_dausach.Name = "btn_dausach";
            this.btn_dausach.Size = new System.Drawing.Size(106, 38);
            this.btn_dausach.TabIndex = 0;
            this.btn_dausach.Text = "Quản lý Đầu Sách";
            this.btn_dausach.UseVisualStyleBackColor = true;
            this.btn_dausach.Click += new System.EventHandler(this.btn_dausach_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 224);
            this.Controls.Add(this.btn_dausach);
            this.Controls.Add(this.btn_docgia);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_docgia;
        private System.Windows.Forms.Button btn_dausach;
    }
}