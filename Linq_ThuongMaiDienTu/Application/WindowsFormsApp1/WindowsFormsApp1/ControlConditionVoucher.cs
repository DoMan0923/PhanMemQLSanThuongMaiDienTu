using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MongoDB.Bson;

namespace WindowsFormsApp1
{
    public partial class ControlConditionVoucher : UserControl
    {
        string doiTuongThamChieu;
        bool enabled;
        public string DoiTuongThamChieu { get => doiTuongThamChieu; set => doiTuongThamChieu = value; }

        public ControlConditionVoucher()
        {
            InitializeComponent();
            combobox.SelectedIndexChanged += Combobox_SelectedIndexChanged;
            listBox_doi_tuong.SelectedIndexChanged += ListBox_doi_tuong_SelectedIndexChanged;
            btn_them.Click += Btn_them_Click;
            btn_xoa.Click += Btn_xoa_Click;
            chk_doi_tuong_ap_dung.CheckedChanged += Chk_doi_tuong_ap_dung_CheckedChanged;
            combobox.KeyPress += Combobox_KeyPress;
        }

        private void Combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Chk_doi_tuong_ap_dung_CheckedChanged(object sender, EventArgs e)
        {
            setEnabled(chk_doi_tuong_ap_dung.Checked);
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            this.Items.RemoveAt(listBox_doi_tuong.SelectedIndex);
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            string item = combobox.Text + " - " + combobox.SelectedValue.ToString()  ;
            if(!this.Items.Contains(item))
                this.Items.Add(item);
        }

        private void ListBox_doi_tuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_xoa.Enabled = true;
        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;            
        }
        public void Reset(string[] items = null,bool? check = null)
        {
           
            listBox_doi_tuong.Items.Clear();            
            btn_xoa.Enabled = false;            
            if (check != null)
               Enableds = check.Value;
            if (items != null)
            {
                this.Items.AddRange(items);
                btn_them.Enabled = check.Value;
            }
            else
                btn_them.Enabled = false;
        }
        public string Label
        {
            get
            {
                return chk_doi_tuong_ap_dung.Text;
            }
            set
            {
                chk_doi_tuong_ap_dung.Text = value;
            }
        }
        public ListBox.ObjectCollection Items
        {
            get
            {                
                return listBox_doi_tuong.Items;
            }            
        }
        public void SetDataSource(object dataSource,string displayMember, string valueMember)
        {
            this.DataSource = dataSource;
            this.DisplayMember = displayMember;
            this.ValueMember = valueMember;
        }
        public object DataSource
        {
            get
            {
                return combobox.DataSource;
            }
            set
            {
                combobox.DataSource = value;
            }
        }

        public string DisplayMember
        {
            get
            {
                return combobox.DisplayMember;
            }
            set
            {
                combobox.DisplayMember = value;
            }
        }
        
        public string ValueMember
        {
            get
            {
                return combobox.ValueMember;
            }
            set
            {
                combobox.ValueMember = value;
            }
        }
        public bool Enableds
        {
            get
            {
                return enabled;
            }
            set
            {
                chk_doi_tuong_ap_dung.Checked = value;
                enabled = value;
            }
        }
        public bool Checked
        {
            get
            {
                return chk_doi_tuong_ap_dung.Checked;
            }
            set
            {
                chk_doi_tuong_ap_dung.Checked = value;                
            }
        }
        public void setEnabled(bool bol)
        {
            combobox.Enabled = bol;
            listBox_doi_tuong.Enabled = bol;            
            btn_them.Enabled = bol;
            enabled = bol;
        }
        public List<ObjectId> Ids
        {
            get
            {
                List<ObjectId> ids = new List<ObjectId>();
                if(Checked)                
                    foreach (var item in this.Items)
                    {
                        ids.Add(ObjectId.Parse(item.ToString().Split('-')[1].Trim()));
                    }
                return ids;
            }
        }

        private void ControlConditionVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
