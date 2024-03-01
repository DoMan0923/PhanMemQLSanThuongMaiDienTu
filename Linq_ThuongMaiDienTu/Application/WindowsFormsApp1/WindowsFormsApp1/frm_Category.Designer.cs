
namespace WindowsFormsApp1
{
    partial class frm_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category));
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.btn_Sua58 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cbo_DanhMucCha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.txt_TenDanhMuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDanhMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.dgv_right = new System.Windows.Forms.DataGridView();
            this.dgv_left = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonAnh.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChonAnh.Image")));
            this.btn_ChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChonAnh.Location = new System.Drawing.Point(1714, 400);
            this.btn_ChonAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(172, 59);
            this.btn_ChonAnh.TabIndex = 35;
            this.btn_ChonAnh.Text = "Chọn ảnh";
            this.btn_ChonAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // btn_Sua58
            // 
            this.btn_Sua58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua58.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua58.Image")));
            this.btn_Sua58.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua58.Location = new System.Drawing.Point(999, 282);
            this.btn_Sua58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua58.Name = "btn_Sua58";
            this.btn_Sua58.Size = new System.Drawing.Size(165, 59);
            this.btn_Sua58.TabIndex = 34;
            this.btn_Sua58.Text = "Sửa";
            this.btn_Sua58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua58.UseVisualStyleBackColor = true;
            this.btn_Sua58.Click += new System.EventHandler(this.btn_Sua58_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(999, 187);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(165, 59);
            this.btn_Xoa.TabIndex = 33;
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
            this.btn_Them.Location = new System.Drawing.Point(999, 88);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(165, 59);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbo_DanhMucCha
            // 
            this.cbo_DanhMucCha.FormattingEnabled = true;
            this.cbo_DanhMucCha.Location = new System.Drawing.Point(237, 258);
            this.cbo_DanhMucCha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_DanhMucCha.Name = "cbo_DanhMucCha";
            this.cbo_DanhMucCha.Size = new System.Drawing.Size(445, 37);
            this.cbo_DanhMucCha.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Danh mục cha";
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptb_HinhAnh.Location = new System.Drawing.Point(1469, 41);
            this.ptb_HinhAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(417, 330);
            this.ptb_HinhAnh.TabIndex = 29;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // txt_TenDanhMuc
            // 
            this.txt_TenDanhMuc.Location = new System.Drawing.Point(237, 163);
            this.txt_TenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenDanhMuc.Multiline = true;
            this.txt_TenDanhMuc.Name = "txt_TenDanhMuc";
            this.txt_TenDanhMuc.Size = new System.Drawing.Size(445, 41);
            this.txt_TenDanhMuc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên danh mục";
            // 
            // txt_MaDanhMuc
            // 
            this.txt_MaDanhMuc.Location = new System.Drawing.Point(237, 76);
            this.txt_MaDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaDanhMuc.Multiline = true;
            this.txt_MaDanhMuc.Name = "txt_MaDanhMuc";
            this.txt_MaDanhMuc.ReadOnly = true;
            this.txt_MaDanhMuc.Size = new System.Drawing.Size(398, 40);
            this.txt_MaDanhMuc.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Image = ((System.Drawing.Image)(resources.GetObject("btn_GoBack.Image")));
            this.btn_GoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GoBack.Location = new System.Drawing.Point(22, 400);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(165, 59);
            this.btn_GoBack.TabIndex = 24;
            this.btn_GoBack.Text = "Quay lại";
            this.btn_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // dgv_right
            // 
            this.dgv_right.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_right.BackgroundColor = System.Drawing.Color.White;
            this.dgv_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_right.Location = new System.Drawing.Point(977, 43);
            this.dgv_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_right.MultiSelect = false;
            this.dgv_right.Name = "dgv_right";
            this.dgv_right.ReadOnly = true;
            this.dgv_right.RowHeadersWidth = 62;
            this.dgv_right.RowTemplate.Height = 28;
            this.dgv_right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_right.Size = new System.Drawing.Size(871, 423);
            this.dgv_right.TabIndex = 23;
            this.dgv_right.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_right_CellContentClick);
            // 
            // dgv_left
            // 
            this.dgv_left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_left.BackgroundColor = System.Drawing.Color.White;
            this.dgv_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_left.Location = new System.Drawing.Point(40, 43);
            this.dgv_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_left.MultiSelect = false;
            this.dgv_left.Name = "dgv_left";
            this.dgv_left.ReadOnly = true;
            this.dgv_left.RowHeadersWidth = 62;
            this.dgv_left.RowTemplate.Height = 28;
            this.dgv_left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_left.Size = new System.Drawing.Size(877, 423);
            this.dgv_left.TabIndex = 22;
            this.dgv_left.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_left_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaDanhMuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TenDanhMuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_DanhMucCha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 340);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_left);
            this.groupBox2.Controls.Add(this.dgv_right);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1890, 498);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1945, 1004);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ChonAnh);
            this.Controls.Add(this.btn_Sua58);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_Category";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frm_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.Button btn_Sua58;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbo_DanhMucCha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.TextBox txt_TenDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.DataGridView dgv_right;
        private System.Windows.Forms.DataGridView dgv_left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}