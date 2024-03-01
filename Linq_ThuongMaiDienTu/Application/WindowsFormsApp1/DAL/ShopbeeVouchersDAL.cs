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
    public class ShopbeeVouchersDAL: BuildCollectionDAL<shopbee_vouchers>
    {      
        public List<voucher> getVoucherDetails()
        {
            List<voucher> vouchers = new List<voucher>();
            foreach (var shopbeeVoucher in this.queryable)
            {
                vouchers.AddRange(shopbeeVoucher.vouchers);
            }
            return vouchers;
        }
        public List<voucher> getVoucherDetails(List<shopbee_vouchers> shopbeeVouchers)
        {
            List<voucher> vouchers = new List<voucher>();
            foreach (var shopbeeVoucher in shopbeeVouchers)
            {
                vouchers.AddRange(shopbeeVoucher.vouchers);
            }
            return vouchers;
        }
        public voucher findByVoucherCode(List<shopbee_vouchers> shopbeeVouchers,string voucherCode)
        {
            List<voucher> vouchers = getVoucherDetails(shopbeeVouchers);
            return vouchers.Where(vc => vc.ma_voucher.Equals(voucherCode)).FirstOrDefault();
        }
        public voucher findByVoucherCode(string voucherCode)
        {
            List<voucher> vouchers = getVoucherDetails();
            return vouchers.Where(vc => vc.ma_voucher.Equals(voucherCode)).FirstOrDefault();
        }
        public List<voucher> getVoucherDetails(List<shopbee_vouchers> shopbeeVouchers,ObjectId _id)
        {
            List<voucher> vouchers = new List<voucher>();
            return shopbeeVouchers.Where(v => v._id.Equals(_id)).FirstOrDefault().vouchers;
        }
        public List<voucher> getVoucherDetails(ObjectId _id)
        {
            List<voucher> vouchers = new List<voucher>();
            return queryable.Where(v => v._id.Equals(_id)).FirstOrDefault().vouchers;
        }        
       
        public shopbee_vouchers FindByVoucherCode(string voucherCode)
        {
            return All().Where(s => s.vouchers.Count(vc => vc.ma_voucher.Equals(voucherCode)) >0).FirstOrDefault();            
        }

        public override UpdateDefinition<shopbee_vouchers> BuildersUpdate(shopbee_vouchers data)
        {
            return Builders<shopbee_vouchers>.Update                            
                        .Set("vouchers", data.vouchers);
            //UpdateDefinition<T> updateMain = update as UpdateDefinition<T>;
            //PropertyInfo[] properties = data.GetType().GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    string propertyName = property.Name;                
            //    if (propertyName != "_id")
            //    {
            //        object propertyValue = property.GetValue(data);
            //        updateMain = updateMain.Set(propertyName, propertyValue);
            //    }                
            //}
    }
        public void Push(shopbee_vouchers shopbeeVoucher, voucher vcher)
        {
            var update = Builders<shopbee_vouchers>.Update
                        .Push("vouchers", vcher);
            var filter = Builders<shopbee_vouchers>.Filter.Eq("_id", shopbeeVoucher._id);
            _collection.UpdateOne(filter, update);
        }
        public void Pull(shopbee_vouchers shopbeeVoucher, string vouchercode)
        {
            voucher voucherUpdate = shopbeeVoucher.vouchers.Where(vc => vc.ma_voucher.Equals(vouchercode)).FirstOrDefault();
            var update = Builders<shopbee_vouchers>.Update
                        .Pull("vouchers", voucherUpdate);
            var filter = Builders<shopbee_vouchers>.Filter.Eq("_id", shopbeeVoucher._id);
            _collection.UpdateOne(filter, update);
        }

        public int UpdateVoucher(shopbee_vouchers shopbeeVouchers, string voucherCodeOld, voucher vcher)
        {
            voucher voucherUpdate = shopbeeVouchers.vouchers.Where(vc => vc.ma_voucher.Equals(voucherCodeOld)).FirstOrDefault();
            if (voucherUpdate == null)
                return -1;
            voucherUpdate.ma_voucher = vcher.ma_voucher;
            voucherUpdate.ten_voucher = vcher.ten_voucher;
            voucherUpdate.ty_le_giam_gia = vcher.ty_le_giam_gia;
            voucherUpdate.don_hang_toi_thieu = vcher.don_hang_toi_thieu;
            voucherUpdate.muc_giam_toi_da = vcher.muc_giam_toi_da;
            voucherUpdate.so_luong = vcher.so_luong;
            voucherUpdate.ngay_bat_dau = vcher.ngay_bat_dau;
            voucherUpdate.ngay_ket_thuc = vcher.ngay_ket_thuc;
            voucherUpdate.doi_tuong_tham_chieu = vcher.doi_tuong_tham_chieu;
            voucherUpdate.danh_mucs = vcher.danh_mucs;
            voucherUpdate.phuong_thuc_van_chuyens = vcher.phuong_thuc_van_chuyens;
            voucherUpdate.phuong_thuc_thanh_toans = vcher.phuong_thuc_thanh_toans;
            voucherUpdate.cua_hangs = vcher.cua_hangs;
            Update(shopbeeVouchers);
            return 1;
        }

        //IMongoQueryable<shopbee_vouchers> shopbeeVouchers;
        //public ShopbeeVouchersDAL()
        //{            
        //    IMongoCollection<shopbee_vouchers> collection = Db.GetCollection<shopbee_vouchers>(collectionName);
        //    shopbeeVouchers = from item in collection.AsQueryable() select item;
        //}   
        //public IMongoQueryable<shopbee_vouchers> All()
        //{            
        //    return shopbeeVouchers;
        //}     




    }
}
