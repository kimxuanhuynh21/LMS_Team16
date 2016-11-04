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
using EF_Models.Handlers;
using System.Data.Entity;


namespace Thu_Vien_Winform
{
    public partial class QuanLySach : Form
    {
        ThuVienDbContext _context;
        ComboboxItem item;
        private int DauSachID;
        public QuanLySach(int dausach_id, DauSach dausach)
        {
            InitializeComponent();
            DauSachID = dausach_id;
            label_name.Text = dausach.Ten;
            label_category.Text = dausach.TheLoai.Ten;
            label_author.Text = dausach.TacGia.Ten;
            label_producer.Text = dausach.NhaSanXuat.Ten;
            label_republish.Text = dausach.TaiBan.ToString();
            label_sumnumber.Text = dausach.SoLuongTong.ToString();
            label_numberexist.Text = dausach.SoLuongTon.ToString();
            label_state.Text = dausach.TinhTrang.ToString();
        }

        private void InitializeDataGridView(List<CuonSach> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<CuonSach>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        public void Refresh_DataGridView(List<CuonSach> list)
        {
            var bindingList = new BindingList<CuonSach>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: Complete member initialization
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.CuonSach.Where(i => i.DauSachID.Equals(DauSachID)).ToList().Select(i => new CuonSach(i)).ToList());
        }

        
    }
}
