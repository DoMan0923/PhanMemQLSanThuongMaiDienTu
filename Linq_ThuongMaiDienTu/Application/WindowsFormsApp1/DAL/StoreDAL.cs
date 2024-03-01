using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using DTO;
using MongoDB.Bson;
namespace DAL
{
    public class StoreDAL : BuildCollectionDAL<cua_hang>
    {
        DBConnect con = new DBConnect();

        //load all
        public IMongoQueryable<cua_hang> load_Store()
        {
            con.connect();
            IMongoCollection<cua_hang> collection = con.connect_Store("cua_hang");
            var query = from item in collection.AsQueryable<cua_hang>().Where(s => s.khoa == false || s.khoa == null) select item;
            return query;
        }
        //update hoạt động
        public void update_Store(ObjectId dieuKien, bool giaTri)
        {
            IMongoCollection<cua_hang> collection = con.connect_Store("cua_hang");
            var document = Builders<cua_hang>.Filter.Eq("_id", dieuKien);
            var update = Builders<cua_hang>.Update.Set("trang_thai_hoat_dong", giaTri);
            var result = collection.UpdateOne(document, update);
        }
        public void delete_Store(ObjectId dieuKien, bool giaTri)
        {
            IMongoCollection<cua_hang> collection = con.connect_Store("cua_hang");
            var document = Builders<cua_hang>.Filter.Eq("_id", dieuKien);
            var update = Builders<cua_hang>.Update.Set("khoa", giaTri);
            var result = collection.UpdateOne(document, update);
        }

        public override UpdateDefinition<cua_hang> BuildersUpdate(cua_hang data)
        {
            throw new NotImplementedException();
        }
    }
}
