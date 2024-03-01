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
    public class PaymentMethodDAL : BuildCollectionDAL<phuong_thuc_thanh_toan>
    {
        //public string[] FindByIdsAsString(ObjectId[] ids)
        //{
        //    List<phuong_thuc_thanh_toan> phuongThucThanhToans = GetByIds(ids);
        //    string[] items = new string[phuongThucThanhToans.Count];
        //    for (int i = 0; i < items.Length; i++)
        //        items[i] = phuongThucThanhToans[i].ten_phuong_thuc_thanh_toan + " - " + phuongThucThanhToans[i]._id.ToString();
        //    return items;
        //} 

        //IMongoQueryable<phuong_thuc_thanh_toan> paymentMethods;       
        //public PaymentMethodDAL()
        //{
        //    IMongoCollection<phuong_thuc_thanh_toan> collection = Db.GetCollection<phuong_thuc_thanh_toan>(collectionName);
        //    paymentMethods = from item in collection.AsQueryable() select item;
        //}
        //public IMongoQueryable<phuong_thuc_thanh_toan> All()
        //{
        //    return paymentMethods;
        //}
        //public List<phuong_thuc_thanh_toan> getByIds(ObjectId[] ids)
        //{
        //    var paymentMethodsFilter = from tt in paymentMethods
        //                         where ids.Contains(tt._id)
        //                         select tt;
        //    return paymentMethodsFilter.ToList();
        //}

        //Đạt
        public override UpdateDefinition<phuong_thuc_thanh_toan> BuildersUpdate(phuong_thuc_thanh_toan data)
        {
            throw new NotImplementedException();
        }
        //Mẫn
        DBConnect con = new DBConnect();
        public IMongoQueryable<phuong_thuc_thanh_toan> load_Pay()
        {
            con.connect();
            IMongoCollection<phuong_thuc_thanh_toan> collection = con.connect_Pay("phuong_thuc_thanh_toan");
            var query = from item in collection.AsQueryable<phuong_thuc_thanh_toan>().Where(p => p.khoa == false || p.khoa == null) select item;
            return query;
        }
        public void insert_Pay(string tenPT, string anh, bool macDinh)
        {
            IMongoCollection<phuong_thuc_thanh_toan> collection = con.connect_Pay("phuong_thuc_thanh_toan");
            var insertShipp = new phuong_thuc_thanh_toan
            {
                ten_phuong_thuc_thanh_toan = tenPT,
                anh_nen = anh,
                mac_dinh = macDinh
            };
            collection.InsertOne(insertShipp);
        }
        public void update_Pay(ObjectId dieuKien, string tenPT, string tenAnh, bool macDinh)
        {
            IMongoCollection<phuong_thuc_thanh_toan> collection = con.connect_Pay("phuong_thuc_thanh_toan");
            var document = Builders<phuong_thuc_thanh_toan>.Filter.Eq("_id", dieuKien);
            var updateShipp = Builders<phuong_thuc_thanh_toan>.Update.Set("ten_phuong_thuc_thanh_toan", tenPT)
                                                .Set("anh_nen", tenAnh)
                                                .Set("mac_dinh", macDinh);
            var result = collection.UpdateOne(document, updateShipp);
        }
        public void delete_Pay(ObjectId dieuKien, bool khoa)
        {
            IMongoCollection<phuong_thuc_thanh_toan> collection = con.connect_Pay("phuong_thuc_thanh_toan");
            var document = Builders<phuong_thuc_thanh_toan>.Filter.Eq("_id", dieuKien);
            var updateShipp = Builders<phuong_thuc_thanh_toan>.Update.Set("khoa", khoa);

            var result = collection.UpdateOne(document, updateShipp);
        }
    }
}
