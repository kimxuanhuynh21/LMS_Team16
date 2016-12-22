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
using System.Data.Entity;

namespace Thu_Vien_Winform
{
    public partial class QuanLyDauSach : Form
    {
        ThuVienDbContext _context;
        ComboboxItem item;
        public QuanLyDauSach()
        {
            InitializeComponent();
        }

        public void Refresh_DataGridView()
        {
            Form1_Load(null, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.DauSach.ToList().Where(i=>i.TT_Xoa.Equals(0)).Select(i => new DauSachViewModel(i)).ToList());

            List<ComboboxItem> list_cbb = new List<ComboboxItem> { };
            list_cbb = new List<ComboboxItem> { };
            for (int i = 1; i < dataGridView1.ColumnCount; i++)
            {
                item = new ComboboxItem();
                item.Text = dataGridView1.Columns[i].DataPropertyName;
                item.Value = (byte)i;
                list_cbb.Add(item);
            }

            cbb_column.DataSource = list_cbb;
            cbb_column.DisplayMember = "Text";
            cbb_column.ValueMember = "Value";

        }

        private void InitializeDataGridView(List<DauSachViewModel> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<DauSachViewModel>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    //sb.Append("Row: ");
                    //sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    //sb.Append(Environment.NewLine);

                    var index_row = dataGridView1.SelectedRows[i].Index;
                    int dausach_id = Convert.ToInt32(dataGridView1.Rows[index_row].Cells[0].Value);

                    var dausach = _context.DauSach.Where(o => o.ID.Equals(dausach_id)).FirstOrDefault();
                    dausach.TT_Xoa = 1;

                }

                _context.SaveChanges();
                MessageBox.Show("Success...!!!");
                //reload
                Refresh_DataGridView();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemDauSach formadd = new ThemDauSach();
            formadd.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var index_row = dataGridView1.SelectedRows[0].Index;
                DauSachViewModel dausach = (DauSachViewModel)dataGridView1.Rows[index_row].DataBoundItem;
                //var obj = dataGridView1.Rows[index_row];
                SuaDauSach formupdate = new SuaDauSach(dausach);
                formupdate.Show();
            }
        }

        private void btn_showbooks_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var index_row = dataGridView1.SelectedRows[0].Index;
                int dausach_id = Convert.ToInt32(dataGridView1.Rows[index_row].Cells[0].Value);
                DauSachViewModel dausach = (DauSachViewModel)dataGridView1.Rows[index_row].DataBoundItem;
                //var obj = dataGridView1.Rows[index_row];
                QuanLySach quanlysach = new QuanLySach(dausach);
                quanlysach.Show();
            }
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            ThongkeDauSach thongkedausach = new ThongkeDauSach();
            thongkedausach.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string number_column = cbb_column.SelectedValue.ToString();
            var fromsearch = txt_from.Text;
            var tosearch = txt_to.Text;

            if (number_column == "1")
            {
                if (fromsearch != null)
                {
                    var list = _context.DauSach.Where(i => i.Ten.Contains(fromsearch)).ToList().Select(i => new DauSachViewModel(i)).ToList();
                    var bindingList = new BindingList<DauSachViewModel>(list);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Columns[0].Visible = false;
                }
            }
            if (number_column == "2")
            {
                if (fromsearch != null && tosearch != null)
                {
                    int from = Convert.ToInt32(fromsearch);
                    int to = Convert.ToInt32(tosearch);

                    var list = _context.DauSach.Where(i => i.TheLoaiID >= from && i.TheLoaiID >= to).ToList().Select(i => new DauSachViewModel(i)).ToList();
                    var bindingList = new BindingList<DauSachViewModel>(list);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Columns[0].Visible = false;
                }
                if (fromsearch != null)
                {
                    int from = Convert.ToInt32(fromsearch);

                    var list = _context.DauSach.Where(i => i.TheLoaiID >= from).ToList().Select(i => new DauSachViewModel(i)).ToList();
                    var bindingList = new BindingList<DauSachViewModel>(list);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Columns[0].Visible = false;
                }
                if (tosearch != null)
                {
                    int to = Convert.ToInt32(tosearch);

                    var list = _context.DauSach.Where(i => i.TheLoaiID >= to).ToList().Select(i => new DauSachViewModel(i)).ToList();
                    var bindingList = new BindingList<DauSachViewModel>(list);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Columns[0].Visible = false;
                }
            }
        }
    }
}
