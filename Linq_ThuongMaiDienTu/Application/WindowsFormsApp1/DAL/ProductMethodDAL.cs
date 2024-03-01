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
    public class ProductMethodDAL : BuildCollectionDAL<san_pham>
    {
        DBConnect con = new DBConnect();

        //load all
        public IMongoQueryable<san_pham> load_Product()
        {
            con.connect();
            IMongoCollection<san_pham> collection = con.connect_Product("san_pham");
            var query = from item in collection.AsQueryable<san_pham>().Where(p => p.khoa == false || p.khoa == null) select item;
            return query;
        }
        public void delete_Product(ObjectId dieuKien, bool khoa)
        {
            IMongoCollection<san_pham> collection = con.connect_Product("san_pham");
            var document = Builders<san_pham>.Filter.Eq("_id", dieuKien);
            var updateProduct = Builders<san_pham>.Update.Set("khoa", khoa);

            var result = collection.UpdateOne(document, updateProduct);
        }
        public void update_Product(ObjectId dieuKien, bool trangThai)
        {
            IMongoCollection<san_pham> collection = con.connect_Product("san_pham");
            var document = Builders<san_pham>.Filter.Eq("_id", dieuKien);
            var updateProduct = Builders<san_pham>.Update.Set("trang_thai", trangThai);

            var result = collection.UpdateOne(document, updateProduct);
        }
        public double getAveragePrice(san_pham sanPham, out int max, out int min)
        {
            int length = 0;
            int totalPrice = 0;
            max = -1;
            min = Int32.MaxValue;
            if (sanPham.gia_hien_tai != null)
            {
                totalPrice += sanPham.gia_hien_tai.Value;
                length++;
                max = max < sanPham.gia_hien_tai.Value ? sanPham.gia_hien_tai.Value : max;
                min = min > sanPham.gia_hien_tai.Value ? sanPham.gia_hien_tai.Value : min;
            }
            if (sanPham.phan_loais != null)
                foreach (phan_loai phanLoai in sanPham.phan_loais)
                {
                    if (phanLoai.gia_hien_tai != null)
                    {
                        totalPrice += phanLoai.gia_hien_tai.Value;
                        length++;
                        max = max < phanLoai.gia_hien_tai.Value ? phanLoai.gia_hien_tai.Value : max;
                        min = min > phanLoai.gia_hien_tai.Value ? phanLoai.gia_hien_tai.Value : min;
                    }
                    if (phanLoai.kich_co_phan_loais != null)
                        foreach (kich_co_phan_loai kichCoPhanLoai in phanLoai.kich_co_phan_loais)
                            if (kichCoPhanLoai.gia_hien_tai != null)
                            {
                                totalPrice += kichCoPhanLoai.gia_hien_tai.Value;
                                length++;
                                max = max < kichCoPhanLoai.gia_hien_tai.Value ? kichCoPhanLoai.gia_hien_tai.Value : max;
                                min = min > kichCoPhanLoai.gia_hien_tai.Value ? kichCoPhanLoai.gia_hien_tai.Value : min;
                            }
                }
            return (totalPrice * 1.0) / length;
        }
        public override UpdateDefinition<san_pham> BuildersUpdate(san_pham data)
        {
            throw new NotImplementedException();
        }
    }
}
