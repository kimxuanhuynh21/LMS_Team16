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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label tenLabel1;
            this.dauSachBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dauSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dauSachDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomTatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSanXuatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox1 = new System.Windows.Forms.TextBox();
            this.tenTextBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            tenLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingNavigator)).BeginInit();
            this.dauSachBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachDataGridView)).BeginInit();
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
            // dauSachBindingSource
            // 
            this.dauSachBindingSource.DataSource = typeof(EF_Models.Models.DauSach);
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
            this.iDDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn1});
            this.theLoaiDataGridView.DataSource = this.theLoaiBindingSource;
            this.theLoaiDataGridView.Location = new System.Drawing.Point(0, 28);
            this.theLoaiDataGridView.Name = "theLoaiDataGridView";
            this.theLoaiDataGridView.Size = new System.Drawing.Size(408, 143);
            this.theLoaiDataGridView.TabIndex = 2;
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataSource = typeof(EF_Models.Models.TheLoai);
            // 
            // dauSachDataGridView
            // 
            this.dauSachDataGridView.AutoGenerateColumns = false;
            this.dauSachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dauSachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn,
            this.theLoaiIDDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn,
            this.tacGiaIDDataGridViewTextBoxColumn,
            this.tacGiaDataGridViewTextBoxColumn,
            this.tomTatDataGridViewTextBoxColumn,
            this.taiBanDataGridViewTextBoxColumn,
            this.nhaSanXuatIDDataGridViewTextBoxColumn,
            this.nhaSanXuatDataGridViewTextBoxColumn,
            this.soLuongTongDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dauSachDataGridView.DataSource = this.dauSachBindingSource;
            this.dauSachDataGridView.Location = new System.Drawing.Point(0, 177);
            this.dauSachDataGridView.Name = "dauSachDataGridView";
            this.dauSachDataGridView.Size = new System.Drawing.Size(1020, 118);
            this.dauSachDataGridView.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // theLoaiIDDataGridViewTextBoxColumn
            // 
            this.theLoaiIDDataGridViewTextBoxColumn.DataPropertyName = "TheLoaiID";
            this.theLoaiIDDataGridViewTextBoxColumn.HeaderText = "TheLoaiID";
            this.theLoaiIDDataGridViewTextBoxColumn.Name = "theLoaiIDDataGridViewTextBoxColumn";
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            // 
            // tacGiaIDDataGridViewTextBoxColumn
            // 
            this.tacGiaIDDataGridViewTextBoxColumn.DataPropertyName = "TacGiaID";
            this.tacGiaIDDataGridViewTextBoxColumn.HeaderText = "TacGiaID";
            this.tacGiaIDDataGridViewTextBoxColumn.Name = "tacGiaIDDataGridViewTextBoxColumn";
            // 
            // tacGiaDataGridViewTextBoxColumn
            // 
            this.tacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.HeaderText = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.Name = "tacGiaDataGridViewTextBoxColumn";
            // 
            // tomTatDataGridViewTextBoxColumn
            // 
            this.tomTatDataGridViewTextBoxColumn.DataPropertyName = "TomTat";
            this.tomTatDataGridViewTextBoxColumn.HeaderText = "TomTat";
            this.tomTatDataGridViewTextBoxColumn.Name = "tomTatDataGridViewTextBoxColumn";
            // 
            // taiBanDataGridViewTextBoxColumn
            // 
            this.taiBanDataGridViewTextBoxColumn.DataPropertyName = "TaiBan";
            this.taiBanDataGridViewTextBoxColumn.HeaderText = "TaiBan";
            this.taiBanDataGridViewTextBoxColumn.Name = "taiBanDataGridViewTextBoxColumn";
            // 
            // nhaSanXuatIDDataGridViewTextBoxColumn
            // 
            this.nhaSanXuatIDDataGridViewTextBoxColumn.DataPropertyName = "NhaSanXuatID";
            this.nhaSanXuatIDDataGridViewTextBoxColumn.HeaderText = "NhaSanXuatID";
            this.nhaSanXuatIDDataGridViewTextBoxColumn.Name = "nhaSanXuatIDDataGridViewTextBoxColumn";
            // 
            // nhaSanXuatDataGridViewTextBoxColumn
            // 
            this.nhaSanXuatDataGridViewTextBoxColumn.DataPropertyName = "NhaSanXuat";
            this.nhaSanXuatDataGridViewTextBoxColumn.HeaderText = "NhaSanXuat";
            this.nhaSanXuatDataGridViewTextBoxColumn.Name = "nhaSanXuatDataGridViewTextBoxColumn";
            // 
            // soLuongTongDataGridViewTextBoxColumn
            // 
            this.soLuongTongDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTong";
            this.soLuongTongDataGridViewTextBoxColumn.HeaderText = "SoLuongTong";
            this.soLuongTongDataGridViewTextBoxColumn.Name = "soLuongTongDataGridViewTextBoxColumn";
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn1
            // 
            this.tenDataGridViewTextBoxColumn1.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn1.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn1.Name = "tenDataGridViewTextBoxColumn1";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(493, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TacGia.ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(528, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 4;
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(493, 57);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 5;
            tenLabel.Text = "Ten:";
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TacGia.Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(528, 54);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenTextBox.TabIndex = 6;
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(493, 101);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 7;
            iDLabel1.Text = "ID:";
            // 
            // iDTextBox1
            // 
            this.iDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TheLoai.ID", true));
            this.iDTextBox1.Location = new System.Drawing.Point(528, 98);
            this.iDTextBox1.Name = "iDTextBox1";
            this.iDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox1.TabIndex = 8;
            // 
            // tenLabel1
            // 
            tenLabel1.AutoSize = true;
            tenLabel1.Location = new System.Drawing.Point(493, 127);
            tenLabel1.Name = "tenLabel1";
            tenLabel1.Size = new System.Drawing.Size(29, 13);
            tenLabel1.TabIndex = 9;
            tenLabel1.Text = "Ten:";
            // 
            // tenTextBox1
            // 
            this.tenTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dauSachBindingSource, "TheLoai.Ten", true));
            this.tenTextBox1.Location = new System.Drawing.Point(528, 124);
            this.tenTextBox1.Name = "tenTextBox1";
            this.tenTextBox1.Size = new System.Drawing.Size(100, 20);
            this.tenTextBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 601);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDTextBox1);
            this.Controls.Add(tenLabel1);
            this.Controls.Add(this.tenTextBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.dauSachDataGridView);
            this.Controls.Add(this.theLoaiDataGridView);
            this.Controls.Add(this.dauSachBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingNavigator)).EndInit();
            this.dauSachBindingNavigator.ResumeLayout(false);
            this.dauSachBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauSachDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView dauSachDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomTatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox iDTextBox1;
        private System.Windows.Forms.TextBox tenTextBox1;
    }
}

