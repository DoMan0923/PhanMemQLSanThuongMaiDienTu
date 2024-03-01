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
    public partial class frm_Pay : Form
    {
        PaymentMethodDAL payDAL = new PaymentMethodDAL();
        DataTable dtChiTiet = new DataTable();
        string imageName;
        bool flag = true;

        public frm_Pay()
        {
            InitializeComponent();
        }

        #region enable control
        public void enable_Control()
        {
            txt_ID.Enabled = false;
        }
        #endregion

        #region get pay datagridview
        public void get_DataGridviewPay()
        {
            dtChiTiet = get_Pay();
            data_Pay.DataSource = dtChiTiet;
        }
        #endregion

        #region get pay
        public DataTable get_Pay()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên phương thức", typeof(string));
            dt.Columns.Add("Ảnh nền", typeof(string));
            dt.Columns.Add("Mặc định", typeof(bool));
            IMongoQueryable<phuong_thuc_thanh_toan> pays = payDAL.load_Pay();
            foreach (var p in pays)
            {
                dt.Rows.Add(p._id, p.ten_phuong_thuc_thanh_toan, p.anh_nen,
                    p.mac_dinh);
            }
            return dt;
        }
        #endregion

        #region button insert
        private void btn_Them_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_ID.Clear();
            txt_TenPT.Clear();
            p_Anh.Image = null;
        }
        #endregion

        #region browser image
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

        #region Binding
        private void data_Pay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_Pay.CurrentRow.Cells[0].Value.ToString();
            string tenPT = data_Pay.CurrentRow.Cells[1].Value.ToString();
            string tenHinh = data_Pay.CurrentRow.Cells[2].Value.ToString();
            txt_ID.Text = id;
            txt_TenPT.Text = tenPT;
            Display_Image(tenHinh);
        }
        #endregion

        #region display image
        public void Display_Image(string tenHinh)
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

        #region form load

        private void frm_Pay_Load(object sender, EventArgs e)
        {
            get_DataGridviewPay();
            enable_Control();
        }
        #endregion

        #region Binding bool default
        private void data_Pay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Thay yourBoolColumnIndex bằng chỉ số của cột bool trong DataGridView
            {
                DataGridViewCell cell = data_Pay.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        #region button save
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tenPT = "";
            //check rỗng
            if (txt_TenPT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập tên phương thức");
                return;
            }
            bool macDinh;
            if (cbo_MacDinh.SelectedItem.ToString() == "Mặc định")
                macDinh = true;
            else
                macDinh = false;

            if (flag)
            {
                //check trùng tên PT
                foreach (DataGridViewRow r in data_Pay.Rows)
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
                payDAL.insert_Pay(txt_TenPT.Text, imageName, macDinh);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                payDAL.update_Pay(ObjectId.Parse(txt_ID.Text.Trim()), txt_TenPT.Text, imageName, macDinh);
                MessageBox.Show("Cập nhật thành công");
            }
            get_DataGridviewPay();
        }
        #endregion

        #region button update
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flag = false;
            MessageBox.Show("Chọn dòng để sửa");
            return;
        }
        #endregion

        #region button delete
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                payDAL.delete_Pay(ObjectId.Parse(txt_ID.Text), true);
                get_DataGridviewPay();
            }
            else
                return;
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

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
