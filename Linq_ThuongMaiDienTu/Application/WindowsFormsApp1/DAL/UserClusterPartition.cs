using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Statistics.Filters;
using DTO;
using MongoDB.Bson;
using System.Numerics;
using Accord.MachineLearning;
using Accord.Math.Distances;

namespace DAL
{
    public class UserClusterPartition
    {
        UserDAL userDAL = new UserDAL();
        OrderDAL orderDAL = new OrderDAL();
        StoreDAL storeDAL = new StoreDAL();
        ProductMethodDAL productDAL = new ProductMethodDAL();



        public double[][] StandardizedData()
        {
            List<AlgorithmData> algorithmDatas = OriginSetUp();
            DataTable data = new DataTable("algorithmDatas");
            // Lấy danh sách thuộc tính trong đối tượng AlgorithmData
            PropertyInfo[] properties = typeof(AlgorithmData).GetProperties();
            List<string> names = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                data.Columns.Add(property.Name);
                names.Add(property.Name);
            }
            foreach (AlgorithmData algorithmData in algorithmDatas)
            {
                List<object> objects = new List<object>();
                foreach (PropertyInfo property in properties)
                {
                    object propertyValue = property.GetValue(algorithmData);
                    //if (!IsNumericType(property))
                    if (propertyValue == null || propertyValue == DBNull.Value)
                        objects.Add(0);
                    else
                        objects.Add(propertyValue);
                }
                data.Rows.Add(objects.ToArray());
            }
            var codebook = new Codification(data);
            DataTable symbols = codebook.Apply(data);
            double[][] observations = symbols.ToArray<double>();
            int[] outputs = Kmeans(observations);
            return observations;
        }
        public int[] Kmeans(double[][] observations)
        {
            KMeans kmeans = new KMeans(k: 4);
            //{
            //    Distance = new WeightedSquareEuclidean(new double[] { 1, 0.5, 0.1 })
            //};

            var clusters = kmeans.Learn(observations);
            return clusters.Decide(observations);
        }

        private bool IsNumericType(PropertyInfo property)
        {
            Type type = property.PropertyType;
            if (type == typeof(int) || type == typeof(double) || type == typeof(float) || type == typeof(decimal))
            {
                return true;
            }

            // Nếu muốn hỗ trợ thêm các kiểu số khác, bạn có thể mở rộng danh sách kiểm tra ở đây.

            return false;
        }

        public List<AlgorithmData> OriginSetUp(int numberDay = 3, int timesLoop = 3)
        {
            DateTime toDay = DateTime.Now;
            List<AlgorithmData> algorithmDatas = new List<AlgorithmData>();
            foreach (var user in userDAL.All().ToList())
            {
                int tuoi = toDay.Year - user.ngay_sinh.Year;
                List<ObjectId> checkProductsOrder = new List<ObjectId>();
                List<don_hang> donHangs = orderDAL.All().Where(odder => user.so_dia_chi.Count(sdc => sdc.id.Equals(odder.dia_chi_giao_hang_id)) > 0)
                    .OrderByDescending(tt => tt.ngay_dat_hang).Where(tt => tt.ngay_dat_hang.AddYears(numberDay) >= toDay).ToList();
                foreach (don_hang donHang in donHangs)
                {
                    string diaChiGiaoHang = user.so_dia_chi.Where(diaChi => diaChi.id.Equals(donHang.dia_chi_giao_hang_id)).FirstOrDefault().dia_chi;
                    bool apDungKhuyenMaiCuaHang = donHang.ma_voucher_cua_hang != null;
                    bool apDungVoucherPhiVanChuyen = false;
                    bool apDungVoucherDonHang = false;
                    if (donHang.giam_gia != null)
                    {
                        apDungVoucherPhiVanChuyen = donHang.giam_gia.phuong_thuc_van_chuyen > 0;
                        apDungVoucherDonHang = donHang.giam_gia.don_hang > 0;
                    }
                    foreach (chi_tiet_don_hang chiTietDonHang in donHang.chi_tiet_don_hangs)
                    {
                        checkProductsOrder.Add(chiTietDonHang.san_pham.san_pham_id);
                        san_pham sanPham = productDAL.Find(chiTietDonHang.san_pham.san_pham_id);
                        cua_hang cuaHang = storeDAL.All().Where(ch => ch._id.Equals(sanPham.CuaHangID)).FirstOrDefault();
                        bool hasClassify = sanPham.phan_loais != null && sanPham.phan_loais.Count > 0;
                        bool hasSize = hasClassify && sanPham.phan_loais.Where(pl => pl.kich_co_phan_loais != null && pl.kich_co_phan_loais.Count > 0).FirstOrDefault() != null;
                        double avgPrice = productDAL.getAveragePrice(sanPham, out int max, out int min);
                        AlgorithmData algorithmData = new AlgorithmData(user._id, user.ngay_tao,
                            user.gioi_tinh, tuoi, null, chiTietDonHang.san_pham.san_pham_id,
                            cuaHang._id, cuaHang.ngay_dang_ky, cuaHang.dia_chi, cuaHang.luot_truy_cap,
                            sanPham.doi_ten_phan_loai, sanPham.doi_ten_kich_co, hasClassify, hasSize,
                            min, max, avgPrice, sanPham.DanhMucID, sanPham.danh_gia, sanPham.so_luong_danh_gia, sanPham.giam_gia, true,
                            donHang._id, chiTietDonHang.so_luong, donHang.phuong_thuc_van_chuyen.ten_phuong_thuc_van_chuyen, donHang.phi_van_chuyen, diaChiGiaoHang,
                            donHang.phuong_thuc_thanh_toan, donHang.thanh_tien, apDungKhuyenMaiCuaHang, apDungVoucherPhiVanChuyen, apDungVoucherDonHang);
                        algorithmDatas.Add(algorithmData);
                    }
                }
                if (user.tuong_tacs != null && user.tuong_tacs.Count > 0)
                {
                    List<ObjectId> checkProducts = new List<ObjectId>();
                    List<tuong_tac> tuongTacs = user.tuong_tacs.OrderByDescending(tt => tt.thoi_gian).ToList();
                    tuongTacs = tuongTacs.Where(tt => tt.thoi_gian.AddYears(numberDay) >= toDay).ToList();
                    foreach (tuong_tac tuongTac in tuongTacs)
                    {
                        if (checkProducts.Count(id => id.Equals(tuongTac.san_pham_id)) < timesLoop)
                        {
                            san_pham sanPham = productDAL.Find(tuongTac.san_pham_id);
                            cua_hang cuaHang = storeDAL.All().Where(ch => ch._id.Equals(sanPham.CuaHangID)).FirstOrDefault();
                            bool hasClassify = sanPham.phan_loais != null && sanPham.phan_loais.Count > 0;
                            bool hasSize = hasClassify && sanPham.phan_loais.Where(pl => pl.kich_co_phan_loais != null && pl.kich_co_phan_loais.Count > 0).FirstOrDefault() != null;
                            double avgPrice = productDAL.getAveragePrice(sanPham, out int max, out int min);
                            bool checkAdd = checkProductsOrder.Where(id => id.Equals(tuongTac.san_pham_id)).FirstOrDefault() != null;
                            AlgorithmData algorithmData = new AlgorithmData(user._id, user.ngay_tao, user.gioi_tinh, tuoi, tuongTac.thoi_gian, tuongTac.san_pham_id, cuaHang._id, cuaHang.ngay_dang_ky, cuaHang.dia_chi, tuongTac.luot_truy_cap_cua_hang_hien_tai, sanPham.doi_ten_phan_loai, sanPham.doi_ten_kich_co, hasClassify, hasSize, tuongTac.gia_thap_nhat, tuongTac.gia_cao_nhat, avgPrice, sanPham.DanhMucID, tuongTac.danh_gia_hien_tai, tuongTac.so_luong_danh_gia_hien_tai, tuongTac.giam_gia_hien_tai, checkAdd);
                            algorithmDatas.Add(algorithmData);
                        }
                    }
                }
            }
            return algorithmDatas;
        }

    }
}
