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
using System.IO;

namespace Thu_Vien_Winform
{
    public partial class QuanLyDocGia : Form
    {
        ThuVienDbContext _context;
        ComboboxItem item;
        OpenFileDialog dlg = new OpenFileDialog();
        public QuanLyDocGia()
        {
            InitializeComponent();
        }

        public void Refresh_DataGridView()
        {
            QuanLyDocGia_Load(null, null);

        }

        private void InitializeDataGridView(List<DocGiaViewModel> list)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            var bindingList = new BindingList<DocGiaViewModel>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            _context = new ThuVienDbContext();
            InitializeDataGridView(_context.DocGia.ToList().Select(i => new DocGiaViewModel(i)).ToList());

            List<ComboboxItem> list_states = new List<ComboboxItem> { };
            //combobox category
            list_states = new List<ComboboxItem> { };
            item = new ComboboxItem();
            item.Text = "Sinh Viên";
            item.Value = (byte)ConstantHandler.Loai_DocGia.SinhVien;
            list_states.Add(item);

            item = new ComboboxItem();
            item.Text = "Giáo Viên";
            item.Value = (byte)ConstantHandler.Loai_DocGia.GiaoVien;
            list_states.Add(item);

            cbb_category.DataSource = list_states;
            cbb_category.DisplayMember = "Text";
            cbb_category.ValueMember = "Value";


            var path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            int d = path.LastIndexOf("\\");
            path = path.Substring(0, d);

            pictureBox.Image = new Bitmap(path + @"\\EF-Models\\Images\\no-image.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                var index_row = dataGridView1.SelectedRows[0].Index;
                DocGiaViewModel docgia = (DocGiaViewModel)dataGridView1.Rows[index_row].DataBoundItem;
                if (docgia != null)
                {
                    string id_mathe = docgia.MaThe.Substring(2, docgia.MaThe.Length - 2);
                    label_id.Text = docgia.ID.ToString();
                    txt_key.Text = id_mathe;
                    txt_name.Text = docgia.Ten;
                    txt_email.Text = docgia.Email;
                    txt_phone.Text = docgia.DienThoai;
                    txt_address.Text = docgia.DiaChi;
                    label_daterelease.Text = docgia.NgayCapThe.ToString();
                    dateTimePicker_dateend.Value = docgia.NgayHetHan;
                    txt_yeargraduate.Text = docgia.NamTotNghiep.ToString();
                    cbb_category.SelectedValue = docgia.LoaiID;
                    txt_numberbooks.Text = docgia.SoSachConLai.ToString();


                    var path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    int d = path.LastIndexOf("\\");
                    path = path.Substring(0, d);

                    pictureBox.Image = new Bitmap(path + docgia.HinhAnh);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_key.Text = "";
            txt_name.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            label_daterelease.Text = "";
            dateTimePicker_dateend.Value = DateTime.Now;
            txt_yeargraduate.Text = "";
            cbb_category.SelectedValue = "";
            txt_numberbooks.Text = "";
            label_id.Text = "Mới";

            var path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            int d = path.LastIndexOf("\\");
            path = path.Substring(0, d);

            pictureBox.Image = new Bitmap(path + @"\\EF-Models\\Images\\no-image.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            dlg = new OpenFileDialog();
            dataGridView1.ClearSelection();
        }

        private void btn_changeimage_Click(object sender, EventArgs e)
        {
            dlg.Title = "Select a Image";
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK) // Test result.
            {
                pictureBox.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //two ways, 1: insert, update
            if (!string.IsNullOrEmpty(dlg.FileName))
            {
                var path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                int d = path.LastIndexOf("\\");
                path = path.Substring(0, d);
                var des = @"\EF-Models\Images\";


                string iName = dlg.SafeFileName;   // <---
                string filepath = dlg.FileName;    // <---
                if (File.Exists(path + des + iName))
                {
                    MessageBox.Show("File da ton tai");
                }
                else
                {
                    try
                    {
                        if (label_id.Text == "Mới")
                        {
                            //get data from input
                            DocGia docgia = new DocGia();
                            docgia.MaThe = "DG" + txt_key.Text;
                            docgia.Ten = txt_name.Text;
                            docgia.Email = txt_email.Text;
                            docgia.DienThoai = txt_phone.Text;
                            docgia.DiaChi = txt_address.Text;
                            docgia.NgayCapThe = DateTime.Now.Date;
                            docgia.NgayHetHan = dateTimePicker_dateend.Value;
                            docgia.NamTotNghiep = Convert.ToInt32(txt_yeargraduate.Text);
                            docgia.Loai = (byte)cbb_category.SelectedValue;
                            docgia.SoSachConLai = Convert.ToInt32(txt_numberbooks.Text);
                            docgia.HinhAnh = des + iName;
                            _context.DocGia.Add(docgia);
                        }
                        else
                        {
                            int docgia_id = Convert.ToInt16(label_id.Text);
                            var docgia = _context.DocGia.Where(i => i.ID.Equals(docgia_id)).FirstOrDefault();
                            docgia.MaThe = "DG" + txt_key.Text;
                            docgia.Ten = txt_name.Text;
                            docgia.Email = txt_email.Text;
                            docgia.DienThoai = txt_phone.Text;
                            docgia.DiaChi = txt_address.Text;
                            docgia.NgayCapThe = DateTime.Now.Date;
                            docgia.NgayHetHan = dateTimePicker_dateend.Value;
                            docgia.NamTotNghiep = Convert.ToInt32(txt_yeargraduate.Text);
                            docgia.Loai = (byte)cbb_category.SelectedValue;
                            docgia.SoSachConLai = Convert.ToInt32(txt_numberbooks.Text);
                            docgia.HinhAnh = des + iName;
                        }
                        _context.SaveChanges();

                        File.Copy(filepath, path + des + iName); // <---
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            // 1 way: update
            else
            {
                if (label_id.Text != "Mới")
                {
                    try
                    {
                        int docgia_id = Convert.ToInt16(label_id.Text);
                        var docgia = _context.DocGia.Where(i => i.ID.Equals(docgia_id)).FirstOrDefault();
                        docgia.MaThe = "DG" + txt_key.Text;
                        docgia.Ten = txt_name.Text;
                        docgia.Email = txt_email.Text;
                        docgia.DienThoai = txt_phone.Text;
                        docgia.DiaChi = txt_address.Text;
                        docgia.NgayCapThe = DateTime.Now.Date;
                        docgia.NgayHetHan = dateTimePicker_dateend.Value;
                        docgia.NamTotNghiep = Convert.ToInt32(txt_yeargraduate.Text);
                        docgia.Loai = (byte)cbb_category.SelectedValue;
                        docgia.SoSachConLai = Convert.ToInt32(txt_numberbooks.Text);

                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Chon hinh anh cho Doc Gia");
                }
            }
            Refresh_DataGridView();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh_DataGridView();
        }
    }
}
