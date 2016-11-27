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

            label_dausach.Text = dausach.Ten;

            //combobox tinh trang
            List<ComboboxItem> list_states = new List<ComboboxItem> { };
            item = new ComboboxItem();
            item.Text = "Sách đã thanh lý";
            item.Value = (byte)ConstantHandler.TinhTrang_CuonSach.SachThanhLy;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Sách đã được mượn";
            item.Value = (byte)ConstantHandler.TinhTrang_CuonSach.SachDaMuon;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Sách còn trong kho";
            item.Value = (byte)ConstantHandler.TinhTrang_CuonSach.SachTrongKho;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Sách đang chờ bảo dưỡng";
            item.Value = (byte)ConstantHandler.TinhTrang_CuonSach.SachBaoDuong;
            list_states.Add(item);

            cbb_state.DataSource = list_states;
            cbb_state.DisplayMember = "Text";
            cbb_state.ValueMember = "Value";
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

        public void Refresh_DataGridView()
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
            try
            {
                var cuonsach_id = label_id.Text;
                if (cuonsach_id != "mới")
                {
                    int id = Convert.ToInt32(cuonsach_id);
                    var cuonsach = _context.CuonSach.Where(i => i.ID.Equals(id)).FirstOrDefault();
                    cuonsach.TinhTrang = Convert.ToByte(cbb_state.SelectedValue);
                }
                else
                {
                    var cuonsach = new CuonSach();
                    cuonsach.MaVach = "MV" + DauSachID + txt_key.Text;
                    cuonsach.DauSachID = DauSachID;
                    cuonsach.TinhTrang = Convert.ToByte(cbb_state.SelectedValue);
                    _context.CuonSach.Add(cuonsach);

                    var dausach = _context.DauSach.Where(i => i.ID.Equals(DauSachID)).FirstOrDefault();
                    dausach.SoLuongTong = dausach.SoLuongTong + 1;

                }
                _context.SaveChanges();

                Refresh_DataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var index_row = dataGridView1.SelectedRows[0].Index;
                CuonSachViewModel cuonsach = (CuonSachViewModel)dataGridView1.Rows[index_row].DataBoundItem;
                if (cuonsach != null)
                {
                    //var obj = dataGridView1.Rows[index_row];
                    label_id.Text = cuonsach.ID.ToString();
                    label_defaultMV.Text = "MV" + DauSachID.ToString();
                    string mavach = cuonsach.MaVach.Substring(2 + DauSachID.ToString().Length, cuonsach.MaVach.Length - (2 + DauSachID.ToString().Length));
                    txt_key.Text = mavach;
                    txt_key.ReadOnly = true;
                    cbb_state.SelectedValue = cuonsach.TinhTrangID;
                }

            }
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
                    int cuonsach_id = Convert.ToInt32(dataGridView1.Rows[index_row].Cells[0].Value);

                    _context.CuonSach.RemoveRange(_context.CuonSach.Where(o => o.ID == cuonsach_id));

                }

                var dausach = _context.DauSach.Where(i => i.ID.Equals(DauSachID)).FirstOrDefault();
                dausach.SoLuongTong = dausach.SoLuongTong - selectedRowCount;

                _context.SaveChanges();
                MessageBox.Show("Success...!!!");
                //reload
                Refresh_DataGridView();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            label_id.Text = "mới";
            txt_key.ReadOnly = false;
            txt_key.Text = null;
            label_defaultMV.Text = "MV" + DauSachID.ToString();
        }
    }
}
