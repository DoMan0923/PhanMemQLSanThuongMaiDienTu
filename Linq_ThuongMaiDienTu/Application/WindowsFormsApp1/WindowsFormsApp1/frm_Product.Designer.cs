
namespace WindowsFormsApp1
{
    partial class frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.p_AnhBia = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupImage = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_SLTon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_SLGioiHan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_NgayKetThuc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_NgayBatDau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GiaHienTai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TenKichCo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SLDanhGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DanhGiaTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ThongTinChiTiet = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.data_Product = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_AnhBia)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Product)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_AnhBia);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1449, 327);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình ảnh";
            // 
            // p_AnhBia
            // 
            this.p_AnhBia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.p_AnhBia.Location = new System.Drawing.Point(64, 81);
            this.p_AnhBia.Name = "p_AnhBia";
            this.p_AnhBia.Size = new System.Drawing.Size(387, 227);
            this.p_AnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_AnhBia.TabIndex = 5;
            this.p_AnhBia.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(918, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 29);
            this.label16.TabIndex = 3;
            this.label16.Text = "Danh sách ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ảnh đại diện";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.groupImage);
            this.panel1.Location = new System.Drawing.Point(630, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 236);
            this.panel1.TabIndex = 35;
            // 
            // groupImage
            // 
            this.groupImage.Location = new System.Drawing.Point(20, 18);
            this.groupImage.Name = "groupImage";
            this.groupImage.Size = new System.Drawing.Size(667, 200);
            this.groupImage.TabIndex = 15;
            this.groupImage.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1511, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 29);
            this.label18.TabIndex = 29;
            this.label18.Text = "Trạng thái";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Được bán",
            "Ngừng hoạt động"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(1717, 172);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(166, 37);
            this.cbo_TrangThai.TabIndex = 28;
            // 
            // txt_SLTon
            // 
            this.txt_SLTon.Location = new System.Drawing.Point(1717, 99);
            this.txt_SLTon.Multiline = true;
            this.txt_SLTon.Name = "txt_SLTon";
            this.txt_SLTon.ReadOnly = true;
            this.txt_SLTon.Size = new System.Drawing.Size(115, 43);
            this.txt_SLTon.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1511, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 29);
            this.label15.TabIndex = 26;
            this.label15.Text = "Số lượng tồn";
            // 
            // txt_SLGioiHan
            // 
            this.txt_SLGioiHan.Location = new System.Drawing.Point(1717, 32);
            this.txt_SLGioiHan.Multiline = true;
            this.txt_SLGioiHan.Name = "txt_SLGioiHan";
            this.txt_SLGioiHan.ReadOnly = true;
            this.txt_SLGioiHan.Size = new System.Drawing.Size(115, 43);
            this.txt_SLGioiHan.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1511, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = "Số lượng giới hạn";
            // 
            // txt_NgayKetThuc
            // 
            this.txt_NgayKetThuc.Location = new System.Drawing.Point(1280, 218);
            this.txt_NgayKetThuc.Multiline = true;
            this.txt_NgayKetThuc.Name = "txt_NgayKetThuc";
            this.txt_NgayKetThuc.ReadOnly = true;
            this.txt_NgayKetThuc.Size = new System.Drawing.Size(207, 43);
            this.txt_NgayKetThuc.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1114, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ngày kết thúc";
            // 
            // txt_NgayBatDau
            // 
            this.txt_NgayBatDau.Location = new System.Drawing.Point(1280, 153);
            this.txt_NgayBatDau.Multiline = true;
            this.txt_NgayBatDau.Name = "txt_NgayBatDau";
            this.txt_NgayBatDau.ReadOnly = true;
            this.txt_NgayBatDau.Size = new System.Drawing.Size(207, 43);
            this.txt_NgayBatDau.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1110, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày bắt đầu";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Location = new System.Drawing.Point(1280, 91);
            this.txt_GiamGia.Multiline = true;
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.ReadOnly = true;
            this.txt_GiamGia.Size = new System.Drawing.Size(146, 43);
            this.txt_GiamGia.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1114, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Giảm giá";
            // 
            // txt_GiaHienTai
            // 
            this.txt_GiaHienTai.Location = new System.Drawing.Point(1280, 31);
            this.txt_GiaHienTai.Multiline = true;
            this.txt_GiaHienTai.Name = "txt_GiaHienTai";
            this.txt_GiaHienTai.ReadOnly = true;
            this.txt_GiaHienTai.Size = new System.Drawing.Size(207, 43);
            this.txt_GiaHienTai.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1108, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Giá hiện tại";
            // 
            // txt_TenKichCo
            // 
            this.txt_TenKichCo.Location = new System.Drawing.Point(836, 229);
            this.txt_TenKichCo.Multiline = true;
            this.txt_TenKichCo.Name = "txt_TenKichCo";
            this.txt_TenKichCo.ReadOnly = true;
            this.txt_TenKichCo.Size = new System.Drawing.Size(252, 43);
            this.txt_TenKichCo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tên kích cỡ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbo_TrangThai);
            this.groupBox1.Controls.Add(this.txt_SLTon);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_SLGioiHan);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_NgayKetThuc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_NgayBatDau);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_GiamGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_GiaHienTai);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_TenKichCo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_TenLoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_SLDanhGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_DanhGiaTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ThongTinChiTiet);
            this.groupBox1.Controls.Add(this.txt_MoTa);
            this.groupBox1.Controls.Add(this.txt_TenSP);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1898, 326);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(836, 158);
            this.txt_TenLoai.Multiline = true;
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.ReadOnly = true;
            this.txt_TenLoai.Size = new System.Drawing.Size(252, 43);
            this.txt_TenLoai.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(645, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên phân loại";
            // 
            // txt_SLDanhGia
            // 
            this.txt_SLDanhGia.Location = new System.Drawing.Point(836, 92);
            this.txt_SLDanhGia.Multiline = true;
            this.txt_SLDanhGia.Name = "txt_SLDanhGia";
            this.txt_SLDanhGia.ReadOnly = true;
            this.txt_SLDanhGia.Size = new System.Drawing.Size(133, 43);
            this.txt_SLDanhGia.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng đánh giá";
            // 
            // txt_DanhGiaTB
            // 
            this.txt_DanhGiaTB.Location = new System.Drawing.Point(836, 26);
            this.txt_DanhGiaTB.Multiline = true;
            this.txt_DanhGiaTB.Name = "txt_DanhGiaTB";
            this.txt_DanhGiaTB.ReadOnly = true;
            this.txt_DanhGiaTB.Size = new System.Drawing.Size(133, 43);
            this.txt_DanhGiaTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đánh giá trung bình";
            // 
            // txt_ThongTinChiTiet
            // 
            this.txt_ThongTinChiTiet.Location = new System.Drawing.Point(185, 239);
            this.txt_ThongTinChiTiet.Multiline = true;
            this.txt_ThongTinChiTiet.Name = "txt_ThongTinChiTiet";
            this.txt_ThongTinChiTiet.ReadOnly = true;
            this.txt_ThongTinChiTiet.Size = new System.Drawing.Size(436, 74);
            this.txt_ThongTinChiTiet.TabIndex = 7;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(185, 154);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.ReadOnly = true;
            this.txt_MoTa.Size = new System.Drawing.Size(436, 72);
            this.txt_MoTa.TabIndex = 6;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(185, 97);
            this.txt_TenSP.Multiline = true;
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.ReadOnly = true;
            this.txt_TenSP.Size = new System.Drawing.Size(251, 43);
            this.txt_TenSP.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(184, 37);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(252, 43);
            this.txt_ID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(1582, 577);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(168, 62);
            this.btn_Thoat.TabIndex = 32;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1582, 483);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(168, 62);
            this.btn_Xoa.TabIndex = 31;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(1582, 391);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(168, 62);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.Text = "Cập nhật";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // data_Product
            // 
            this.data_Product.AllowUserToAddRows = false;
            this.data_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Product.BackgroundColor = System.Drawing.Color.White;
            this.data_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Product.Location = new System.Drawing.Point(39, 46);
            this.data_Product.Name = "data_Product";
            this.data_Product.ReadOnly = true;
            this.data_Product.RowHeadersWidth = 62;
            this.data_Product.RowTemplate.Height = 28;
            this.data_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Product.Size = new System.Drawing.Size(1818, 398);
            this.data_Product.TabIndex = 29;
            this.data_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Product_CellClick);
            this.data_Product.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Product_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_Product);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 677);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1898, 466);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1944, 1155);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_Product";
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Product_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_AnhBia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Product)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupImage;
        private System.Windows.Forms.PictureBox p_AnhBia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.TextBox txt_SLTon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_SLGioiHan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_NgayKetThuc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_NgayBatDau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GiaHienTai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TenKichCo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SLDanhGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DanhGiaTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ThongTinChiTiet;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView data_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}