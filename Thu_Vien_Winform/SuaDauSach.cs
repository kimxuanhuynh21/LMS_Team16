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
using System.Data.Entity;


namespace Thu_Vien_Winform
{
    public partial class SuaDauSach : Form
    {
        ThuVienDbContext _context;
        ComboboxItem item;
        public SuaDauSach(DauSach dausach)
        {
            InitializeComponent();
            _context = new ThuVienDbContext();

            // TODO: Complete member initialization
            //textbox
            txt_name.Text = dausach.Ten;
            txt_republish.Text = dausach.TaiBan.ToString();
            txt_summary.Text = dausach.TomTat;
            txt_sumnumber.Text = dausach.SoLuongTong.ToString();


            //combobox
            var list_category = _context.TheLoai.ToList().Select(i => new TheLoai(i)).ToList();
            cbb_category.DataSource = list_category;
            cbb_category.DisplayMember = "Ten";
            cbb_category.ValueMember = "ID";
            cbb_category.SelectedValue = dausach.TheLoaiID;


            var list_author = _context.TacGia.ToList().Select(i => new TacGia(i)).ToList();
            cbb_author.DataSource = list_author;
            cbb_author.DisplayMember = "Ten";
            cbb_author.ValueMember = "ID";
            cbb_author.SelectedValue = dausach.TacGiaID;

            var list_producer = _context.NhaSanXuat.ToList().Select(i => new NhaSanXuat(i)).ToList();
            cbb_producer.DataSource = list_producer;
            cbb_producer.DisplayMember = "Ten";
            cbb_producer.ValueMember = "ID";
            cbb_producer.SelectedValue = dausach.NhaSanXuatID;

            //combobox tinh trang
            List<ComboboxItem> list_states = new List<ComboboxItem> { };
            item = new ComboboxItem();
            item.Text = "Đăng kí Photo";
            item.Value = (byte)ConstantHandler.TinhTrang_DauSach.DangKiPhoto;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Đọc tại chổ";
            item.Value = (byte)ConstantHandler.TinhTrang_DauSach.DocTaiCho;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Mượn về nhà";
            item.Value = (byte)ConstantHandler.TinhTrang_DauSach.MuonVeNha;
            list_states.Add(item);

            cbb_state.DataSource = list_states;
            cbb_state.DisplayMember = "Text";
            cbb_state.ValueMember = "Value";
            cbb_state.SelectedValue = dausach.TinhTrang;

        }


        private void SuaDauSach_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
