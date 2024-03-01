using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dia_chi_giao_hang : EmbedCollection
    {
        [BsonId]
        ObjectId Id;
        string Ten_nguoi_nhan;
        string Dia_chi;
        string Dia_chi_cu_the;
        string So_dien_thoai;
        string Loai_dia_chi;
        string Ghi_chu;
        bool Mac_dinh;

        public ObjectId id { get => Id; set => Id = value; }
        public string ten_nguoi_nhan { get => Ten_nguoi_nhan; set => Ten_nguoi_nhan = value; }
        public string dia_chi { get => Dia_chi; set => Dia_chi = value; }
        public string dia_chi_cu_the { get => Dia_chi_cu_the; set => Dia_chi_cu_the = value; }
        public string so_dien_thoai { get => So_dien_thoai; set => So_dien_thoai = value; }
        public string loai_dia_chi { get => Loai_dia_chi; set => Loai_dia_chi = value; }
        public bool mac_dinh { get => Mac_dinh; set => Mac_dinh = value; }
        public string ghi_chu { get => Ghi_chu; set => Ghi_chu = value; }
    }
}
