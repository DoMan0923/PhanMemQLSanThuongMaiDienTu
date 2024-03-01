using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using DTO;
using MongoDB.Bson;
using System.Windows.Forms;
using DAL;

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        public string cv;
        public event Action<string> ChucVuSelected;
        LoginMethodDAL loginDAL = new LoginMethodDAL();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            get_ChucVu();
        }
        public void get_ChucVu()
        {
            IMongoQueryable<string> cv = loginDAL.load_ChucVu();
            foreach (string item in cv)
            {
                if (!cbo_ChucVu.Items.Contains(item))
                {
                    cbo_ChucVu.Items.Add(item);
                }
                else
                    return;
                
            }   
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            IMongoQueryable<tai_khoan> tk = loginDAL.load_TaiKhoanChucVu(txt_TenDN.Text.Trim());
            foreach (var item in tk)
            {
                if(item.ten_dang_nhap.Equals(txt_TenDN.Text.Trim())
                    && item.mat_khau.Equals(txt_MatKhau.Text.Trim())
                    && item.chuc_vu.Equals(cbo_ChucVu.SelectedItem.ToString()))
                {
                    this.Hide();
                    frm_Main m = new frm_Main();
                    cv = cbo_ChucVu.SelectedItem.ToString();
                    m.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Sai thông tin vui lòng nhập đúng");
                    return;
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
