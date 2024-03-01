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
    public partial class frm_Employee : Form
    {
        LoginMethodDAL loginDAL = new LoginMethodDAL();
        DataTable dtChiTiet = new DataTable();
        public bool flag = true;
        public string tenDN;
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void frm_Employee_Load(object sender, EventArgs e)
        {

            get_DataGridviewEmployee();

        }

        #region get employee datagridview
        public void get_DataGridviewEmployee()
        {
            dtChiTiet = get_Employee();
            data_NhanVien.DataSource = dtChiTiet;
        }
        #endregion

        #region get employee
        public DataTable get_Employee()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Tên nhân viên", typeof(string));
            dt.Columns.Add("Giới tính", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(DateTime));
            dt.Columns.Add("Tên đăng nhập", typeof(string));
            dt.Columns.Add("Mật khẩu", typeof(string));
            dt.Columns.Add("Chức vụ", typeof(string));
            IMongoQueryable<tai_khoan> employees = loginDAL.load_TaiKhoan();
            foreach (var p in employees)
            {
                dt.Rows.Add(p._id, p.ten_nhan_vien, p.gioi_tinh, p.dia_chi,
                    p.ngay_sinh,p.ten_dang_nhap, p.mat_khau, p.chuc_vu);
            }
            return dt;
        }
        #endregion

        private void data_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_NhanVien.CurrentRow.Cells[0].Value.ToString();
            string tennv = data_NhanVien.CurrentRow.Cells[1].Value.ToString();
            string gioitinh = data_NhanVien.CurrentRow.Cells[2].Value.ToString();
            string diachi = data_NhanVien.CurrentRow.Cells[3].Value.ToString();
            string ngaysinh = data_NhanVien.CurrentRow.Cells[4].Value.ToString();
            string tendn = data_NhanVien.CurrentRow.Cells[5].Value.ToString();
            string matkhau = data_NhanVien.CurrentRow.Cells[6].Value.ToString();
            string chucvu = data_NhanVien.CurrentRow.Cells[7].Value.ToString();
            txt_ID.Text = id;
            txt_TenNV.Text = tennv;
            cbo_GioiTinh.Text = gioitinh;
            txt_DiaChi.Text = diachi;
            txt_NgaySinh.Text = ngaysinh;
            txt_TenDN.Text = tendn;
            txt_MatKhau.Text = matkhau;
            txt_ChucVu.Text = chucvu;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            flag = true;
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flag = false;
            MessageBox.Show("Chọn 1 dòng để sửa");
            return;

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //check rỗng
            if (txt_TenNV.Text.Trim().Equals("")|| txt_DiaChi.Text.Trim().Equals("")
                || txt_NgaySinh.Text.Trim().Equals("") || txt_TenDN.Text.Trim().Equals("")
                || txt_MatKhau.Text.Trim().Equals("")|| txt_ChucVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (flag)
            {
                //check trùng tên 
                foreach (DataGridViewRow r in data_NhanVien.Rows)
                {
                    if (r.Cells["Tên đăng nhập"].Value != null)
                    {
                        tenDN = r.Cells["Tên đăng nhập"].Value.ToString();
                    }
                    if (tenDN == txt_TenDN.Text)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                        return;
                    }
                }
                loginDAL.insert_Employee(txt_TenNV.Text.Trim(), cbo_GioiTinh.SelectedItem.ToString(),
                txt_DiaChi.Text.Trim(), DateTime.Parse(txt_NgaySinh.Text.Trim()), txt_TenDN.Text.Trim(),
                txt_MatKhau.Text.Trim(), txt_ChucVu.Text.Trim());
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                
                loginDAL.update_Employee(ObjectId.Parse(txt_ID.Text.Trim()), txt_TenNV.Text.Trim(), cbo_GioiTinh.SelectedItem.ToString(),
                txt_DiaChi.Text.Trim(), DateTime.Parse(txt_NgaySinh.Text.Trim()), txt_TenDN.Text.Trim(),
                txt_MatKhau.Text.Trim(), txt_ChucVu.Text.Trim());
            }
            MessageBox.Show("Cập nhật thành công");
            get_DataGridviewEmployee();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                loginDAL.delete_Employee(ObjectId.Parse(txt_ID.Text.Trim()));
                get_DataGridviewEmployee();
            }
            else
                return;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
