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
namespace WindowsFormsApp1
{
    public partial class frm_Store : Form
    {
        StoreDAL storeDAL = new StoreDAL();
        DataTable dtChiTiet = new DataTable();
        public frm_Store()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            get_DataGridviewStore();
            //enable_Control();
        }

        #region get store datagridview
        public void get_DataGridviewStore()
        {
            dtChiTiet = get_Store();
            data_Store.DataSource = dtChiTiet;
        }
        #endregion

        //#region enable control
        //public void enable_Control()
        //{
        //    txt_ID.Enabled = false;
        //    txt_TenCH.Enabled = false;
        //    txt_DiaChi.Enabled = false;
        //    txt_NgayDK.Enabled = false;
        //    txt_SDT.Enabled = false;
        //    txt_ChuKy.Enabled = false;
        //    txt_TruyCap.Enabled = false;
        //}
        //#endregion

        #region get store
        public DataTable get_Store()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên cửa hàng", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Ngày đăng ký", typeof(DateTime));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Chữ ký", typeof(string));
            dt.Columns.Add("Lượt truy cập", typeof(int));
            dt.Columns.Add("Hoạt động", typeof(bool));
            IMongoQueryable<cua_hang> stores = storeDAL.load_Store();
            foreach (var s in stores)
            {
                dt.Rows.Add(s._id, s.ten_cua_hang, s.dia_chi,
                    s.ngay_dang_ky, s.so_dien_thoai, s.chu_ky,
                    s.luot_truy_cap, s.trang_thai_hoat_dong);
            }
            return dt;
        }

        #endregion

        private void btn_Luu_Click(object sender, EventArgs e)
        { 
            bool hoatDong;
            if (cbo_HoatDong.SelectedItem.ToString() == "Hoạt động")
                hoatDong = true;
            else
                hoatDong = false;
            if (txt_ID.Text.Equals(""))
            {
                MessageBox.Show("Chọn cửa hàng cần cập nhật hoạt động");
                return;
            }
            storeDAL.update_Store(ObjectId.Parse(txt_ID.Text), hoatDong);
            get_DataGridviewStore();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Equals(""))
            {
                MessageBox.Show("Chọn cửa hàng cần xóa");
                return;
            }
            storeDAL.delete_Store(ObjectId.Parse(txt_ID.Text), true);
            get_DataGridviewStore();
        }

        private void data_Store_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_Store.CurrentRow.Cells[0].Value.ToString();
            string ten = data_Store.CurrentRow.Cells[1].Value.ToString();
            string diaChi = data_Store.CurrentRow.Cells[2].Value.ToString();
            string ngayDK = data_Store.CurrentRow.Cells[3].Value.ToString();
            string sdt = data_Store.CurrentRow.Cells[4].Value.ToString();
            string chuKy = data_Store.CurrentRow.Cells[5].Value.ToString();
            string truyCap = data_Store.CurrentRow.Cells[6].Value.ToString();
            txt_ID.Text = id;
            txt_TenCH.Text = ten;
            txt_DiaChi.Text = diaChi;
            txt_NgayDK.Text = ngayDK;
            txt_SDT.Text = sdt;
            txt_ChuKy.Text = chuKy;
            txt_TruyCap.Text = truyCap;
        }

        private void data_Store_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (e.ColumnIndex == 7 && e.RowIndex >= 0) // Thay yourBoolColumnIndex bằng chỉ số của cột bool trong DataGridView
            {
                DataGridViewCell cell = data_Store.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is bool)
                {
                    bool value = (bool)cell.Value;
                    if (value)
                    {
                        cbo_HoatDong.Text = "Hoạt động";
                    }
                    else
                    {
                        cbo_HoatDong.Text = "Ngừng hoạt động";
                    }
                }
            }
        }

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
