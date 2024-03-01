using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class san_pham: Collection
    {        
        [BsonElement("cua_hang_id")]
        public ObjectId CuaHangID { get; set; }
        public bool khoa { get; set; }
        public bool trang_thai
        {
            get; set;
        }
        public string ten_san_pham { get; set; }
        public string anh_bia { get; set; }
        [BsonElement("danh_muc_id")]
        public ObjectId DanhMucID { get; set; }
        public string mo_ta { get; set; }
        //[BsonElement("thong_tin_chi_tiet")]
        public thong_tin_chi_tiet thong_tin_chi_tiet { get; set; }
        public double danh_gia { get; set; }
        public int so_luong_danh_gia { get; set; }
        public string doi_ten_phan_loai { get; set; }
        public string doi_ten_kich_co { get; set; }
        public int? gia_hien_tai { get; set; }
        public List<phan_loai> phan_loais { get; set; }
        public double? giam_gia { get; set; }
        public DateTime ngay_bat_dau { get; set; }
        public DateTime ngay_ket_thuc { get; set; }
        public int? so_luong_gioi_han { get; set; }
        public int? so_luong_ton { get; set; }
        public List<string> anh_san_phams { get; set; }
        public string video { get; set; }
        public DateTime updated_at { get; set; }
    }
}
