using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nguoi_dung : Collection
    {
        string Ten_dang_nhap;
        string Ho_ten;
        string So_dien_thoai;
        string Email;
        DateTime Ngay_sinh;
        string Gioi_tinh;
        string Mat_khau;
        DateTime Ngay_tao;
        DateTime Created_at;
        DateTime Updated_at;
        string Anh_dai_dien;
        //[BsonElement("so_dia_chi")]
        List<dia_chi_giao_hang> So_dia_chi;
        //[BsonElement("gio_hang")]
        List<muc_gio_hang> Gio_hang;
        //[BsonElement("tuong_tacs")]
        List<tuong_tac> Tuong_tacs;
        public string ten_dang_nhap { get => Ten_dang_nhap; set => Ten_dang_nhap = value; }
        public string ho_ten { get => Ho_ten; set => Ho_ten = value; }
        public string so_dien_thoai { get => So_dien_thoai; set => So_dien_thoai = value; }
        public string email { get => Email; set => Email = value; }
        public DateTime ngay_sinh { get => Ngay_sinh; set => Ngay_sinh = value; }
        public string gioi_tinh { get => Gioi_tinh; set => Gioi_tinh = value; }
        public string mat_khau { get => Mat_khau; set => Mat_khau = value; }
        public DateTime ngay_tao { get => Ngay_tao; set => Ngay_tao = value; }
        public List<muc_gio_hang> gio_hang { get => Gio_hang; set => Gio_hang = value; }
        public List<dia_chi_giao_hang> so_dia_chi { get => So_dia_chi; set => So_dia_chi = value; }
        public List<tuong_tac> tuong_tacs { get => Tuong_tacs; set => Tuong_tacs = value; }
        public DateTime updated_at { get => Updated_at; set => Updated_at = value; }
        public string anh_dai_dien { get => Anh_dai_dien; set => Anh_dai_dien = value; }
        public DateTime created_at { get => Created_at; set => Created_at = value; }
    }
}
