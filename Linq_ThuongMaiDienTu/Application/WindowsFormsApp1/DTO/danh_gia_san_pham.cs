using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class danh_gia_san_pham : EmbedCollection
    {
        DateTime Ngay_danh_gia;
        int Muc_do_hai_long;
        string Noi_dung;
        bool An_danh;

        public DateTime ngay_danh_gia { get => Ngay_danh_gia; set => Ngay_danh_gia = value; }
        public int muc_do_hai_long { get => Muc_do_hai_long; set => Muc_do_hai_long = value; }
        public string noi_dung { get => Noi_dung; set => Noi_dung = value; }
        public bool an_danh { get => An_danh; set => An_danh = value; }
    }
}
