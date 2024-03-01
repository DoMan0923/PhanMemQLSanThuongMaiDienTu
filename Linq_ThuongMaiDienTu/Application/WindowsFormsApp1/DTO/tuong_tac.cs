using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tuong_tac : EmbedCollection
    {
        DateTime Thoi_gian;
        ObjectId San_pham_id;
        int Gia_thap_nhat;
        int Gia_cao_nhat;        
        double Danh_gia_hien_tai;        
        int So_luong_danh_gia_hien_tai;
        double Giam_gia_hien_tai;
        int Luot_truy_cap_cua_hang_hien_tai;
        public DateTime thoi_gian { get => Thoi_gian; set => Thoi_gian = value; }
        public ObjectId san_pham_id { get => San_pham_id; set => San_pham_id = value; }
        public int gia_thap_nhat { get => Gia_thap_nhat; set => Gia_thap_nhat = value; }
        public int gia_cao_nhat { get => Gia_cao_nhat; set => Gia_cao_nhat = value; }
        public double danh_gia_hien_tai { get => Danh_gia_hien_tai; set => Danh_gia_hien_tai = value; }
        public int so_luong_danh_gia_hien_tai { get => So_luong_danh_gia_hien_tai; set => So_luong_danh_gia_hien_tai = value; }
        public double giam_gia_hien_tai { get => Giam_gia_hien_tai; set => Giam_gia_hien_tai = value; }
        public int luot_truy_cap_cua_hang_hien_tai { get => Luot_truy_cap_cua_hang_hien_tai; set => Luot_truy_cap_cua_hang_hien_tai = value; }
    }
}
