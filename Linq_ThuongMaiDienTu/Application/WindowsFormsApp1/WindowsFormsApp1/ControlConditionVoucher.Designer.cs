
namespace WindowsFormsApp1
{
    partial class ControlConditionVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlConditionVoucher));
            this.listBox_doi_tuong = new System.Windows.Forms.ListBox();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.chk_doi_tuong_ap_dung = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_doi_tuong
            // 
            this.listBox_doi_tuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_doi_tuong.FormattingEnabled = true;
            this.listBox_doi_tuong.ItemHeight = 29;
            this.listBox_doi_tuong.Location = new System.Drawing.Point(11, 105);
            this.listBox_doi_tuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_doi_tuong.Name = "listBox_doi_tuong";
            this.listBox_doi_tuong.Size = new System.Drawing.Size(409, 207);
            this.listBox_doi_tuong.TabIndex = 21;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(298, 53);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(121, 32);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(299, 7);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(121, 32);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(4, 38);
            this.combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(270, 37);
            this.combobox.TabIndex = 20;
            // 
            // chk_doi_tuong_ap_dung
            // 
            this.chk_doi_tuong_ap_dung.AutoSize = true;
            this.chk_doi_tuong_ap_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_doi_tuong_ap_dung.Location = new System.Drawing.Point(2, 6);
            this.chk_doi_tuong_ap_dung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_doi_tuong_ap_dung.Name = "chk_doi_tuong_ap_dung";
            this.chk_doi_tuong_ap_dung.Size = new System.Drawing.Size(303, 33);
            this.chk_doi_tuong_ap_dung.TabIndex = 19;
            this.chk_doi_tuong_ap_dung.Text = "Điều kiện theo danh mục";
            this.chk_doi_tuong_ap_dung.UseVisualStyleBackColor = true;
            // 
            // ControlConditionVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox_doi_tuong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.chk_doi_tuong_ap_dung);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControlConditionVoucher";
            this.Size = new System.Drawing.Size(430, 329);
            this.Load += new System.EventHandler(this.ControlConditionVoucher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_doi_tuong;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.CheckBox chk_doi_tuong_ap_dung;
    }
}
