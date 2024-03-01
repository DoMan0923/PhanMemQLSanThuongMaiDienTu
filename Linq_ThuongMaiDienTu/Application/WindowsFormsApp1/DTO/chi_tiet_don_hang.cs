using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chi_tiet_don_hang : EmbedCollection
    {
        san_pham_don_hang San_pham;
        int Don_gia;
        int So_luong;
        danh_gia_san_pham Danh_gia;

        public int don_gia { get => Don_gia; set => Don_gia = value; }
        public int so_luong { get => So_luong; set => So_luong = value; }
        public san_pham_don_hang san_pham { get => San_pham; set => San_pham = value; }
        public danh_gia_san_pham danh_gia { get => Danh_gia; set => Danh_gia = value; }
    }
}
