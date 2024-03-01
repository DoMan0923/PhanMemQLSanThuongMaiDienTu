using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShippingMethodDAL : BuildCollectionDAL<phuong_thuc_van_chuyen>
    {
        //public string[] FindByIdsAsString(ObjectId[] ids)
        //{
        //    List<phuong_thuc_van_chuyen> phuong_thuc_van_chuyens = GetByIds(ids);
        //    string[] items = new string[phuong_thuc_van_chuyens.Count];
        //    for (int i = 0; i < items.Length; i++)
        //        items[i] = phuong_thuc_van_chuyens[i].ten_phuong_thuc_van_chuyen + " - " + phuong_thuc_van_chuyens[i]._id.ToString();
        //    return items;
        //}
        ////IMongoQueryable<phuong_thuc_van_chuyen> shippingMethods;
        //public ShippingMethodDAL()
        //{
        //    IMongoCollection<phuong_thuc_van_chuyen> collection = Db.GetCollection<phuong_thuc_van_chuyen>(collectionName);
        //    shippingMethods = from item in collection.AsQueryable() select item;
        //}
        //public IMongoQueryable<phuong_thuc_van_chuyen> All()
        //{
        //    return shippingMethods;
        //}
        //public List<phuong_thuc_van_chuyen> getByIds(ObjectId[] ids)
        //{
        //    var shippingMethodsFilter = from vc in shippingMethods
        //                               where ids.Contains(vc._id)
        //                               select vc;
        //    return shippingMethodsFilter.ToList();
        //}
        public override UpdateDefinition<phuong_thuc_van_chuyen> BuildersUpdate(phuong_thuc_van_chuyen data)
        {
            throw new NotImplementedException();
        }
        DBConnect con = new DBConnect();
        //Mẫn
        public IMongoQueryable<phuong_thuc_van_chuyen> load_Shipp()
        {
            con.connect();
            IMongoCollection<phuong_thuc_van_chuyen> collection = con.connect_Shipp("phuong_thuc_van_chuyen");
            var query = from item in collection.AsQueryable<phuong_thuc_van_chuyen>().Where(s => s.khoa == false || s.khoa == null) select item;
            return query;
        }
        public void insert_Shipp(string tenPT, int thoiGian, int chiPhi, bool macDinh, bool dongKiem, string anh)
        {
            IMongoCollection<phuong_thuc_van_chuyen> collection = con.connect_Shipp("phuong_thuc_van_chuyen");
            var insertShipp = new phuong_thuc_van_chuyen
            {
                ten_phuong_thuc_van_chuyen = tenPT,
                thoi_gian_uoc_tinh = thoiGian,
                chi_phi = chiPhi,
                mac_dinh = macDinh,
                dong_kiem = dongKiem,
                anh_nen = anh
            };
            collection.InsertOne(insertShipp);
        }
        public void update_Ship(ObjectId dieuKien, string tenPT, int thoiGian, bool dongKiem, int chiPhi, bool macDinh, string anh)
        {
            IMongoCollection<phuong_thuc_van_chuyen> collection = con.connect_Shipp("phuong_thuc_van_chuyen");
            var document = Builders<phuong_thuc_van_chuyen>.Filter.Eq("_id", dieuKien);
            var updateShipp = Builders<phuong_thuc_van_chuyen>.Update.Set("ten_phuong_thuc_van_chuyen", tenPT)
                                                .Set("thoi_gian_uoc_tinh", thoiGian)
                                                .Set("chi_phi", chiPhi)
                                                .Set("mac_dinh", macDinh)
                                                .Set("dong_kiem", dongKiem)
                                                .Set("anh_nen", anh);
            var result = collection.UpdateOne(document, updateShipp);
        }
        public void delete_Ship(ObjectId dieuKien, bool khoa)
        {
            IMongoCollection<phuong_thuc_van_chuyen> collection = con.connect_Shipp("phuong_thuc_van_chuyen");
            var document = Builders<phuong_thuc_van_chuyen>.Filter.Eq("_id", dieuKien);
            var updateShipp = Builders<phuong_thuc_van_chuyen>.Update.Set("khoa", khoa);
            var result = collection.UpdateOne(document, updateShipp);
        }
    }
}
