using EF_Models.Models;
using EF_Models.ViewModels;
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
        int id = -1;
        QuanLyDauSach form_qlds;
        public SuaDauSach(DauSachViewModel dausach)
        {
            InitializeComponent();
            _context = new ThuVienDbContext();

            // TODO: Complete member initialization
            //textbox
            id = dausach.ID;
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
            cbb_state.SelectedValue = dausach.TinhTrangID;

        }


        private void SuaDauSach_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != -1)
                {
                    var dausach = _context.DauSach.Where(i => i.ID.Equals(id)).FirstOrDefault();
                    dausach.Ten = txt_name.Text;
                    dausach.TheLoaiID = Convert.ToInt32(cbb_category.SelectedValue);
                    dausach.TacGiaID = Convert.ToInt32(cbb_author.SelectedValue);
                    dausach.TomTat = txt_summary.Text;
                    dausach.TaiBan = Convert.ToInt32(txt_republish.Text);
                    dausach.NhaSanXuatID = Convert.ToInt32(cbb_producer.SelectedValue);
                    dausach.SoLuongTong = Convert.ToInt32(txt_sumnumber.Text);
                    dausach.TinhTrang = Convert.ToByte(cbb_state.SelectedValue);

                    _context.SaveChanges();

                    
                    this.Close();
                    form_qlds = new QuanLyDauSach();
                    form_qlds.Refresh();
                    form_qlds.Refresh_DataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
