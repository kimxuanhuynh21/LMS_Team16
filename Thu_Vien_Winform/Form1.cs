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

        public void Refresh_DataGridView(List<DauSach> list)
        {
            var bindingList = new BindingList<DauSach>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.DauSach.ToList().Select(i => new DauSach(i)).ToList());
        }

        private void InitializeDataGridView(List<DauSach> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            //dataGridView1.ColumnCount = 9;
            //dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<DauSach>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            //// Set the column header names.
            //dataGridView1.Columns[0].Name = "Tên";
            //dataGridView1.Columns[1].Name = "Thể Loại";
            //dataGridView1.Columns[2].Name = "Tác Giả";
            //dataGridView1.Columns[3].Name = "Tóm Tắt";
            //dataGridView1.Columns[4].Name = "Tái Bản";
            //dataGridView1.Columns[5].Name = "Nhà Sản Xuất";
            //dataGridView1.Columns[6].Name = "Số Lượng Hiện Tại";
            //dataGridView1.Columns[7].Name = "Số Lượng Tổng";
            //dataGridView1.Columns[8].Name = "Tình Trạng";

            //int d = 0;
            //// Populate the rows.
            //foreach (var item in list)
            //{
            //    dataGridView1.Rows[d].Cells[0].Value = item.Ten;
            //    dataGridView1.Rows[d].Cells[1].Value = item.TheLoaiID;
            //    dataGridView1.Rows[d].Cells[2].Value = item.TacGiaID;
            //    dataGridView1.Rows[d].Cells[3].Value = item.TomTat;
            //    dataGridView1.Rows[d].Cells[4].Value = item.TaiBan;
            //    dataGridView1.Rows[d].Cells[5].Value = item.NhaSanXuat;
            //    dataGridView1.Rows[d].Cells[6].Value = item.SoLuongTon;
            //    dataGridView1.Rows[d].Cells[7].Value = item.SoLuongTong;
            //    dataGridView1.Rows[d].Cells[8].Value = item.TinhTrang;
            //    //dataGridView1.Rows.Add(item);
            //    d = d + 1;
            //}
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    //sb.Append("Row: ");
                    //sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    //sb.Append(Environment.NewLine);

                    var index_row = dataGridView1.SelectedRows[i].Index;
                    int dausach_id = Convert.ToInt32(dataGridView1.Rows[index_row].Cells[0].Value);

                    _context.DauSach.RemoveRange(_context.DauSach.Where(o => o.ID == dausach_id));

                }

                _context.SaveChanges();
                MessageBox.Show("Success...!!!");
                //reload
                var list = _context.DauSach.ToList().Select(i => new DauSach(i)).ToList();
                Refresh_DataGridView(list);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var list = _context.DauSach.ToList().Select(i => new DauSach(i)).ToList();
            Refresh_DataGridView(list);
        }



    }
}
