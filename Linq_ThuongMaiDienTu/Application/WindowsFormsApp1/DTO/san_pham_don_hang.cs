using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class san_pham_don_hang : EmbedCollection
    {
        ObjectId San_pham_id;
        string Ten_phan_loai;
        string Ten_kich_co;

        public ObjectId san_pham_id { get => San_pham_id; set => San_pham_id = value; }
        public string ten_phan_loai { get => Ten_phan_loai; set => Ten_phan_loai = value; }
        public string ten_kich_co { get => Ten_kich_co; set => Ten_kich_co = value; }
    }
}
