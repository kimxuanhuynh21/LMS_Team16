using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thu_Vien_Winform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_docgia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia ql = new QuanLyDocGia();
            ql.Show();
        }

        private void btn_dausach_Click(object sender, EventArgs e)
        {
            QuanLyDauSach ql = new QuanLyDauSach();
            ql.Show();
        }
    }
}
