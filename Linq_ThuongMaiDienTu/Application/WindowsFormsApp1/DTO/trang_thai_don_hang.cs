using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class trang_thai_don_hang : EmbedCollection
    {        
        DateTime Cho_xac_nhan;
        
        DateTime Dang_xu_ly;        
        DateTime Dang_giao;        
        DateTime Da_giao;
        string Da_huy;
        string Bi_tu_choi;

        [BsonElement("Chờ xác nhận")]
        public DateTime cho_xac_nhan { get => Cho_xac_nhan; set => Cho_xac_nhan = value; }
        [BsonElement("Đang xử lý")]
        public DateTime dang_xu_ly { get => Dang_xu_ly; set => Dang_xu_ly = value; }
        [BsonElement("Đang giao")]
        public DateTime dang_giao { get => Dang_giao; set => Dang_giao = value; }
        [BsonElement("Đã giao")]
        public DateTime da_giao { get => Da_giao; set => Da_giao = value; }
        [BsonElement("Đã hủy")]
        public string da_huy { get => Da_huy; set => Da_huy = value; }
        [BsonElement("Bị từ chối")]
        public string bi_tu_choi { get => Bi_tu_choi; set => Bi_tu_choi = value; }
    }
}
