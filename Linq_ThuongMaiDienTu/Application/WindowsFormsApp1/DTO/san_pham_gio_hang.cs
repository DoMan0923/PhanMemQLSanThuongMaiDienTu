using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class san_pham_gio_hang : EmbedCollection
    {
        [BsonId]
        ObjectId San_pham_id;
        string Ten_san_pham;
        string Ten_phan_loai;
        string Ten_kich_co;
        int Gia_hien_tai;
        ObjectId Danh_muc_id;
        double Giam_gia;
        DateTime Ngay_bat_dau;
        DateTime Ngay_ket_thuc;
        int So_luong_gioi_han;        
        public ObjectId san_pham_id { get => San_pham_id; set => San_pham_id = value; }
        public string ten_phan_loai { get => Ten_phan_loai; set => Ten_phan_loai = value; }
        public string ten_kich_co { get => Ten_kich_co; set => Ten_kich_co = value; }
        public int gia_hien_tai { get => Gia_hien_tai; set => Gia_hien_tai = value; }
        public ObjectId danh_muc_id { get => Danh_muc_id; set => Danh_muc_id = value; }
        public double giam_gia { get => Giam_gia; set => Giam_gia = value; }
        public DateTime ngay_bat_dau { get => Ngay_bat_dau; set => Ngay_bat_dau = value; }
        public DateTime ngay_ket_thuc { get => Ngay_ket_thuc; set => Ngay_ket_thuc = value; }
        public int so_luong_gioi_han { get => So_luong_gioi_han; set => So_luong_gioi_han = value; }
        public string ten_san_pham { get => Ten_san_pham; set => Ten_san_pham = value; }
    }
}
