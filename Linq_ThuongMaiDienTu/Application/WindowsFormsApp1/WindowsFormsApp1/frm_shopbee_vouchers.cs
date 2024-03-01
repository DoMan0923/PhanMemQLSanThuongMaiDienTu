using DAL;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_shopbee_vouchers : Form
    {
        ShopbeeVouchersDAL shopbeeVouchersDAL = new ShopbeeVouchersDAL();
        PaymentMethodDAL paymentMethodDAL = new PaymentMethodDAL();
        ShippingMethodDAL shippingMethodDAL = new ShippingMethodDAL();
        CategoryDAL categoryDAL = new CategoryDAL();
        List<shopbee_vouchers> shopbeeVouchers;
        bool flagUpdate = true;
        List<voucher> vouchers;
        string voucherCodeChange = null;
        //ToastNotificationsManager toastManager = new ToastNotificationsManager();
        public frm_shopbee_vouchers()
        {
            InitializeComponent();
            List<AlgorithmData> algorithmDatas = new UserClusterPartition().OriginSetUp();
            foreach (AlgorithmData algorithmData in algorithmDatas)
            {
                algorithmData.Print();
            }

            dataView.Columns.Add(Helper.BuildColumnName("ma_voucher", "Mã voucher"));
            dataView.Columns.Add(Helper.BuildColumnName("ten_voucher", "Tên voucher"));
            dataView.Columns.Add(Helper.BuildColumnName("ty_le_giam_gia", "Tỷ lệ giảm giá"));
            dataView.Columns.Add(Helper.BuildColumnName("don_hang_toi_thieu", "Đơn hàng tối thiểu"));
            dataView.Columns.Add(Helper.BuildColumnName("muc_giam_toi_da", "Mức giảm tối đa"));
            dataView.Columns.Add(Helper.BuildColumnName("so_luong", "Số lượng"));
            dataView.Columns.Add(Helper.BuildColumnName("ngay_bat_dau", "Ngày bắt đầu"));
            dataView.Columns.Add(Helper.BuildColumnName("ngay_ket_thuc", "Ngày kết thúc"));

            dataView.Columns.Add(Helper.BuildColumnName("doi_tuong_tham_chieu_str", "Điều kiện áp dụng"));
            dataView.Columns.Add(Helper.BuildColumnName("danh_mucs_str", "Danh mục áp dụng"));
            dataView.Columns.Add(Helper.BuildColumnName("phuong_thuc_van_chuyens_str", "Phương thức vận chuyển áp dụng"));
            dataView.Columns.Add(Helper.BuildColumnName("phuong_thuc_thanh_toans_str", "Phương thức thanh toán áp dụng"));
            dataView.Columns.Add(Helper.BuildColumnName("cua_hangs_str", "Cửa hàng đăng ký"));

            //dtVouchers.Columns.Add("Mã voucher", typeof(string));
            //dtVouchers.Columns.Add("Tên voucher", typeof(string));
            //dtVouchers.Columns.Add("Tỷ lệ giảm giá", typeof(double));
            //dtVouchers.Columns.Add("Đơn hàng tối thiếu", typeof(int));
            //dtVouchers.Columns.Add("Số lượng", typeof(int));
            //dtVouchers.Columns.Add("Mức giảm tối đa", typeof(int));
            //dtVouchers.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            //dtVouchers.Columns.Add("Ngày kết thúc", typeof(DateTime));
            //dtVouchers.Columns.Add("Đối tượng tham chiếu", typeof(string));
            //dtVouchers.Columns.Add("Điều kiện áp dụng", typeof(string));
            //dtVouchers.Columns.Add("Phương thức vận chuyển áp dụng", typeof(string));
            //dtVouchers.Columns.Add("Phương thức thanh toán áp dụng", typeof(string));
            //dtVouchers.Columns.Add("Cửa hàng đăng ký", typeof(string));

            shopbeeVouchers = shopbeeVouchersDAL.All().ToList();
            cbo_loaiVoucher.DataSource = shopbeeVouchers;
            cbo_loaiVoucher.DisplayMember = "loai_voucher";
            cbo_loaiVoucher.ValueMember = "_id";
            vouchers = shopbeeVouchersDAL.getVoucherDetails();            
            dataView.DataSource = vouchers;
            btn_chinhSua.Text = "Cập nhật";
            SetUp();
            //DataBindings();
            cbo_loaiVoucher.SelectedIndexChanged += Cbo_loaiVoucher_SelectedIndexChanged;
            chk_showAll.CheckedChanged += Chk_showAll_CheckedChanged;
            btn_chinhSua.Click += Btn_chinhSua_Click;
            btn_xoa.Click += Btn_xoa_Click;            
            btn_huy.Click += Btn_huy_Click;
            dataView.SelectionChanged += DataView_SelectionChanged;
            dataView.CellBeginEdit += DataView_CellBeginEdit;
            txt_maVoucher.KeyPress += Txt_maVoucher_KeyPress;                    

        }

        private void Txt_maVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Enter || !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) )
                e.Handled = true;
        }

        private void DataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ClearBinding()
        {
            txt_maVoucher.DataBindings.Clear();
            txt_tenVoucher.DataBindings.Clear();
            txt_tyLeGiamGia.DataBindings.Clear();
            txt_donHangToiThieu.DataBindings.Clear();
            txt_mucGiamToiDa.DataBindings.Clear();
            txt_soLuong.DataBindings.Clear();
        }
        private void ClearText()
        {
            txt_maVoucher.Clear();
            txt_tenVoucher.Clear();
            txt_tyLeGiamGia.Clear();
            txt_donHangToiThieu.Clear();
            txt_mucGiamToiDa.Clear();
            txt_soLuong.Clear();
        }

        private void DataBindings()
        {
            txt_maVoucher.DataBindings.Add("Text", dataView.DataSource, "ma_voucher");
            txt_tenVoucher.DataBindings.Add("Text", dataView.DataSource, "ten_voucher");
            txt_tyLeGiamGia.DataBindings.Add("Text", dataView.DataSource, "ty_le_giam_gia");
            txt_donHangToiThieu.DataBindings.Add("Text", dataView.DataSource, "don_hang_toi_thieu");
            txt_mucGiamToiDa.DataBindings.Add("Text", dataView.DataSource, "muc_giam_toi_da");
            txt_soLuong.DataBindings.Add("Text", dataView.DataSource, "so_luong");
            dateTimePicker_ngayBatDau.DataBindings.Add("Text", dataView.DataSource, "ngay_bat_dau");
            dateTimePicker_gioBatDau.DataBindings.Add("Text", dataView.DataSource, "ngay_bat_dau");
            dateTimePicker_ngayKetThuc.DataBindings.Add("Text", dataView.DataSource, "ngay_ket_thuc");
            dateTimePicker_gioKetThuc.DataBindings.Add("Text", dataView.DataSource, "ngay_ket_thuc");
            //txt_maVoucher.DataBindings.Add("Text", dataView.DataSource, "Mã voucher");
            //txt_tenVoucher.DataBindings.Add("Text", dataView.DataSource, "Tên voucher");
            //txt_tyLeGiamGia.DataBindings.Add("Text", dataView.DataSource, "Tỷ lệ giảm giá");
            //txt_donHangToiThieu.DataBindings.Add("Text", dataView.DataSource, "Đơn hàng tối thiểu");
            //txt_mucGiamToiDa.DataBindings.Add("Text", dataView.DataSource, "Mức giảm tối đa");
            //txt_soLuong.DataBindings.Add("Text", dataView.DataSource, "Số lượng");
        }
        private void DataView_SelectionChanged(object sender, EventArgs e)
        {
            SetUp(true);            
            voucher vcher = GetVoucherChange();
            if (vcher == null)
                return;
            voucherCodeChange = vcher.ma_voucher;
            txt_maVoucher.Text = vcher.ma_voucher;
            txt_tenVoucher.Text = vcher.ten_voucher;
            txt_tyLeGiamGia.Text = vcher.ty_le_giam_gia.ToString();
            txt_donHangToiThieu.Text = vcher.don_hang_toi_thieu.ToString();
            txt_mucGiamToiDa.Text = vcher.muc_giam_toi_da.ToString();
            txt_soLuong.Text = vcher.so_luong.ToString();

            dateTimePicker_ngayBatDau.Text = vcher.ngay_bat_dau.ToString();        
            dateTimePicker_gioBatDau.Text = vcher.ngay_bat_dau.ToString();        
            dateTimePicker_ngayKetThuc.Text = vcher.ngay_ket_thuc.ToString();        
            dateTimePicker_gioKetThuc.Text = vcher.ngay_ket_thuc.ToString();        
            btn_chinhSua.Enabled = true;
            SetControl(vcher);
        }

        private voucher GetVoucherChange()
        {
            if (!flagUpdate)
                return null;            
            string voucherCode = dataView.CurrentRow.Cells[0].Value.ToString();
            return shopbeeVouchersDAL.findByVoucherCode(shopbeeVouchers,voucherCode);
        }
       
        private void SetUp(bool flagUpdate)
        { 
            this.flagUpdate = flagUpdate;            
            btn_chinhSua.Text = flagUpdate ? "Cập nhật" : "Thêm";
            btn_xoa.Enabled = flagUpdate;            
            btn_huy.Text = flagUpdate ? "Hủy" : "Làm mới";
        }
        private void SetControl(voucher vcher)
        {
            if (vcher != null && vcher.doi_tuong_tham_chieu != null)
            {
                foreach (var control in panel_doiTuongThamChieu.Controls)
                {
                    ControlConditionVoucher controlCondition = (ControlConditionVoucher)control;
                    string doiTuongThamChieu = controlCondition.DoiTuongThamChieu;
                    if (vcher.doi_tuong_tham_chieu.Contains(doiTuongThamChieu))
                    {
                        controlCondition.Enableds = true;
                        switch (doiTuongThamChieu)
                        {
                            case "danh_muc":
                                controlCondition.Reset(categoryDAL.FindByIdsAsString(vcher.danh_mucs), true);
                                break;
                            case "phuong_thuc_thanh_toan":
                                controlCondition.Reset(paymentMethodDAL.FindByIdsAsString(vcher.phuong_thuc_thanh_toans), true);
                                break;
                            case "phuong_thuc_van_chuyen":
                                controlCondition.Reset(shippingMethodDAL.FindByIdsAsString(vcher.phuong_thuc_van_chuyens), true);
                                break;
                        }
                    }
                    else
                    {
                        controlCondition.Reset(null, false);
                    }
                }
                chk_cuaHang.Checked = vcher.doi_tuong_tham_chieu.Contains("cua_hang");
            }             
        }
        private void Btn_chinhSua_Click(object sender, EventArgs e)
        {
            if(txt_maVoucher.Text == null || txt_maVoucher.Text == "")
            {
                MessageBox.Show("Mã voucher không được để trống");
                txt_maVoucher.Focus();
                return;
            }
            else if(vouchers.Where(vc => vc.ma_voucher.Equals(txt_maVoucher.Text) &&
                ((flagUpdate && txt_maVoucher.Text != voucherCodeChange) ||(!flagUpdate))).FirstOrDefault()!=null)
            {                                
                MessageBox.Show("Mã voucher đã bị trùng");
                txt_maVoucher.Clear();
                txt_maVoucher.Focus();
                return;
            }
            if (txt_tyLeGiamGia.Text == null || txt_tyLeGiamGia.Text == "")
            {
                MessageBox.Show("Tỷ lệ giảm giá không được để trống");
                txt_tyLeGiamGia.Focus();
                return;
            }
            if (txt_donHangToiThieu.Text == null || txt_donHangToiThieu.Text == "")
            {
                MessageBox.Show("Giá trị đơn hàng tối thiểu không được để trống");
                txt_donHangToiThieu.Focus();
                return;
            }
            if (txt_mucGiamToiDa.Text == null || txt_mucGiamToiDa.Text == "")
            {
                MessageBox.Show("Mức giảm tối đa không được để trống");
                txt_mucGiamToiDa.Focus();
                return;
            }
            if (txt_soLuong.Text == null || txt_soLuong.Text == "")
            {
                MessageBox.Show("Số lượng voucher không được để trống");
                txt_soLuong.Focus();
                return;
            }
            DateTime ngayBatDau = dateTimePicker_ngayBatDau.Value;
            DateTime gioBatDau = dateTimePicker_gioBatDau.Value;            
            DateTime ngayKetThuc = dateTimePicker_ngayKetThuc.Value;
            DateTime gioKetThuc = dateTimePicker_gioKetThuc.Value;
            DateTime batDau = ngayBatDau.Date + gioBatDau.TimeOfDay;
            DateTime ketThuc = ngayKetThuc.Date + gioKetThuc.TimeOfDay;         
            if(ketThuc<DateTime.Now)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hiện tại");
                return;
            }
            if (ketThuc < batDau)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            voucher vcher = BuildVoucher();
            vcher.ngay_bat_dau = batDau;
            vcher.ngay_ket_thuc = ketThuc;
            List<string> doi_tuong_tham_chieu = new List<string>();
            if (chk_cuaHang.Checked == true)
            {
                doi_tuong_tham_chieu.Add("cua_hang");
            }            
            if (control_danh_muc.Checked)
            {
                doi_tuong_tham_chieu.Add("danh_muc");
                
                Console.WriteLine("vào 0");
                foreach (var id in vcher.danh_mucs)
                    Console.WriteLine(id);
            }
            vcher.danh_mucs = control_danh_muc.Ids;
            if (control_phuong_thuc_van_chuyen.Checked)
            {
                doi_tuong_tham_chieu.Add("phuong_thuc_van_chuyen");                
                Console.WriteLine("vào 1");
                foreach (var id in vcher.phuong_thuc_van_chuyens)
                    Console.WriteLine(id);
            }
            vcher.phuong_thuc_van_chuyens = control_phuong_thuc_van_chuyen.Ids;
            if (control_phuong_thuc_thanh_toan.Checked)
            {
                doi_tuong_tham_chieu.Add("phuong_thuc_thanh_toan");                
                Console.WriteLine("vào 2");
                foreach (var id in vcher.phuong_thuc_thanh_toans)
                    Console.WriteLine(id);
            }
            vcher.phuong_thuc_thanh_toans = control_phuong_thuc_thanh_toan.Ids;            
            vcher.doi_tuong_tham_chieu = doi_tuong_tham_chieu;
            shopbee_vouchers shopbeeVouchers = GetShopbeeVoucherChange();

            if (flagUpdate)
            {
                if (MessageBox.Show("Bạn muốn cập nhật voucher?", "Xác nhận cập nhật voucher này?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (shopbeeVouchersDAL.UpdateVoucher(shopbeeVouchers, voucherCodeChange, vcher) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        Chk_showAll_CheckedChanged(null, null);
                    }
                    else
                        MessageBox.Show("Mã voucher không còn tồn tại");
                }
            }   
            else
            {
                if (MessageBox.Show("Bạn muốn thêm voucher?", "Xác nhận thêm voucher vào hệ thống?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    shopbeeVouchersDAL.Push(shopbeeVouchers, vcher);                    
                    Chk_showAll_CheckedChanged(null, null);
                    MessageBox.Show("Thêm voucher thành công");
                }
            }    
        }
        private void Btn_huy_Click(object sender, EventArgs e)
        {
            if(flagUpdate)
            {
                SetUp(false);
                voucherCodeChange = null;
            }                
            ClearText();
            control_danh_muc.Reset(null, false);
            control_phuong_thuc_van_chuyen.Reset(null, false);
            control_phuong_thuc_thanh_toan.Reset(null, false);
            if (chk_showAll.Checked)
                btn_chinhSua.Enabled = false;
        }
        private void Btn_lamMoi_Click(object sender, EventArgs e)
        {
            
        }
        private shopbee_vouchers GetShopbeeVoucherChange()
        {
            if (chk_showAll.Checked)
            {
                return shopbeeVouchersDAL.FindByVoucherCode(voucherCodeChange);
            }
            else
            {
                return shopbeeVouchersDAL.Find((ObjectId)cbo_loaiVoucher.SelectedValue);
            }
        }
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa voucher ?", "Xác nhận cập nhật voucher '" + voucherCodeChange + "'?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                shopbeeVouchersDAL.Pull(GetShopbeeVoucherChange(), voucherCodeChange);
                Chk_showAll_CheckedChanged(null, null);
                MessageBox.Show("Xóa voucher thành công!");
            }
        }
        private voucher BuildVoucher()
        {
            double ty_le_giam_gia = double.Parse(txt_tyLeGiamGia.Text);
            if (ty_le_giam_gia > 1)
                ty_le_giam_gia = ty_le_giam_gia / 10;
            return new voucher()
            {
                ma_voucher = txt_maVoucher.Text,
                ten_voucher = txt_tenVoucher.Text,
                don_hang_toi_thieu = int.Parse(txt_donHangToiThieu.Text),
                muc_giam_toi_da = int.Parse(txt_mucGiamToiDa.Text),
                ty_le_giam_gia = ty_le_giam_gia,
                so_luong = int.Parse(txt_soLuong.Text)
            };
        }

        private void Chk_showAll_CheckedChanged(object sender, EventArgs e)
        {
            shopbeeVouchers = shopbeeVouchersDAL.All().ToList();            
            cbo_loaiVoucher.Enabled = !chk_showAll.Checked;
            if (chk_showAll.Checked)
            {
                vouchers = shopbeeVouchersDAL.getVoucherDetails(shopbeeVouchers);
                dataView.DataSource = vouchers;
                DataView_SelectionChanged(null,null);                
                return;
            }
            else
            {
                btn_chinhSua.Enabled = true;
                Cbo_loaiVoucher_SelectedIndexChanged(null, null);
                Btn_huy_Click(null, null);
            }    
        }

        private void SetUp()
        {
            chk_showAll.Checked = true;
            cbo_loaiVoucher.Enabled = false;
            dateTimePicker_gioBatDau.ShowUpDown = true;
            dateTimePicker_gioKetThuc.ShowUpDown = true;            
            txt_tyLeGiamGia.CheckDouble = true;
            txt_tyLeGiamGia.MaxValue = 1;
            txt_tyLeGiamGia.MinValue = 0;
            List<danh_muc> danhMucs;
            List<phuong_thuc_van_chuyen> vanChuyens;
            List<phuong_thuc_thanh_toan> thanhToans;
            danhMucs = categoryDAL.All().ToList();
            vanChuyens = shippingMethodDAL.All().ToList();
            thanhToans = paymentMethodDAL.All().ToList();
            control_danh_muc.SetDataSource(danhMucs, "ten_danh_muc", "_id");
            control_phuong_thuc_van_chuyen.SetDataSource(vanChuyens, "ten_phuong_thuc_van_chuyen", "_id");
            control_phuong_thuc_thanh_toan.SetDataSource(thanhToans, "ten_phuong_thuc_thanh_toan", "_id");

        }

        private void Cbo_loaiVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ObjectId id = (ObjectId)cbo_loaiVoucher.SelectedValue;
            List<voucher> vouchers = shopbeeVouchersDAL.getVoucherDetails(shopbeeVouchers,id);
            dataView.DataSource = vouchers;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_themThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void panel_doiTuongThamChieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void control_phuong_thuc_van_chuyen_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_gioKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_shopbee_vouchers_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
