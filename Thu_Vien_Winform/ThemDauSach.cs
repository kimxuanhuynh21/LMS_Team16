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
        QuanLyDauSach form_qlds;
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

            //must to fix
            cbb_state.DisplayMember = "Text";
            cbb_state.ValueMember = "Value";
            cbb_state.Items.Add(new { Text = "Đăng kí Photo", Value = ConstantHandler.TinhTrang_DauSach.DangKiPhoto });
            cbb_state.Items.Add(new { Text = "Đọc tại chổ", Value = ConstantHandler.TinhTrang_DauSach.DocTaiCho });
            cbb_state.Items.Add(new { Text = "Mượn về nhà", Value = ConstantHandler.TinhTrang_DauSach.MuonVeNha });
            cbb_state.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var dausach = new DauSach();
                dausach.Ten = txt_name.Text;
                dausach.TheLoaiID = Convert.ToInt32(cbb_category.SelectedValue);
                dausach.TacGiaID = Convert.ToInt32(cbb_author.SelectedValue);
                dausach.TomTat = txt_summary.Text;
                dausach.TaiBan = Convert.ToInt32(txt_republish.Text);
                dausach.NhaSanXuatID = Convert.ToInt32(cbb_producer.SelectedValue);
                dausach.SoLuongTong = Convert.ToInt32(txt_sumnumber.Text);
                dausach.TinhTrang = Convert.ToByte(cbb_state.SelectedValue);

                _context.DauSach.Add(dausach);
                _context.SaveChanges();

                

                for (int i = 1; i <= Convert.ToInt32(txt_sumnumber.Text); i++)
                {
                    var cuonsach = new CuonSach();
                    cuonsach.MaVach = "MV" + dausach.ID + i;
                    cuonsach.DauSachID = dausach.ID;
                    cuonsach.TinhTrang = 2;
                    _context.CuonSach.Add(cuonsach);
                    
                }

                var phieunhap = new PhieuNhapDauSach();
                phieunhap.DauSachID = dausach.ID;
                phieunhap.NgayNhap = DateTime.Now;
                phieunhap.SoLuongCuonSach = dausach.SoLuongTong;

                _context.PhieuNhapDauSach.Add(phieunhap);

                _context.SaveChanges();


                txt_name.Text = null;
                txt_republish.Text = null;
                txt_summary.Text = null;
                txt_sumnumber.Text = null;
                form_qlds = new QuanLyDauSach();
                form_qlds.Refresh();
                form_qlds.Refresh_DataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
