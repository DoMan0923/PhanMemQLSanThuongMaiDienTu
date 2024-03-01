using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class thong_tin_chi_tiet
    {

        [BsonExtraElements]
        public Dictionary<string, object> ExtraElements { get; set; }
    }
}
