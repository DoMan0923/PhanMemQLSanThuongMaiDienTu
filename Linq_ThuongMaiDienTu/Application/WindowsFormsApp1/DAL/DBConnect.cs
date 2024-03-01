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
    public class DBConnect
    {
        string url;
        //string databaseName;
        protected IMongoDatabase database;
        protected string databaseName;
        protected MongoClient client;
        public void connect()
        {
            databaseName = "ThuongMaiDienTu";
            //string url = "mongodb://root:TMDT12345678@localhost:27018";
            client = new MongoClient("mongodb://root:TMDT12345678@localhost:27018");
        }
        //Mẫn--------------------------------------
        public IMongoCollection<cua_hang> connect_Store(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<cua_hang>(table);
            return collection;
        }
        public IMongoCollection<phuong_thuc_thanh_toan> connect_Pay(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<phuong_thuc_thanh_toan>(table);
            return collection;
        }
        public IMongoCollection<phuong_thuc_van_chuyen> connect_Shipp(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<phuong_thuc_van_chuyen>(table);
            return collection;
        }
        public IMongoCollection<san_pham> connect_Product(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<san_pham>(table);
            return collection;
        }
        public IMongoCollection<thong_tin_chi_tiet> connect_Detail(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<thong_tin_chi_tiet>(table);
            return collection;
        }
        public IMongoCollection<tai_khoan> connect_TaiKhoan(string table)
        {
            database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<tai_khoan>(table);
            return collection;
        }
        //Ánh-------------------------------------------------------------
        public IMongoCollection<danh_muc> connect_DanhMuc(string tableName)
        {
            checkConnect();
            return database.GetCollection<danh_muc>(tableName);
        }

        
        public void checkConnect()
        {
            if (database == null)
            {
                var client = new MongoClient("mongodb://root:TMDT12345678@localhost:27018");
                database = client.GetDatabase("ThuongMaiDienTu");
            }
        }
        public List<danh_muc> getDanhMuc(string tableName)
        {
            checkConnect();
            var collection = database.GetCollection<danh_muc>(tableName);
            List<danh_muc> danhMucs = collection.Find(Builders<danh_muc>.Filter.Empty).ToList();
            return danhMucs;
        }
        public List<danh_muc> getDanhMucCap1(string tableName)
        {
            checkConnect();
            var collection = database.GetCollection<danh_muc>(tableName);

            if (collection == null)
            {
                // Xử lý trường hợp collection là null, có thể hiển thị thông báo lỗi hoặc thực hiện hành động phù hợp.
                Console.WriteLine("Collection is null.");
                return new List<danh_muc>();
            }

            // Tiếp tục với phần còn lại của hàm.
            var filter = Builders<danh_muc>.Filter.In(d => d.danh_muc_cha_id, new List<ObjectId?> { null, ObjectId.Empty });
            List<danh_muc> danhMucs = collection.Find(filter).ToList();
            return danhMucs;


        }

        public List<danh_muc> getDanhMucCapCon(string tableName, string idParent)
        {
            checkConnect();
            ObjectId id = ObjectId.TryParse(idParent, out ObjectId objectId) ? objectId : ObjectId.Empty;
            var collection = database.GetCollection<danh_muc>(tableName);

            var filter = Builders<danh_muc>.Filter.Eq(d => d.danh_muc_cha_id, id);

            List<danh_muc> danhMucs = collection.Find(filter).ToList();

            return danhMucs;
        }

        public List<danh_muc> getListDanhMucByListID(string tableName, List<String> listID)
        {

            checkConnect();
            var objectIds = listID.Select(id => ObjectId.TryParse(id, out ObjectId objectId) ? objectId : ObjectId.Empty);

            var collection = database.GetCollection<danh_muc>(tableName);

            var filter = Builders<danh_muc>.Filter.In(d => d._id, objectIds);

            List<danh_muc> danhMucs = collection.Find(filter).ToList();

            return danhMucs;
        }

        public List<danh_muc> getDanhMucByID(string tableName, string id)
        {
            checkConnect();
            ObjectId i = ObjectId.TryParse(id, out ObjectId objectId) ? objectId : ObjectId.Empty;
            var collection = database.GetCollection<danh_muc>(tableName);

            var filter = Builders<danh_muc>.Filter.Eq(d => d._id, i);

            List<danh_muc> danhMucs = collection.Find(filter).ToList();

            return danhMucs;
        }

        public int ktCoDanhMucCon(string i)
        {
            checkConnect();
            List<danh_muc> kq = getDanhMucCapCon("danh_muc", i);
            if (kq.Count == 0)
            {
                return 0;
            }
            return 1;
        }

        public int ktThamChieuSanPham(ObjectId i)
        {
            checkConnect();
            var filter = Builders<BsonDocument>.Filter.Eq("danh_muc_id", i);
            var count = database.GetCollection<BsonDocument>("san_pham").CountDocuments(filter);
            if (count == 0)
                return 0;
            else return 1;
        }
    }
}
