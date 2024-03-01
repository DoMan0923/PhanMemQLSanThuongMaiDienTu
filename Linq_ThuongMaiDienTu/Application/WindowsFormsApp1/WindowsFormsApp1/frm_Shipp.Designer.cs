
namespace WindowsFormsApp1
{
    partial class frm_Shipp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Shipp));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.p_Anh = new System.Windows.Forms.PictureBox();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.cbo_MacDinh = new System.Windows.Forms.ComboBox();
            this.cbo_DongKiem = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_ChiPhi = new System.Windows.Forms.TextBox();
            this.txt_TG = new System.Windows.Forms.TextBox();
            this.txt_TenPT = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_Shipp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.p_Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Shipp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // p_Anh
            // 
            this.p_Anh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.p_Anh.Location = new System.Drawing.Point(1358, 60);
            this.p_Anh.Name = "p_Anh";
            this.p_Anh.Size = new System.Drawing.Size(527, 368);
            this.p_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Anh.TabIndex = 41;
            this.p_Anh.TabStop = false;
            // 
            // btn_Chon
            // 
            this.btn_Chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Image = ((System.Drawing.Image)(resources.GetObject("btn_Chon.Image")));
            this.btn_Chon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chon.Location = new System.Drawing.Point(1696, 452);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(189, 62);
            this.btn_Chon.TabIndex = 40;
            this.btn_Chon.Text = "Chọn ảnh";
            this.btn_Chon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // cbo_MacDinh
            // 
            this.cbo_MacDinh.FormattingEnabled = true;
            this.cbo_MacDinh.Items.AddRange(new object[] {
            "Mặc định",
            "Không"});
            this.cbo_MacDinh.Location = new System.Drawing.Point(869, 168);
            this.cbo_MacDinh.Name = "cbo_MacDinh";
            this.cbo_MacDinh.Size = new System.Drawing.Size(262, 37);
            this.cbo_MacDinh.TabIndex = 39;
            // 
            // cbo_DongKiem
            // 
            this.cbo_DongKiem.FormattingEnabled = true;
            this.cbo_DongKiem.Items.AddRange(new object[] {
            "Được đồng kiểm",
            "Không được đồng kiểm"});
            this.cbo_DongKiem.Location = new System.Drawing.Point(869, 259);
            this.cbo_DongKiem.Name = "cbo_DongKiem";
            this.cbo_DongKiem.Size = new System.Drawing.Size(262, 37);
            this.cbo_DongKiem.TabIndex = 38;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(905, 452);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 54);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(747, 452);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(134, 54);
            this.btn_Thoat.TabIndex = 36;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(590, 452);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(134, 54);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(433, 452);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(134, 54);
            this.btn_Xoa.TabIndex = 34;
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
            this.btn_Them.Location = new System.Drawing.Point(274, 452);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(134, 54);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_ChiPhi
            // 
            this.txt_ChiPhi.Location = new System.Drawing.Point(869, 69);
            this.txt_ChiPhi.Multiline = true;
            this.txt_ChiPhi.Name = "txt_ChiPhi";
            this.txt_ChiPhi.Size = new System.Drawing.Size(272, 50);
            this.txt_ChiPhi.TabIndex = 32;
            // 
            // txt_TG
            // 
            this.txt_TG.Location = new System.Drawing.Point(249, 264);
            this.txt_TG.Multiline = true;
            this.txt_TG.Name = "txt_TG";
            this.txt_TG.Size = new System.Drawing.Size(135, 41);
            this.txt_TG.TabIndex = 31;
            // 
            // txt_TenPT
            // 
            this.txt_TenPT.Location = new System.Drawing.Point(249, 174);
            this.txt_TenPT.Multiline = true;
            this.txt_TenPT.Name = "txt_TenPT";
            this.txt_TenPT.Size = new System.Drawing.Size(346, 47);
            this.txt_TenPT.TabIndex = 30;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(249, 78);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(346, 50);
            this.txt_ID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Đồng kiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mặc định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Chi phí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thời gian ước tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên phương thức";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // data_Shipp
            // 
            this.data_Shipp.AllowUserToAddRows = false;
            this.data_Shipp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Shipp.BackgroundColor = System.Drawing.Color.White;
            this.data_Shipp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Shipp.Location = new System.Drawing.Point(34, 43);
            this.data_Shipp.MultiSelect = false;
            this.data_Shipp.Name = "data_Shipp";
            this.data_Shipp.ReadOnly = true;
            this.data_Shipp.RowHeadersWidth = 62;
            this.data_Shipp.RowTemplate.Height = 28;
            this.data_Shipp.Size = new System.Drawing.Size(1777, 346);
            this.data_Shipp.TabIndex = 22;
            this.data_Shipp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Shipp_CellClick);
            this.data_Shipp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Shipp_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenPT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_MacDinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_DongKiem);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_TG);
            this.groupBox1.Controls.Add(this.txt_ChiPhi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1275, 377);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phương thức vận chuyển";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_Shipp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1849, 414);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phương thức vận chuyển";
            // 
            // frm_Shipp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1903, 946);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.p_Anh);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Shipp";
            this.Text = "Phương thức vận chuyển";
            this.Load += new System.EventHandler(this.frm_Shipp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Shipp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox p_Anh;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.ComboBox cbo_MacDinh;
        private System.Windows.Forms.ComboBox cbo_DongKiem;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_ChiPhi;
        private System.Windows.Forms.TextBox txt_TG;
        private System.Windows.Forms.TextBox txt_TenPT;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_Shipp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}