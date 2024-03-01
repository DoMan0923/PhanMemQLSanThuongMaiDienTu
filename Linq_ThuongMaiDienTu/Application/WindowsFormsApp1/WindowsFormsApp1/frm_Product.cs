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
using Newtonsoft.Json.Linq;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frm_Product : Form
    {
        ProductMethodDAL productDAL = new ProductMethodDAL();
        DataTable dtChiTiet = new DataTable();
        List<san_pham> productsAsList;
        int kc = 10;
        int chieuDai = 20;
       
        private VScrollBar vScrollBar;
        public frm_Product()
        {
            InitializeComponent();
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            get_DataGridviewProduct();
        }
        public void get_DataGridviewProduct()
        {
            dtChiTiet = get_Product();
            data_Product.DataSource = dtChiTiet;
        }
        public void crearte_Scrollbar()
        {

        }
        public DataTable get_Product()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            //dt.Columns.Add("Khóa", typeof(bool));
            dt.Columns.Add("Trạng thái", typeof(bool));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Ảnh bìa", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));
            dt.Columns.Add("Thông tin chi tiết", typeof(string));
            dt.Columns.Add("Đánh giá", typeof(double));
            dt.Columns.Add("Số lượng đánh giá", typeof(int));
            dt.Columns.Add("Tên phân loại", typeof(string));
            dt.Columns.Add("Tên kích cỡ", typeof(string));
            dt.Columns.Add("Giá hiện tại", typeof(int));
            //dt.Columns.Add("Phân loại", typeof(List<CategoryProduct>));
            dt.Columns.Add("Giảm giá", typeof(double));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("Ngày kết thúc", typeof(DateTime));
            dt.Columns.Add("Số lượng giới hạn", typeof(int));
            dt.Columns.Add("Số lượng tồn", typeof(int));
            dt.Columns.Add("Ảnh sản phẩm", typeof(string));
            dt.Columns.Add("Video", typeof(string));
            IMongoQueryable<san_pham> products = productDAL.load_Product();
            productsAsList = products.ToList();
            foreach (var p in products)
            {
                string allThuocTinh = "";
                //Array images
                string arrayAnh = string.Join(", ", p.anh_san_phams ?? new List<string>());
                //1 document Thông tin chi tiết
                string thongTinChiTiet = p.thong_tin_chi_tiet.ToJson();
                JObject tt = JObject.Parse(thongTinChiTiet);
                foreach (var property in tt.Properties())
                {
                    string key = property.Name;
                    JToken value = property.Value;
                    allThuocTinh += key + ": " + " " + value + " ";
                }
                dt.Rows.Add(p._id, p.trang_thai, p.ten_san_pham, p.anh_bia, p.mo_ta, allThuocTinh,
                    p.danh_gia, p.so_luong_danh_gia, p.doi_ten_phan_loai,
                    p.doi_ten_kich_co, p.gia_hien_tai, p.giam_gia,
                    p.ngay_bat_dau, p.ngay_ket_thuc, p.so_luong_gioi_han,
                    p.so_luong_ton, arrayAnh, p.video);


            }
            return dt;
        }

        private void data_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_Product.CurrentRow.Cells[0].Value.ToString();
            string tenSP = data_Product.CurrentRow.Cells[2].Value.ToString();
            string tenHinh = data_Product.CurrentRow.Cells[3].Value.ToString();
            string moTa = data_Product.CurrentRow.Cells[4].Value.ToString();
            string thongTinChiTiet = data_Product.CurrentRow.Cells[5].Value.ToString();
            string danhGiaTB = data_Product.CurrentRow.Cells[6].Value.ToString();
            string slDanhGia = data_Product.CurrentRow.Cells[7].Value.ToString();
            string tenPhanLoai = data_Product.CurrentRow.Cells[8].Value.ToString();
            string tenKichCo = data_Product.CurrentRow.Cells[9].Value.ToString();
            string giaHienTai = data_Product.CurrentRow.Cells[10].Value.ToString();
            string giamGia = data_Product.CurrentRow.Cells[11].Value.ToString();
            string ngayBD = data_Product.CurrentRow.Cells[12].Value.ToString();
            string ngayKT = data_Product.CurrentRow.Cells[13].Value.ToString();
            string slGioiHan = data_Product.CurrentRow.Cells[14].Value.ToString();
            string slTon = data_Product.CurrentRow.Cells[15].Value.ToString();
            string tenDSHinh = data_Product.CurrentRow.Cells[16].Value.ToString();
            //string tenVideo = data_Product.CurrentRow.Cells[18].Value.ToString();
            txt_ID.Text = id;
            txt_TenSP.Text = tenSP;
            txt_MoTa.Text = moTa;
            txt_ThongTinChiTiet.Text = thongTinChiTiet;
            txt_DanhGiaTB.Text = danhGiaTB;
            txt_SLDanhGia.Text = slDanhGia;
            txt_TenLoai.Text = tenPhanLoai;
            txt_TenKichCo.Text = tenKichCo;
            txt_GiaHienTai.Text = giaHienTai;
            txt_GiamGia.Text = giamGia;
            txt_NgayBatDau.Text = ngayBD;
            txt_NgayKetThuc.Text = ngayKT;
            txt_SLGioiHan.Text = slGioiHan;
            txt_SLTon.Text = slTon;
            groupImage.Controls.Clear();
            san_pham san_pham = productsAsList.Where(p => p._id.Equals(ObjectId.Parse(id))).FirstOrDefault();
            List<string> images = san_pham.anh_san_phams;
            string path = @"D:\BAITIEULUAN\UD_PMTM\Linq_ThuongMaiDienTu\App_ThuongMaiDienTu\App_ThuongMaiDienTu\Images\Uploads\" + san_pham.CuaHangID.ToString() + @"\" + san_pham._id.ToString();
            display_Image(tenHinh, path);
            if (images == null)
            {
                return;
            }
            string duongDanHinhAnh = "";
            //Tạo Scroll
            panel1.AutoScroll = true;
            groupImage.Left = 5;
            groupImage.Top = 5;
            int lef = 10;
            int top = 15;
            for (int i = 0; i < images.Count; i++)
            {
                if (i % 4 == 0 && i!=0)
                {
                    lef = 10;
                    top += 80;
                }
                PictureBox p = new PictureBox();
                p.Top = top;
                p.Left = lef;
                lef += kc + 100;
                p.Width = 100;
                p.Height = 70;
                this.groupImage.Controls.Add(p);

                duongDanHinhAnh = Path.Combine(path, images[i].Trim());
                if (File.Exists(duongDanHinhAnh))
                {
                    p.ImageLocation = duongDanHinhAnh;
                    p.SizeMode = PictureBoxSizeMode.Zoom;
                }
                groupImage.Height += 500;
                panel1.Controls.Add(groupImage);

               
            }
        }
        public void display_Image(string tenHinh, string path)
        {
            string duongDanHinhAnh = Path.Combine(path, tenHinh);
            if (File.Exists(duongDanHinhAnh))
            {
                p_AnhBia.ImageLocation = duongDanHinhAnh;
            }
            else
            {
                p_AnhBia.Image = null;
            }
        }

        private void data_Product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) // Thay yourBoolColumnIndex bằng chỉ số của cột bool trong DataGridView
            {
                DataGridViewCell cell = data_Product.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is bool)
                {
                    bool value = (bool)cell.Value;
                    if (value)
                    {
                        cbo_TrangThai.Text = "Được bán";
                    }
                    else
                    {
                        cbo_TrangThai.Text = "Ngừng hoạt động";
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //Check chưa chọn
            if (txt_ID.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
                return;
            }
            productDAL.delete_Product(ObjectId.Parse(txt_ID.Text), true);
            get_DataGridviewProduct();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Check chưa chọn
            if (txt_ID.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn dòng để cập nhật");
                return;
            }
            bool trangThai;
            if (cbo_TrangThai.SelectedItem.ToString() == "Được bán")
                trangThai = true;
            else
                trangThai = false;
            productDAL.update_Product(ObjectId.Parse(txt_ID.Text), trangThai);
            MessageBox.Show("Cập nhật thành công");
            get_DataGridviewProduct();
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
