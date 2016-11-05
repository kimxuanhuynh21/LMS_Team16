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
using EF_Models.ViewModels;
using EF_Models.Handlers;
using System.Data.Entity;


namespace Thu_Vien_Winform
{
    public partial class QuanLySach : Form
    {
        ThuVienDbContext _context;
        ComboboxItem item;
        private int DauSachID;
        public QuanLySach(DauSachViewModel dausach)
        {
            _context = new ThuVienDbContext();

            InitializeComponent();
            DauSachID = dausach.ID;
            label_name.Text = dausach.Ten;
            label_category.Text = dausach.TheLoai;
            label_author.Text = dausach.TacGia;
            label_producer.Text = dausach.NhaSanXuat;
            label_republish.Text = dausach.TaiBan.ToString();
            label_sumnumber.Text = dausach.SoLuongTong.ToString();
            label_numberexist.Text = dausach.SoLuongTon.ToString();
            label_state.Text = dausach.TinhTrang.ToString();

            var list_books = _context.DauSach.ToList().Select(i => new DauSachViewModel() { ID = i.ID, Ten = i.Ten }).ToList();
            cbb_books.DataSource = list_books;
            cbb_books.DisplayMember = "Ten";
            cbb_books.ValueMember = "ID";
        }

        private void InitializeDataGridView(List<CuonSachViewModel> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<CuonSachViewModel>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        public void Refresh_DataGridView(List<CuonSachViewModel> list)
        {
            QuanLySach_Load(null, null);
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: Complete member initialization
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.CuonSach.Where(i => i.DauSachID.Equals(DauSachID)).ToList().Select(i => new CuonSachViewModel(i)).ToList());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var index_row = dataGridView1.SelectedRows[0].Index;
                CuonSachViewModel cuonsach = (CuonSachViewModel)dataGridView1.Rows[index_row].DataBoundItem;
                //var obj = dataGridView1.Rows[index_row];
                txt_key.Text = cuonsach.MaVach;
                cbb_books.SelectedValue = cuonsach.DauSachID;
                
            }
        }
        
    }
}
