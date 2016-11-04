using EF_Models.Models;
using EF_Models.Handlers;
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
    public partial class ThemDauSach : Form
    {
        ThuVienDbContext _context;
        public ThemDauSach()
        {
            InitializeComponent();
        }

        private void ThemDauSach_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();

            var list_category = _context.TheLoai.ToList().Select(i => new TheLoai(i)).ToList();
            cbb_category.DataSource = list_category;
            cbb_category.DisplayMember = "Ten";
            cbb_category.ValueMember = "ID";


            var list_author = _context.TacGia.ToList().Select(i => new TacGia(i)).ToList();
            cbb_author.DataSource = list_author;
            cbb_author.DisplayMember = "Ten";
            cbb_author.ValueMember = "ID";

            var list_producer = _context.NhaSanXuat.ToList().Select(i => new NhaSanXuat(i)).ToList();
            cbb_producer.DataSource = list_producer;
            cbb_producer.DisplayMember = "Ten";
            cbb_producer.ValueMember = "ID";


            cbb_state.DisplayMember = "Text";
            cbb_state.ValueMember = "Value";
            cbb_state.Items.Add(new { Text = "Đăng kí Photo", Value = ConstantHandler.TinhTrang_DauSach.DangKiPhoto });
            cbb_state.Items.Add(new { Text = "Đọc tại chổ", Value = ConstantHandler.TinhTrang_DauSach.DocTaiCho });
            cbb_state.Items.Add(new { Text = "Mượn về nhà", Value = ConstantHandler.TinhTrang_DauSach.MuonVeNha });
            cbb_state.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
