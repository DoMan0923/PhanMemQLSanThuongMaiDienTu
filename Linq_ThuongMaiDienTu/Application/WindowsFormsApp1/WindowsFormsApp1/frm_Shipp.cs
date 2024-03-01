using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frm_Shipp : Form
    {
        ShippingMethodDAL shipDAL = new ShippingMethodDAL();
        DataTable dtChiTiet = new DataTable();
        bool flag = true;
        string dongKiem = "";
        string imageName;
        public frm_Shipp()
        {
            InitializeComponent();
        }

        private void frm_Shipp_Load(object sender, EventArgs e)
        {
            get_GridviewShipp();
        }

        #region get shipp datagridview
        public void get_GridviewShipp()
        {
            dtChiTiet = get_Shipp();
            data_Shipp.DataSource = dtChiTiet;
            data_Binding();
        }
        #endregion

        #region get shipp
        public DataTable get_Shipp()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên phương thức", typeof(string));
            dt.Columns.Add("Thời gian", typeof(int));
            dt.Columns.Add("Chi phí", typeof(double));
            dt.Columns.Add("Mặc định", typeof(bool));
            dt.Columns.Add("Đồng kiểm", typeof(bool));
            dt.Columns.Add("Ảnh", typeof(string));
            IMongoQueryable<phuong_thuc_van_chuyen> shipps = shipDAL.load_Shipp();
            foreach (var s in shipps)
            {
                dt.Rows.Add(s._id, s.ten_phuong_thuc_van_chuyen, s.thoi_gian_uoc_tinh,
                    s.chi_phi, s.mac_dinh, s.dong_kiem, s.anh_nen);
            }
            return dt;
        }
        #endregion

        #region Binding
        public void data_Binding()
        {
            txt_ID.DataBindings.Clear();
            Binding bd = new Binding("Text", dtChiTiet, "ID", true, DataSourceUpdateMode.Never);
            txt_ID.DataBindings.Add(bd);

            txt_TenPT.DataBindings.Clear();
            Binding bd1 = new Binding("Text", dtChiTiet, "Tên phương thức", true, DataSourceUpdateMode.Never);
            txt_TenPT.DataBindings.Add(bd1);

            txt_TG.DataBindings.Clear();
            Binding bd2 = new Binding("Text", dtChiTiet, "Thời gian", true, DataSourceUpdateMode.Never);
            txt_TG.DataBindings.Add(bd2);

            txt_ChiPhi.DataBindings.Clear();
            Binding bd3 = new Binding("Text", dtChiTiet, "Chi phí", true, DataSourceUpdateMode.Never);
            txt_ChiPhi.DataBindings.Add(bd3);
        }
        #endregion

        #region button insert
        private void btn_Them_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_ID.Clear();
            txt_TenPT.Clear();
            txt_TG.Clear();
            txt_ChiPhi.Clear();
        }
        #endregion

        #region button save
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tenPT = "";

            //Combobox đồng kiểm => true/false
            bool dongKiem;
            bool macDinh;
            if (cbo_DongKiem.SelectedItem.ToString() == "Được đồng kiểm")
                dongKiem = true;
            else
                dongKiem = false;

            if (cbo_MacDinh.SelectedItem.ToString() == "Mặc định")
                macDinh = true;
            else
                macDinh = false;
            //Check chưa nhập
            if (txt_TenPT.Text == "" || txt_TG.Text == "" || txt_ChiPhi.Text == "")

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(!txt_ChiPhi.Text.All(char.IsDigit))
            {
                MessageBox.Show("Chi phí phải thuộc dữ liệu kiểu số nguyên");
                return;
            }    
            //Thêm
            if (flag)
            {
                //check trùng tên PT
                foreach (DataGridViewRow r in data_Shipp.Rows)
                {
                    if (r.Cells["Tên phương thức"].Value != null)
                    {
                        tenPT = r.Cells["Tên phương thức"].Value.ToString();
                    }
                    if (tenPT == txt_TenPT.Text)
                    {
                        MessageBox.Show("Tên phương thức đã tồn tại");
                        return;
                    }
                }
                shipDAL.insert_Shipp(txt_TenPT.Text, int.Parse(txt_TG.Text),
                    int.Parse(txt_ChiPhi.Text), macDinh,
                    dongKiem, imageName);
                MessageBox.Show("Thêm thành công");
            }
            if (!flag)
            {

                shipDAL.update_Ship(ObjectId.Parse(txt_ID.Text), txt_TenPT.Text,
                int.Parse(txt_TG.Text), dongKiem, int.Parse(txt_ChiPhi.Text),
                macDinh, imageName);
                MessageBox.Show("Cập nhật thành công");
                //shipDAL.update_Ship(ObjectId.Parse(txt_ID.Text), txt_TenPT.Text,
                //int.Parse(txt_TG.Text), bool.Parse(txt_DongKiem.Text));
            }
            get_GridviewShipp();
        }
        #endregion

        #region button update
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flag = false;
            MessageBox.Show("Vui lòng chọn dòng để sửa");
        }

        private void data_Shipp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Thay yourBoolColumnIndex bằng chỉ số của cột bool trong DataGridView
            {
                DataGridViewCell cell = data_Shipp.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is bool)
                {
                    bool value = (bool)cell.Value;
                    if (value)
                    {
                        cbo_DongKiem.Text = "Được đồng kiểm";
                    }
                    else
                    {
                        cbo_DongKiem.Text = "Không đồng kiểm";
                    }
                }
            }
            else
            {
                DataGridViewCell cell = data_Shipp.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is bool)
                {
                    bool value = (bool)cell.Value;
                    if (value)
                    {
                        cbo_MacDinh.Text = "Mặc định";
                    }
                    else
                    {
                        cbo_MacDinh.Text = "Không";
                    }
                }
            }
        }
        #endregion

        #region button delete
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                shipDAL.delete_Ship(ObjectId.Parse(txt_ID.Text.Trim()), true);
                get_GridviewShipp();
            }
            else
                return;
        }
        #endregion

        #region button select image
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                imageName = openFileDialog1.SafeFileName;
                p_Anh.ImageLocation = imagePath;
            }
        }
        #endregion

        #region binding
        private void data_Shipp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_Shipp.CurrentRow.Cells[0].Value.ToString();
            string ten = data_Shipp.CurrentRow.Cells[1].Value.ToString();
            string thoiGian = data_Shipp.CurrentRow.Cells[2].Value.ToString();
            string chiPhi = data_Shipp.CurrentRow.Cells[3].Value.ToString();
            string tenHinh = data_Shipp.CurrentRow.Cells[6].Value.ToString();
            txt_ID.Text = id;
            txt_TenPT.Text = ten;
            txt_TG.Text = thoiGian;
            txt_ChiPhi.Text = chiPhi;
            display_Image(tenHinh);
        }
        #endregion

        #region display image
        public void display_Image(string tenHinh)
        {
            string path = @"D:\BAITIEULUAN\UD_PMTM\Linq_ThuongMaiDienTu\App_ThuongMaiDienTu\App_ThuongMaiDienTu\Images";
            string duongDanHinhAnh = Path.Combine(path, tenHinh);
            if (File.Exists(duongDanHinhAnh))
            {
                p_Anh.ImageLocation = duongDanHinhAnh;
            }
            else
            {
                p_Anh.Image = null;
            }
        }
        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}






