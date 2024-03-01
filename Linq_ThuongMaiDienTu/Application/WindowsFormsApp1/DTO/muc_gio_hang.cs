using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class muc_gio_hang : EmbedCollection
    {
        //[BsonElement("san_pham")]       
        san_pham_gio_hang San_pham;
        int So_luong;

        public san_pham_gio_hang san_pham { get => San_pham; set => San_pham = value; }
        public int so_luong { get => So_luong; set => So_luong = value; }
    }
}
