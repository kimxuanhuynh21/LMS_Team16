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
using EF_Models.Models;
using EF_Models.ViewModels;

namespace Thu_Vien_Winform
{
    public partial class ThongkeDauSach : Form
    {
        ThuVienDbContext _context;
        public ThongkeDauSach()
        {
            InitializeComponent();
        }

        private void ThongkeDauSach_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.ThongKeDauSach.ToList().Select(i => new ThongKeDauSachViewModel(i)).ToList());

            

            var list_books = _context.DauSach.ToList().Select(i => new DauSachViewModel() { ID = i.ID, Ten = i.Ten }).ToList();
            
            //important
            cbb_dausachs.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_dausachs.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_dausachs.DataSource = list_books;
            cbb_dausachs.DisplayMember = "Ten";
            cbb_dausachs.ValueMember = "ID";
        }

        private void InitializeDataGridView(List<ThongKeDauSachViewModel> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<ThongKeDauSachViewModel>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[9].Visible = false;


        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date <= DateTime.Now)
            {
                string temp_dausach_id = cbb_dausachs.SelectedValue.ToString();

                if (temp_dausach_id != null)
                {
                    int dausach_id = Convert.ToInt32(temp_dausach_id);

                    var data = _context.ThongKeDauSach.Where(i => i.Ngay <= dateTimePicker1.Value.Date && i.DauSachID == dausach_id)
                        .OrderByDescending(i => i.Ngay).ToList()
                        .Select(i => new ThongKeDauSachViewModel(i)).FirstOrDefault();

                    List<ThongKeDauSachViewModel> list = new List<ThongKeDauSachViewModel>();

                    if (data != null)
                    {
                        ThongKeDauSachViewModel model = new ThongKeDauSachViewModel();

                        model.ID = data.ID;
                        model.DauSachID = data.DauSachID;
                        model.DauSach = data.DauSach;
                        model.Ngay = dateTimePicker1.Value.Date;
                        model.SoLuongHienTai = data.SoLuongHienTai;
                        model.SoLuongDaMuon = data.SoLuongDaMuon;
                        list.Add(model);
                        
                    }


                    InitializeDataGridView(list);

                }
                //MessageBox.Show("Your've selected the meeting date: " + Arr_fromdate[0]);

                //MessageBox.Show("Your've selected the meeting date: " + Arr_todate[0]);
            }
        }
    }
}
