using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Models.Models;
using System.Data.Entity;

namespace Thu_Vien_Winform
{
    public partial class Form1 : Form
    {
        ThuVienDbContext _context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();
            _context.TheLoai.Load();
            _context.DauSach.Load();
            this.theLoaiBindingSource.DataSource = this._context.TheLoai.Local.ToBindingList();
            this.dauSachBindingSource.DataSource = this._context.DauSach.Local.ToBindingList();
        }

        private void dauSachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            this.theLoaiDataGridView.Refresh();
            this.dauSachDataGridView.Refresh();
        }
    }
}
