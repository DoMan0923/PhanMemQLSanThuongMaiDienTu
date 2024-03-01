using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phuong_thuc_van_chuyen : Collection
    {
        public string ten_phuong_thuc_van_chuyen { get; set; }
        public int thoi_gian_uoc_tinh { get; set; }
        public int chi_phi { get; set; }
        public bool mac_dinh { get; set; }
        public bool dong_kiem { get; set; }
        public string hinh_anh { get; set; }
        public string anh_nen { get; set; }
        public bool khoa
        {
            get;set;
        }
    }
}
