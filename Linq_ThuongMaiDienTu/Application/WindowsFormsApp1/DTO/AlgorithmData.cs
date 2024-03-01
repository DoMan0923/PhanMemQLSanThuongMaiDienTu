using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AlgorithmData
    {
        [BsonId]
        ObjectId nguoiDungId;
        DateTime ngayLapTaiKhoan;
        string gioiTinh;
        int tuoi;
        DateTime? thoiDiemTuongTac;
        ObjectId sanPhamId;
        ObjectId cuaHangId;
        DateTime ngayDangKyBanHang;
        string diaChiCuaHang;
        int luotTruyCap;
        string khoaBietHieuPhanLoai;
        string khoaBietHieuKichCo;
        bool? coPhanLoai;
        bool? coKichCo;
        int giaCaoNhat;
        int giaThapNhat;
        double giaTrungBinh;
        ObjectId danhMucId;
        double mucDanhGia;
        int soLuongDanhGia;
        double? giamGia;
        bool? daDatHang;
        //phần này của đặt hàng
        ObjectId donHangId;
        int? soLuongMua;
        string phuongThucVanChuyen;
        int? chiPhiVanChuyen;
        string diaChiGiaoHang;
        string phuongThucThanhToan;
        int? tongGiaTriDonHang;
        bool? apDungKhuyenMaiCuaHang;
        bool? apDungVoucherPhiVanChuyen;
        bool? apDungVoucherDonHang;

        public ObjectId NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public DateTime NgayLapTaiKhoan { get => ngayLapTaiKhoan; set => ngayLapTaiKhoan = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public DateTime? ThoiDiemTuongTac { get => thoiDiemTuongTac; set => thoiDiemTuongTac = value; }
        public ObjectId SanPhamId { get => sanPhamId; set => sanPhamId = value; }
        public ObjectId CuaHangId { get => cuaHangId; set => cuaHangId = value; }
        public DateTime NgayDangKyBanHang { get => ngayDangKyBanHang; set => ngayDangKyBanHang = value; }
        public string DiaChiCuaHang { get => diaChiCuaHang; set => diaChiCuaHang = value; }
        public int LuotTruyCap { get => luotTruyCap; set => luotTruyCap = value; }
        public string KhoaBietHieuPhanLoai { get => khoaBietHieuPhanLoai; set => khoaBietHieuPhanLoai = value; }
        public string KhoaBietHieuKichCo { get => khoaBietHieuKichCo; set => khoaBietHieuKichCo = value; }
        public bool? CoPhanLoai { get => coPhanLoai; set => coPhanLoai = value; }
        public bool? CoKichCo { get => coKichCo; set => coKichCo = value; }
        public double GiaTrungBinh { get => giaTrungBinh; set => giaTrungBinh = value; }
        public ObjectId DanhMucId { get => danhMucId; set => danhMucId = value; }
        public double MucDanhGia { get => mucDanhGia; set => mucDanhGia = value; }
        public int SoLuongDanhGia { get => soLuongDanhGia; set => soLuongDanhGia = value; }
        public double? GiamGia { get => giamGia; set => giamGia = value; }
        public bool? DaDatHang { get => daDatHang; set => daDatHang = value; }
        public ObjectId DonHangId { get => donHangId; set => donHangId = value; }
        public string PhuongThucVanChuyen { get => phuongThucVanChuyen; set => phuongThucVanChuyen = value; }
        public int? ChiPhiVanChuyen { get => chiPhiVanChuyen; set => chiPhiVanChuyen = value; }
        public string DiaChiGiaoHang { get => diaChiGiaoHang; set => diaChiGiaoHang = value; }
        public string PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }
        public int? TongGiaTriDonHang { get => tongGiaTriDonHang; set => tongGiaTriDonHang = value; }
        public bool? ApDungKhuyenMaiCuaHang { get => apDungKhuyenMaiCuaHang; set => apDungKhuyenMaiCuaHang = value; }
        public bool? ApDungVoucherPhiVanChuyen { get => apDungVoucherPhiVanChuyen; set => apDungVoucherPhiVanChuyen = value; }
        public bool? ApDungVoucherDonHang { get => apDungVoucherDonHang; set => apDungVoucherDonHang = value; }
        public int? SoLuongMua { get => soLuongMua; set => soLuongMua = value; }
        public int GiaCaoNhat { get => giaCaoNhat; set => giaCaoNhat = value; }
        public int GiaThapNhat { get => giaThapNhat; set => giaThapNhat = value; }

        public AlgorithmData()
        {

        }

        public AlgorithmData(ObjectId nguoiDungId, DateTime ngayLapTaiKhoan, string gioiTinh, int tuoi, DateTime? thoiDiemTuongTac, ObjectId sanPhamId, ObjectId cuaHangId, DateTime ngayDangKyBanHang, string diaChiCuaHang, int luotTruyCap, string khoaBietHieuPhanLoai, string khoaBietHieuKichCo, bool? coPhanLoai, bool? coKichCo, int giaThapNhat, int giaCaoNhat, double giaTrungBinh, ObjectId danhMucId, double mucDanhGia, int soLuongDanhGia, double? giamGia, bool? daDatHang, ObjectId donHangId, int? soLuongMua, string phuongThucVanChuyen, int? chiPhiVanChuyen, string diaChiGiaoHang, string phuongThucThanhToan, int? tongGiaTriDonHang, bool? apDungKhuyenMaiCuaHang, bool? apDungVoucherPhiVanChuyen, bool? apDungVoucherDonHang)
        {
            this.NguoiDungId = nguoiDungId;
            this.NgayLapTaiKhoan = ngayLapTaiKhoan;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
            this.ThoiDiemTuongTac = thoiDiemTuongTac;
            this.SanPhamId = sanPhamId;
            this.CuaHangId = cuaHangId;
            this.NgayDangKyBanHang = ngayDangKyBanHang;
            this.DiaChiCuaHang = diaChiCuaHang;
            this.LuotTruyCap = luotTruyCap;
            this.KhoaBietHieuPhanLoai = khoaBietHieuPhanLoai;
            this.KhoaBietHieuKichCo = khoaBietHieuKichCo;
            this.CoPhanLoai = coPhanLoai;
            this.CoKichCo = coKichCo;
            this.GiaTrungBinh = giaTrungBinh;
            this.DanhMucId = danhMucId;
            this.MucDanhGia = mucDanhGia;
            this.SoLuongDanhGia = soLuongDanhGia;
            this.GiamGia = giamGia;
            this.DaDatHang = daDatHang;

            this.DonHangId = donHangId;
            this.PhuongThucVanChuyen = phuongThucVanChuyen;
            this.ChiPhiVanChuyen = chiPhiVanChuyen;
            this.DiaChiGiaoHang = diaChiGiaoHang;
            this.PhuongThucThanhToan = phuongThucThanhToan;
            this.SoLuongMua = soLuongMua;
            this.TongGiaTriDonHang = tongGiaTriDonHang;
            this.ApDungKhuyenMaiCuaHang = apDungKhuyenMaiCuaHang;
            this.ApDungVoucherPhiVanChuyen = apDungVoucherPhiVanChuyen;
            this.ApDungVoucherDonHang = apDungVoucherDonHang;
            this.GiaThapNhat = giaThapNhat;
            this.GiaCaoNhat = giaCaoNhat;
        }

        public void setData(ObjectId nguoiDungId, DateTime ngayLapTaiKhoan, string gioiTinh, int tuoi, DateTime? thoiDiemTuongTac, ObjectId sanPhamId, ObjectId cuaHangId, DateTime ngayDangKyBanHang, string diaChiCuaHang, int luotTruyCap, string khoaBietHieuPhanLoai, string khoaBietHieuKichCo, bool? coPhanLoai, bool? coKichCo, int giaThapNhat, int giaCaoNhat, double giaTrungBinh, ObjectId danhMucId, double mucDanhGia, int soLuongDanhGia, double? giamGia)
        {
            this.NguoiDungId = nguoiDungId;
            this.NgayLapTaiKhoan = ngayLapTaiKhoan;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
            this.ThoiDiemTuongTac = thoiDiemTuongTac;
            this.SanPhamId = sanPhamId;
            this.CuaHangId = cuaHangId;
            this.NgayDangKyBanHang = ngayDangKyBanHang;
            this.DiaChiCuaHang = diaChiCuaHang;
            this.LuotTruyCap = luotTruyCap;
            this.KhoaBietHieuPhanLoai = khoaBietHieuPhanLoai;
            this.KhoaBietHieuKichCo = khoaBietHieuKichCo;
            this.CoPhanLoai = coPhanLoai;
            this.CoKichCo = coKichCo;
            this.GiaTrungBinh = giaTrungBinh;
            this.DanhMucId = danhMucId;
            this.MucDanhGia = mucDanhGia;
            this.SoLuongDanhGia = soLuongDanhGia;
            this.GiamGia = giamGia;
            this.GiaThapNhat = giaThapNhat;
            this.GiaCaoNhat = giaCaoNhat;
        }

        public AlgorithmData(ObjectId nguoiDungId, DateTime ngayLapTaiKhoan, string gioiTinh, int tuoi, DateTime? thoiDiemTuongTac, ObjectId sanPhamId, ObjectId cuaHangId, DateTime ngayDangKyBanHang, string diaChiCuaHang, int luotTruyCap, string khoaBietHieuPhanLoai, string khoaBietHieuKichCo, bool? coPhanLoai, bool? coKichCo, int giaThapNhat, int giaCaoNhat, double giaTrungBinh, ObjectId danhMucId, double mucDanhGia, int soLuongDanhGia, double? giamGia, bool? daDatHang)
        {
            this.NguoiDungId = nguoiDungId;
            this.NgayLapTaiKhoan = ngayLapTaiKhoan;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
            this.ThoiDiemTuongTac = thoiDiemTuongTac;
            this.SanPhamId = sanPhamId;
            this.CuaHangId = cuaHangId;
            this.NgayDangKyBanHang = ngayDangKyBanHang;
            this.DiaChiCuaHang = diaChiCuaHang;
            this.LuotTruyCap = luotTruyCap;
            this.KhoaBietHieuPhanLoai = khoaBietHieuPhanLoai;
            this.KhoaBietHieuKichCo = khoaBietHieuKichCo;
            this.CoPhanLoai = coPhanLoai;
            this.CoKichCo = coKichCo;
            this.GiaTrungBinh = giaTrungBinh;
            this.DanhMucId = danhMucId;
            this.MucDanhGia = mucDanhGia;
            this.SoLuongDanhGia = soLuongDanhGia;
            this.GiamGia = giamGia;
            this.DaDatHang = daDatHang;
            this.GiaThapNhat = giaThapNhat;
            this.GiaCaoNhat = giaCaoNhat;
        }

        public AlgorithmData(ObjectId nguoiDungId, DateTime ngayLapTaiKhoan, string gioiTinh, int tuoi, DateTime? thoiDiemTuongTac, ObjectId sanPhamId, ObjectId cuaHangId, DateTime ngayDangKyBanHang, string diaChiCuaHang, int luotTruyCap, string khoaBietHieuPhanLoai, string khoaBietHieuKichCo, bool? coPhanLoai, bool? coKichCo, int giaThapNhat, int giaCaoNhat, double giaTrungBinh, ObjectId danhMucId, double mucDanhGia, int soLuongDanhGia, double? giamGia)
        {
            this.NguoiDungId = nguoiDungId;
            this.NgayLapTaiKhoan = ngayLapTaiKhoan;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
            this.ThoiDiemTuongTac = thoiDiemTuongTac;
            this.SanPhamId = sanPhamId;
            this.CuaHangId = cuaHangId;
            this.NgayDangKyBanHang = ngayDangKyBanHang;
            this.DiaChiCuaHang = diaChiCuaHang;
            this.LuotTruyCap = luotTruyCap;
            this.KhoaBietHieuPhanLoai = khoaBietHieuPhanLoai;
            this.KhoaBietHieuKichCo = khoaBietHieuKichCo;
            this.CoPhanLoai = coPhanLoai;
            this.CoKichCo = coKichCo;
            this.GiaTrungBinh = giaTrungBinh;
            this.DanhMucId = danhMucId;
            this.MucDanhGia = mucDanhGia;
            this.SoLuongDanhGia = soLuongDanhGia;
            this.GiamGia = giamGia;
            this.GiaThapNhat = giaThapNhat;
            this.GiaCaoNhat = giaCaoNhat;
        }


        public AlgorithmData(AlgorithmData algorithmData)
        {
            this.NguoiDungId = algorithmData.NguoiDungId;
            this.NgayLapTaiKhoan = algorithmData.NgayLapTaiKhoan;
            this.GioiTinh = algorithmData.GioiTinh;
            this.Tuoi = algorithmData.Tuoi;
            this.ThoiDiemTuongTac = algorithmData.ThoiDiemTuongTac;
            this.SanPhamId = algorithmData.SanPhamId;
            this.CuaHangId = algorithmData.CuaHangId;
            this.NgayDangKyBanHang = algorithmData.NgayDangKyBanHang;
            this.DiaChiCuaHang = algorithmData.DiaChiCuaHang;
            this.LuotTruyCap = algorithmData.LuotTruyCap;
            this.KhoaBietHieuPhanLoai = algorithmData.KhoaBietHieuPhanLoai;
            this.KhoaBietHieuKichCo = algorithmData.KhoaBietHieuKichCo;
            this.CoPhanLoai = algorithmData.CoPhanLoai;
            this.CoKichCo = algorithmData.CoKichCo;
            this.GiaTrungBinh = algorithmData.GiaTrungBinh;
            this.DanhMucId = algorithmData.DanhMucId;
            this.MucDanhGia = algorithmData.MucDanhGia;
            this.SoLuongDanhGia = algorithmData.SoLuongDanhGia;
            this.GiamGia = algorithmData.GiamGia;
            this.DaDatHang = algorithmData.DaDatHang;

            this.DonHangId = algorithmData.DonHangId;
            this.PhuongThucVanChuyen = algorithmData.PhuongThucVanChuyen;
            this.ChiPhiVanChuyen = algorithmData.ChiPhiVanChuyen;
            this.DiaChiGiaoHang = algorithmData.DiaChiGiaoHang;
            this.PhuongThucThanhToan = algorithmData.PhuongThucThanhToan;
            this.SoLuongMua = algorithmData.SoLuongMua;
            this.TongGiaTriDonHang = algorithmData.TongGiaTriDonHang;
            this.ApDungKhuyenMaiCuaHang = algorithmData.ApDungKhuyenMaiCuaHang;
            this.ApDungVoucherPhiVanChuyen = algorithmData.ApDungVoucherPhiVanChuyen;
            this.ApDungVoucherDonHang = algorithmData.ApDungVoucherDonHang;
            this.GiaThapNhat = algorithmData.GiaThapNhat;
            this.GiaCaoNhat = algorithmData.GiaCaoNhat;
        }

        public void Print()
        {
            Console.Write(this.NguoiDungId + " ");
            Console.Write(this.NgayLapTaiKhoan + " ");
            Console.Write(this.GioiTinh + " ");
            Console.Write(this.Tuoi + " ");
            Console.Write(this.ThoiDiemTuongTac + " ");
            Console.Write(this.SanPhamId + " ");
            Console.Write(this.CuaHangId + " ");
            Console.Write(this.NgayDangKyBanHang + " ");
            Console.Write(this.DiaChiCuaHang + " ");
            Console.Write(this.LuotTruyCap + " ");
            Console.Write(this.KhoaBietHieuPhanLoai + " ");
            Console.Write(this.KhoaBietHieuKichCo + " ");
            Console.Write(this.CoPhanLoai + " ");

            //this.CoKichCo = coKichCo;
            //this.GiaTrungBinh = giaTrungBinh;
            //this.DanhMucId = danhMucId;
            //this.MucDanhGia = mucDanhGia;
            //this.SoLuongDanhGia = soLuongDanhGia;
            //this.GiamGia = giamGia;
            //this.DaDatHang = daDatHang;

            //this.DonHangId = donHangId;
            //this.PhuongThucVanChuyenId = phuongThucVanChuyenId;
            //this.ChiPhiVanChuyen = chiPhiVanChuyen;
            //this.DiaChiGiaoHang = diaChiGiaoHang;
            //this.PhuongThucThanhToanId = phuongThucThanhToanId;
            //this.SoLuongMua = soLuongMua;
            //this.TongGiaTriDonHang = tongGiaTriDonHang;
            //this.ApDungKhuyenMaiCuaHang = apDungKhuyenMaiCuaHang;
            //this.ApDungVoucherPhiVanChuyen = apDungVoucherPhiVanChuyen;
            //this.ApDungVoucherDonHang = apDungVoucherDonHang;
            //this.GiaThapNhat = giaThapNhat;
            //this.GiaCaoNhat = giaCaoNhat;
            Console.WriteLine("\n\n\n");
        }

    }
}
