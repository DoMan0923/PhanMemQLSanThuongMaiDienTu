
namespace WindowsFormsApp1
{
    partial class frm_shopbee_vouchers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_shopbee_vouchers));
            this.cbo_loaiVoucher = new System.Windows.Forms.ComboBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.chk_showAll = new System.Windows.Forms.CheckBox();
            this.txt_maVoucher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenVoucher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_chinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_gioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_gioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.chk_cuaHang = new System.Windows.Forms.CheckBox();
            this.panel_doiTuongThamChieu = new System.Windows.Forms.Panel();
            this.toastManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.txt_tyLeGiamGia = new ControlCustom.TextBoxNumber();
            this.txt_soLuong = new ControlCustom.TextBoxNumber();
            this.txt_mucGiamToiDa = new ControlCustom.TextBoxNumber();
            this.txt_donHangToiThieu = new ControlCustom.TextBoxNumber();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.control_phuong_thuc_thanh_toan = new WindowsFormsApp1.ControlConditionVoucher();
            this.control_phuong_thuc_van_chuyen = new WindowsFormsApp1.ControlConditionVoucher();
            this.control_danh_muc = new WindowsFormsApp1.ControlConditionVoucher();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel_doiTuongThamChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastManager)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_loaiVoucher
            // 
            this.cbo_loaiVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaiVoucher.FormattingEnabled = true;
            this.cbo_loaiVoucher.Location = new System.Drawing.Point(168, 14);
            this.cbo_loaiVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_loaiVoucher.Name = "cbo_loaiVoucher";
            this.cbo_loaiVoucher.Size = new System.Drawing.Size(326, 37);
            this.cbo_loaiVoucher.TabIndex = 0;
            // 
            // dataView
            // 
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.BackgroundColor = System.Drawing.Color.White;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(15, 36);
            this.dataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 62;
            this.dataView.Size = new System.Drawing.Size(1924, 504);
            this.dataView.TabIndex = 1;
            // 
            // chk_showAll
            // 
            this.chk_showAll.AutoSize = true;
            this.chk_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showAll.Location = new System.Drawing.Point(45, 14);
            this.chk_showAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_showAll.Name = "chk_showAll";
            this.chk_showAll.Size = new System.Drawing.Size(105, 33);
            this.chk_showAll.TabIndex = 2;
            this.chk_showAll.Text = "Tất cả";
            this.chk_showAll.UseVisualStyleBackColor = true;
            // 
            // txt_maVoucher
            // 
            this.txt_maVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maVoucher.Location = new System.Drawing.Point(214, 63);
            this.txt_maVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maVoucher.Multiline = true;
            this.txt_maVoucher.Name = "txt_maVoucher";
            this.txt_maVoucher.Size = new System.Drawing.Size(394, 36);
            this.txt_maVoucher.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã voucher";
            // 
            // txt_tenVoucher
            // 
            this.txt_tenVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenVoucher.Location = new System.Drawing.Point(214, 109);
            this.txt_tenVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tenVoucher.Multiline = true;
            this.txt_tenVoucher.Name = "txt_tenVoucher";
            this.txt_tenVoucher.Size = new System.Drawing.Size(394, 36);
            this.txt_tenVoucher.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên voucher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tỷ lệ giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn hàng tối thiểu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mức giảm tối đa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // btn_chinhSua
            // 
            this.btn_chinhSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chinhSua.Appearance.Options.UseFont = true;
            this.btn_chinhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chinhSua.ImageOptions.Image")));
            this.btn_chinhSua.Location = new System.Drawing.Point(37, 451);
            this.btn_chinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_chinhSua.Name = "btn_chinhSua";
            this.btn_chinhSua.Size = new System.Drawing.Size(155, 45);
            this.btn_chinhSua.TabIndex = 8;
            this.btn_chinhSua.Text = "Thêm";
            // 
            // btn_huy
            // 
            this.btn_huy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Appearance.Options.UseFont = true;
            this.btn_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.ImageOptions.Image")));
            this.btn_huy.Location = new System.Drawing.Point(365, 451);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(157, 45);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(200, 451);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(157, 45);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            // 
            // dateTimePicker_ngayBatDau
            // 
            this.dateTimePicker_ngayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayBatDau.Location = new System.Drawing.Point(217, 346);
            this.dateTimePicker_ngayBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_ngayBatDau.Name = "dateTimePicker_ngayBatDau";
            this.dateTimePicker_ngayBatDau.Size = new System.Drawing.Size(181, 35);
            this.dateTimePicker_ngayBatDau.TabIndex = 11;
            // 
            // dateTimePicker_ngayKetThuc
            // 
            this.dateTimePicker_ngayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayKetThuc.Location = new System.Drawing.Point(214, 386);
            this.dateTimePicker_ngayKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_ngayKetThuc.MinDate = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            this.dateTimePicker_ngayKetThuc.Name = "dateTimePicker_ngayKetThuc";
            this.dateTimePicker_ngayKetThuc.Size = new System.Drawing.Size(181, 35);
            this.dateTimePicker_ngayKetThuc.TabIndex = 11;
            this.dateTimePicker_ngayKetThuc.Value = new System.DateTime(2023, 11, 28, 21, 49, 33, 0);
            // 
            // dateTimePicker_gioBatDau
            // 
            this.dateTimePicker_gioBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_gioBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_gioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_gioBatDau.Location = new System.Drawing.Point(418, 346);
            this.dateTimePicker_gioBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_gioBatDau.Name = "dateTimePicker_gioBatDau";
            this.dateTimePicker_gioBatDau.Size = new System.Drawing.Size(190, 35);
            this.dateTimePicker_gioBatDau.TabIndex = 11;
            // 
            // dateTimePicker_gioKetThuc
            // 
            this.dateTimePicker_gioKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_gioKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_gioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_gioKetThuc.Location = new System.Drawing.Point(418, 386);
            this.dateTimePicker_gioKetThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_gioKetThuc.MinDate = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            this.dateTimePicker_gioKetThuc.Name = "dateTimePicker_gioKetThuc";
            this.dateTimePicker_gioKetThuc.Size = new System.Drawing.Size(190, 35);
            this.dateTimePicker_gioKetThuc.TabIndex = 11;
            this.dateTimePicker_gioKetThuc.Value = new System.DateTime(2023, 11, 28, 21, 49, 33, 0);
            this.dateTimePicker_gioKetThuc.ValueChanged += new System.EventHandler(this.dateTimePicker_gioKetThuc_ValueChanged);
            // 
            // chk_cuaHang
            // 
            this.chk_cuaHang.AutoSize = true;
            this.chk_cuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_cuaHang.Location = new System.Drawing.Point(623, 112);
            this.chk_cuaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_cuaHang.Name = "chk_cuaHang";
            this.chk_cuaHang.Size = new System.Drawing.Size(460, 33);
            this.chk_cuaHang.TabIndex = 12;
            this.chk_cuaHang.Text = "Bật tính năng cửa hàng đăng ký sử dụng";
            this.chk_cuaHang.UseVisualStyleBackColor = true;
            // 
            // panel_doiTuongThamChieu
            // 
            this.panel_doiTuongThamChieu.Controls.Add(this.control_phuong_thuc_thanh_toan);
            this.panel_doiTuongThamChieu.Controls.Add(this.control_phuong_thuc_van_chuyen);
            this.panel_doiTuongThamChieu.Controls.Add(this.control_danh_muc);
            this.panel_doiTuongThamChieu.Location = new System.Drawing.Point(623, 173);
            this.panel_doiTuongThamChieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_doiTuongThamChieu.Name = "panel_doiTuongThamChieu";
            this.panel_doiTuongThamChieu.Size = new System.Drawing.Size(1332, 362);
            this.panel_doiTuongThamChieu.TabIndex = 19;
            this.panel_doiTuongThamChieu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_doiTuongThamChieu_Paint);
            // 
            // toastManager
            // 
            this.toastManager.ApplicationId = "69f62ee7-bbc4-44c2-9a48-e04f234c18f8";
            // 
            // txt_tyLeGiamGia
            // 
            this.txt_tyLeGiamGia.CheckDouble = false;
            this.txt_tyLeGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tyLeGiamGia.Location = new System.Drawing.Point(214, 251);
            this.txt_tyLeGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tyLeGiamGia.MaxValue = null;
            this.txt_tyLeGiamGia.MinValue = null;
            this.txt_tyLeGiamGia.Multiline = true;
            this.txt_tyLeGiamGia.Name = "txt_tyLeGiamGia";
            this.txt_tyLeGiamGia.Size = new System.Drawing.Size(394, 36);
            this.txt_tyLeGiamGia.TabIndex = 5;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.CheckDouble = false;
            this.txt_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuong.Location = new System.Drawing.Point(214, 205);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_soLuong.MaxValue = null;
            this.txt_soLuong.MinValue = null;
            this.txt_soLuong.Multiline = true;
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(394, 36);
            this.txt_soLuong.TabIndex = 5;
            // 
            // txt_mucGiamToiDa
            // 
            this.txt_mucGiamToiDa.CheckDouble = false;
            this.txt_mucGiamToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mucGiamToiDa.Location = new System.Drawing.Point(217, 296);
            this.txt_mucGiamToiDa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mucGiamToiDa.MaxValue = null;
            this.txt_mucGiamToiDa.MinValue = null;
            this.txt_mucGiamToiDa.Multiline = true;
            this.txt_mucGiamToiDa.Name = "txt_mucGiamToiDa";
            this.txt_mucGiamToiDa.Size = new System.Drawing.Size(391, 36);
            this.txt_mucGiamToiDa.TabIndex = 5;
            // 
            // txt_donHangToiThieu
            // 
            this.txt_donHangToiThieu.CheckDouble = false;
            this.txt_donHangToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donHangToiThieu.Location = new System.Drawing.Point(214, 155);
            this.txt_donHangToiThieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_donHangToiThieu.MaxValue = null;
            this.txt_donHangToiThieu.MinValue = null;
            this.txt_donHangToiThieu.Multiline = true;
            this.txt_donHangToiThieu.Name = "txt_donHangToiThieu";
            this.txt_donHangToiThieu.Size = new System.Drawing.Size(394, 36);
            this.txt_donHangToiThieu.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1949, 548);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // control_phuong_thuc_thanh_toan
            // 
            this.control_phuong_thuc_thanh_toan.Checked = false;
            this.control_phuong_thuc_thanh_toan.DataSource = null;
            this.control_phuong_thuc_thanh_toan.DisplayMember = "";
            this.control_phuong_thuc_thanh_toan.DoiTuongThamChieu = "phuong_thuc_thanh_toan";
            this.control_phuong_thuc_thanh_toan.Enableds = false;
            this.control_phuong_thuc_thanh_toan.Label = "Điều kiện theo thanh toán";
            this.control_phuong_thuc_thanh_toan.Location = new System.Drawing.Point(886, 23);
            this.control_phuong_thuc_thanh_toan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.control_phuong_thuc_thanh_toan.Name = "control_phuong_thuc_thanh_toan";
            this.control_phuong_thuc_thanh_toan.Size = new System.Drawing.Size(436, 327);
            this.control_phuong_thuc_thanh_toan.TabIndex = 0;
            this.control_phuong_thuc_thanh_toan.ValueMember = "";
            // 
            // control_phuong_thuc_van_chuyen
            // 
            this.control_phuong_thuc_van_chuyen.Checked = false;
            this.control_phuong_thuc_van_chuyen.DataSource = null;
            this.control_phuong_thuc_van_chuyen.DisplayMember = "";
            this.control_phuong_thuc_van_chuyen.DoiTuongThamChieu = "phuong_thuc_van_chuyen";
            this.control_phuong_thuc_van_chuyen.Enableds = false;
            this.control_phuong_thuc_van_chuyen.Label = "Điều kiện theo vận chuyển";
            this.control_phuong_thuc_van_chuyen.Location = new System.Drawing.Point(445, 23);
            this.control_phuong_thuc_van_chuyen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.control_phuong_thuc_van_chuyen.Name = "control_phuong_thuc_van_chuyen";
            this.control_phuong_thuc_van_chuyen.Size = new System.Drawing.Size(437, 330);
            this.control_phuong_thuc_van_chuyen.TabIndex = 0;
            this.control_phuong_thuc_van_chuyen.ValueMember = "";
            this.control_phuong_thuc_van_chuyen.Load += new System.EventHandler(this.control_phuong_thuc_van_chuyen_Load);
            // 
            // control_danh_muc
            // 
            this.control_danh_muc.Checked = false;
            this.control_danh_muc.DataSource = null;
            this.control_danh_muc.DisplayMember = "";
            this.control_danh_muc.DoiTuongThamChieu = "danh_muc";
            this.control_danh_muc.Enableds = false;
            this.control_danh_muc.Label = "Điều kiện theo danh mục";
            this.control_danh_muc.Location = new System.Drawing.Point(6, 20);
            this.control_danh_muc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.control_danh_muc.Name = "control_danh_muc";
            this.control_danh_muc.Size = new System.Drawing.Size(433, 330);
            this.control_danh_muc.TabIndex = 0;
            this.control_danh_muc.ValueMember = "";
            // 
            // frm_shopbee_vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1962, 1108);
            this.Controls.Add(this.panel_doiTuongThamChieu);
            this.Controls.Add(this.chk_cuaHang);
            this.Controls.Add(this.dateTimePicker_gioKetThuc);
            this.Controls.Add(this.dateTimePicker_ngayKetThuc);
            this.Controls.Add(this.dateTimePicker_gioBatDau);
            this.Controls.Add(this.dateTimePicker_ngayBatDau);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_chinhSua);
            this.Controls.Add(this.txt_tyLeGiamGia);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_mucGiamToiDa);
            this.Controls.Add(this.txt_donHangToiThieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenVoucher);
            this.Controls.Add(this.txt_maVoucher);
            this.Controls.Add(this.chk_showAll);
            this.Controls.Add(this.cbo_loaiVoucher);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_shopbee_vouchers";
            this.Text = "cv";
            this.Load += new System.EventHandler(this.frm_shopbee_vouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel_doiTuongThamChieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastManager)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_loaiVoucher;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.CheckBox chk_showAll;
        private System.Windows.Forms.TextBox txt_maVoucher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenVoucher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlCustom.TextBoxNumber txt_donHangToiThieu;
        private ControlCustom.TextBoxNumber txt_soLuong;
        private ControlCustom.TextBoxNumber txt_tyLeGiamGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ControlCustom.TextBoxNumber txt_mucGiamToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btn_chinhSua;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gioBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gioKetThuc;
        private System.Windows.Forms.CheckBox chk_cuaHang;
        private System.Windows.Forms.Panel panel_doiTuongThamChieu;
        private ControlConditionVoucher control_phuong_thuc_thanh_toan;
        private ControlConditionVoucher control_phuong_thuc_van_chuyen;
        private ControlConditionVoucher control_danh_muc;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastManager;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}