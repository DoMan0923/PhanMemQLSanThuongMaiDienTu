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
    public class CategoryMethodDAL
    {
        DBConnect con = new DBConnect();

        //load data
        public List<danh_muc> loadData()
        {
            return con.getDanhMuc("danh_muc");
        }

        public List<danh_muc> loadDanhMucCap1()
        {
            return con.getDanhMucCap1("danh_muc");
        }
        public List<danh_muc> loadDanhMucChild(string idParent)
        {
            return con.getDanhMucCapCon("danh_muc", idParent);
        }

        public List<danh_muc> loadDanhMucByListID(List<string> listID)
        {
            List<danh_muc> a = con.getListDanhMucByListID("danh_muc", listID);
            return a;
        }

        public List<danh_muc> loadDanhMucByID(string id)
        {
            List<danh_muc> a = con.getDanhMucByID("danh_muc", id);
            return a;
        }

        public int InserDanhMuc(danh_muc dm)
        {
            try
            {
                IMongoCollection<danh_muc> collection = con.connect_DanhMuc("danh_muc");
                collection.InsertOne(dm);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteDanhMuc(string id)
        {
            try
            {
                IMongoCollection<danh_muc> collection = con.connect_DanhMuc("danh_muc");
                ObjectId i = ObjectId.TryParse(id, out ObjectId objectId) ? objectId : ObjectId.Empty;
                var document = Builders<danh_muc>.Filter.Eq("_id", i);

                if (con.ktThamChieuSanPham(i) == 0 && con.ktCoDanhMucCon(id) == 0)
                {
                    var result = collection.DeleteOne(document);
                    if (result.DeletedCount > 0)
                    {
                        return 1;
                    }
                }

                return 2;
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateDanhMuc(danh_muc dm)
        {
            //try
            //{
            IMongoCollection<danh_muc> collection = con.connect_DanhMuc("danh_muc");
            var filter = Builders<danh_muc>.Filter.Eq("_id", dm._id);
            var update = Builders<danh_muc>.Update
                .Set("ten_danh_muc", dm.ten_danh_muc)
                .Set("anh_nen", dm.anh_nen)
                .Set("danh_muc_cha_id", dm.danh_muc_cha_id);

            var result = collection.UpdateOne(filter, update);

            if (result.ModifiedCount > 0)
                return 1;

            return 2;
        }
    }
}
