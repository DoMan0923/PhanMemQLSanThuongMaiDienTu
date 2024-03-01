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
    public class LoginMethodDAL
    {
        DBConnect con = new DBConnect();
        //Load combobox
        public IMongoQueryable<string> load_ChucVu()
        {
            con.connect();
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var query = from item in collection.AsQueryable<tai_khoan>() select item.chuc_vu;
            return query;
        }
        public IMongoQueryable<tai_khoan> load_TaiKhoan()
        {
            con.connect();
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var query = from item in collection.AsQueryable<tai_khoan>()select item;
            return query;
        }
        public IMongoQueryable<tai_khoan> load_TaiKhoanChucVu(string tendn)
        {
            con.connect();
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var query = from item in collection.AsQueryable<tai_khoan>().Where(x => x.ten_dang_nhap == tendn) select item;
            return query;
        }
        public void insert_Employee(string tenNV, string gioiTinh, string diaChi, DateTime ngaySinh, string tendn, string mk, string cv)
        {
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var insertTaiKhoan = new tai_khoan
            {
                ten_nhan_vien = tenNV,
                gioi_tinh = gioiTinh,
                dia_chi = diaChi,
                ngay_sinh = ngaySinh,
                ten_dang_nhap = tendn,
                mat_khau = mk,
                chuc_vu = cv
            };
            collection.InsertOne(insertTaiKhoan);
        }
        public void update_Employee(ObjectId dieuKien, string tennv, string gioiTinh, string diaChi, DateTime ngaySinh, string tendn, string mk, string cv)
        {
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var document = Builders<tai_khoan>.Filter.Eq("_id", dieuKien);
            var updateShipp = Builders<tai_khoan>.Update.Set("ten_nhan_vien", tennv)
                                                .Set("gioi_tinh", gioiTinh)
                                                .Set("dia_chi", diaChi)
                                                .Set("ngay_sinh", ngaySinh)
                                                .Set("ten_dang_nhap", tendn)
                                                .Set("mat_khau", mk)
                                                .Set("chuc_vu", cv);
            var result = collection.UpdateOne(document, updateShipp);
        }
        public void delete_Employee(ObjectId id)
        {
            IMongoCollection<tai_khoan> collection = con.connect_TaiKhoan("tai_khoan");
            var document = Builders<tai_khoan>.Filter.Eq("_id", id);
            var deleteEmployee = collection.AsQueryable().Where(x => x._id == id);
            var result = collection.DeleteOne(document);
        }
    }
}
