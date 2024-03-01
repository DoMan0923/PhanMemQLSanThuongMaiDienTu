using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace DAL
{
    public class CategoryDAL : BuildCollectionDAL<danh_muc>
    {
        //public string[] FindByIdsAsString(ObjectId[] ids)
        //{
        //    List<danh_muc> danh_mucs = GetByIds(ids);
        //    string[] items = new string[danh_mucs.Count];
        //    for (int i = 0; i < items.Length; i++)
        //        items[i] = danh_mucs[i].ten_danh_muc + " - " + danh_mucs[i]._id.ToString();
        //    return items;
        //}
        //IMongoQueryable<danh_muc> danh_mucs;
        //public CategoryDAL()
        //{
        //    IMongoCollection<danh_muc> collection = Db.GetCollection<danh_muc>(collectionName);
        //    danh_mucs = from item in collection.AsQueryable() select item;
        //}
        //public IMongoQueryable<danh_muc> All()
        //{
        //    return danh_mucs;
        //}       

        //public List<danh_muc> getByIds(ObjectId[] ids)
        //{
        //    var danhMucFilters = from dm in danh_mucs
        //                         where ids.Contains(dm._id)
        //                         select dm;
        //    return danhMucFilters.ToList();
        //}
        public override UpdateDefinition<danh_muc> BuildersUpdate(danh_muc data)
        {
            throw new NotImplementedException();
        }
    }
}
