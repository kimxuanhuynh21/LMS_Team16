namespace Thu_Vien_Winform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ten_the_loaiLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label ten_tac_giaLabel;
            this.dauSachBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dauSachBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.theLoaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dauSachDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ten_the_loaiTextBox = new System.Windows.Forms.TextBox();
            this.dauSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentheloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.ten_tac_giaTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            ten_the_loaiLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            ten_tac_giaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingNavigator)).BeginInit();
            this.dauSachBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dauSachBindingNavigator
            // 
            this.dauSachBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dauSachBindingNavigator.BindingSource = this.dauSachBindingSource;
            this.dauSachBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dauSachBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dauSachBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dauSachBindingNavigatorSaveItem});
            this.dauSachBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dauSachBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dauSachBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dauSachBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dauSachBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dauSachBindingNavigator.Name = "dauSachBindingNavigator";
            this.dauSachBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dauSachBindingNavigator.Size = new System.Drawing.Size(1040, 25);
            this.dauSachBindingNavigator.TabIndex = 0;
            this.dauSachBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dauSachBindingNavigatorSaveItem
            // 
            this.dauSachBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dauSachBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dauSachBindingNavigatorSaveItem.Image")));
            this.dauSachBindingNavigatorSaveItem.Name = "dauSachBindingNavigatorSaveItem";
            this.dauSachBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dauSachBindingNavigatorSaveItem.Text = "Save Data";
            this.dauSachBindingNavigatorSaveItem.Click += new System.EventHandler(this.dauSachBindingNavigatorSaveItem_Click);
            // 
            // theLoaiDataGridView
            // 
            this.theLoaiDataGridView.AutoGenerateColumns = false;
            this.theLoaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theLoaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tentheloaiDataGridViewTextBoxColumn});
            this.theLoaiDataGridView.DataSource = this.theLoaiBindingSource;
            this.theLoaiDataGridView.Location = new System.Drawing.Point(0, 28);
            this.theLoaiDataGridView.Name = "theLoaiDataGridView";
            this.theLoaiDataGridView.Size = new System.Drawing.Size(408, 143);
            this.theLoaiDataGridView.TabIndex = 2;
            // 
            // dauSachDataGridView
            // 
            this.dauSachDataGridView.AutoGenerateColumns = false;
            this.dauSachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dauSachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dauSachDataGridView.DataSource = this.dauSachBindingSource;
            this.dauSachDataGridView.Location = new System.Drawing.Point(0, 177);
            this.dauSachDataGridView.Name = "dauSachDataGridView";
            this.dauSachDataGridView.Size = new System.Drawing.Size(1020, 118);
            this.dauSachDataGridView.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(538, 51);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TheLoai.id", true));
            this.idTextBox.Location = new System.Drawing.Point(606, 48);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(353, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // ten_the_loaiLabel
            // 
            ten_the_loaiLabel.AutoSize = true;
            ten_the_loaiLabel.Location = new System.Drawing.Point(538, 77);
            ten_the_loaiLabel.Name = "ten_the_loaiLabel";
            ten_the_loaiLabel.Size = new System.Drawing.Size(62, 13);
            ten_the_loaiLabel.TabIndex = 5;
            ten_the_loaiLabel.Text = "ten the loai:";
            // 
            // ten_the_loaiTextBox
            // 
            this.ten_the_loaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TheLoai.ten_the_loai", true));
            this.ten_the_loaiTextBox.Location = new System.Drawing.Point(606, 74);
            this.ten_the_loaiTextBox.Name = "ten_the_loaiTextBox";
            this.ten_the_loaiTextBox.Size = new System.Drawing.Size(353, 20);
            this.ten_the_loaiTextBox.TabIndex = 6;
            // 
            // dauSachBindingSource
            // 
            this.dauSachBindingSource.DataSource = typeof(EF_Models.Models.DauSach);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ten_dau_sach";
            this.dataGridViewTextBoxColumn6.HeaderText = "ten_dau_sach";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TheLoaiId";
            this.dataGridViewTextBoxColumn7.HeaderText = "TheLoaiId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TacGiaId";
            this.dataGridViewTextBoxColumn9.HeaderText = "TacGiaId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "tom_tat";
            this.dataGridViewTextBoxColumn11.HeaderText = "tom_tat";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "tai_ban";
            this.dataGridViewTextBoxColumn12.HeaderText = "tai_ban";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "id_nha_san_xuat";
            this.dataGridViewTextBoxColumn13.HeaderText = "id_nha_san_xuat";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "so_luong_tong";
            this.dataGridViewTextBoxColumn14.HeaderText = "so_luong_tong";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "so_luong_ton";
            this.dataGridViewTextBoxColumn15.HeaderText = "so_luong_ton";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "trang_thai";
            this.dataGridViewTextBoxColumn16.HeaderText = "trang_thai";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tentheloaiDataGridViewTextBoxColumn
            // 
            this.tentheloaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tentheloaiDataGridViewTextBoxColumn.DataPropertyName = "ten_the_loai";
            this.tentheloaiDataGridViewTextBoxColumn.HeaderText = "ten_the_loai";
            this.tentheloaiDataGridViewTextBoxColumn.Name = "tentheloaiDataGridViewTextBoxColumn";
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataSource = typeof(EF_Models.Models.TheLoai);
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(540, 116);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(18, 13);
            idLabel1.TabIndex = 7;
            idLabel1.Text = "id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TacGia.id", true));
            this.idTextBox1.Location = new System.Drawing.Point(606, 113);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(353, 20);
            this.idTextBox1.TabIndex = 8;
            // 
            // ten_tac_giaLabel
            // 
            ten_tac_giaLabel.AutoSize = true;
            ten_tac_giaLabel.Location = new System.Drawing.Point(540, 142);
            ten_tac_giaLabel.Name = "ten_tac_giaLabel";
            ten_tac_giaLabel.Size = new System.Drawing.Size(60, 13);
            ten_tac_giaLabel.TabIndex = 9;
            ten_tac_giaLabel.Text = "ten tac gia:";
            // 
            // ten_tac_giaTextBox
            // 
            this.ten_tac_giaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TacGia.ten_tac_gia", true));
            this.ten_tac_giaTextBox.Location = new System.Drawing.Point(606, 139);
            this.ten_tac_giaTextBox.Name = "ten_tac_giaTextBox";
            this.ten_tac_giaTextBox.Size = new System.Drawing.Size(353, 20);
            this.ten_tac_giaTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 601);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(ten_tac_giaLabel);
            this.Controls.Add(this.ten_tac_giaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ten_the_loaiLabel);
            this.Controls.Add(this.ten_the_loaiTextBox);
            this.Controls.Add(this.dauSachDataGridView);
            this.Controls.Add(this.theLoaiDataGridView);
            this.Controls.Add(this.dauSachBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingNavigator)).EndInit();
            this.dauSachBindingNavigator.ResumeLayout(false);
            this.dauSachBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dauSachBindingSource;
        private System.Windows.Forms.BindingNavigator dauSachBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dauSachBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private System.Windows.Forms.DataGridView theLoaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dauSachDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ten_the_loaiTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentheloaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox ten_tac_giaTextBox;
    }
}

