using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cua_hang : Collection
    {

        //[BsonId]
        //ObjectId _id;
        [BsonElement("nguoi_dung_id")]
        public ObjectId NguoiDungId { get; set; }
        public List<khuyen_mai> khuyen_mais { get; set; }
        public string ten_cua_hang { get; set; }
        public string dia_chi { get; set; }
        public DateTime ngay_dang_ky { get; set; }
        public string so_dien_thoai { get; set; }
        public string chu_ky { get; set; }
        public int luot_truy_cap { get; set; }
        public bool trang_thai_hoat_dong { get; set; }
        public bool khoa
        {
            get; set;
        }
        public string remember_token { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }

    }
}
