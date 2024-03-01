using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class kich_co_phan_loai : EmbedCollection
    {
        string Ten_kich_co;
        int So_luong_ton;
        int? Gia_hien_tai;

        public string ten_kich_co { get => Ten_kich_co; set => Ten_kich_co = value; }
        public int so_luong_ton { get => So_luong_ton; set => So_luong_ton = value; }
        public int? gia_hien_tai { get => Gia_hien_tai; set => Gia_hien_tai = value; }
    }
}
