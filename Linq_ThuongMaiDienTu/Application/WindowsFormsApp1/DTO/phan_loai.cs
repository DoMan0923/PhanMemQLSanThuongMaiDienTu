using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phan_loai : EmbedCollection
    {
        string Ten_phan_loai;
        int? So_luong_ton;
        int? Gia_hien_tai;
        string Doi_ten_kich_co;
        string Anh_phan_loai;
        List<kich_co_phan_loai> Kich_co_phan_loais;
        public string ten_phan_loai { get => Ten_phan_loai; set => Ten_phan_loai = value; }
        public int? so_luong_ton { get => So_luong_ton; set => So_luong_ton = value; }
        public int? gia_hien_tai { get => Gia_hien_tai; set => Gia_hien_tai = value; }
        public string doi_ten_kich_co { get => Doi_ten_kich_co; set => Doi_ten_kich_co = value; }
        public List<kich_co_phan_loai> kich_co_phan_loais { get => Kich_co_phan_loais; set => Kich_co_phan_loais = value; }
        public string anh_phan_loai { get => Anh_phan_loai; set => Anh_phan_loai = value; }
    }
}
