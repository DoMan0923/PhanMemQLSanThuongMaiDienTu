using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tai_khoan: Collection
    {
        public string ten_nhan_vien { get; set; }
        public string gioi_tinh { get; set; }
        public string dia_chi { get; set; }
        public DateTime ngay_sinh { get; set; }
        public string ten_dang_nhap { get; set; }
        public string mat_khau { get; set; }
        public string chuc_vu { get; set; }
    }
}
