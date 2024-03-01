using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class giam_gia_don_hang : EmbedCollection
    {
        int Phuong_thuc_van_chuyen;
        int Don_hang;

        public int phuong_thuc_van_chuyen { get => Phuong_thuc_van_chuyen; set => Phuong_thuc_van_chuyen = value; }
        public int don_hang { get => Don_hang; set => Don_hang = value; }
    }
}
