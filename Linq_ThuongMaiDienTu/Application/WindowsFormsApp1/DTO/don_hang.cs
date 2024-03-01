using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class don_hang : Collection
    {
        ObjectId Cua_hang_id;
        ObjectId Nguoi_dung_id;
        ObjectId Dia_chi_giao_hang_id;
        DateTime Ngay_dat_hang;        
        string Ma_voucher_cua_hang;
        List<string> Vouchers;
        phuong_thuc_van_chuyen Phuong_thuc_van_chuyen;
        string Phuong_thuc_thanh_toan;
        string Loi_nhan;
        int Phi_van_chuyen;
        giam_gia_don_hang Giam_gia;
        int Thanh_tien;        
        List<chi_tiet_don_hang> Chi_tiet_don_hangs;
        trang_thai_don_hang Trang_thai;

        DateTime Updated_at;

        public ObjectId cua_hang_id { get => Cua_hang_id; set => Cua_hang_id = value; }
        public ObjectId dia_chi_giao_hang_id { get => Dia_chi_giao_hang_id; set => Dia_chi_giao_hang_id = value; }
        public DateTime ngay_dat_hang { get => Ngay_dat_hang; set => Ngay_dat_hang = value; }
        public string ma_voucher_cua_hang { get => Ma_voucher_cua_hang; set => Ma_voucher_cua_hang = value; }
        public List<string> vouchers { get => Vouchers; set => Vouchers = value; }
        public phuong_thuc_van_chuyen phuong_thuc_van_chuyen { get => Phuong_thuc_van_chuyen; set => Phuong_thuc_van_chuyen = value; }
        public string phuong_thuc_thanh_toan { get => Phuong_thuc_thanh_toan; set => Phuong_thuc_thanh_toan = value; }
        public string loi_nhan { get => Loi_nhan; set => Loi_nhan = value; }
        public int phi_van_chuyen { get => Phi_van_chuyen; set => Phi_van_chuyen = value; }
        public int thanh_tien { get => Thanh_tien; set => Thanh_tien = value; }
        public List<chi_tiet_don_hang> chi_tiet_don_hangs { get => Chi_tiet_don_hangs; set => Chi_tiet_don_hangs = value; }
        public trang_thai_don_hang trang_thai { get => Trang_thai; set => Trang_thai = value; }
        public DateTime updated_at { get => Updated_at; set => Updated_at = value; }
        public giam_gia_don_hang giam_gia { get => Giam_gia; set => Giam_gia = value; }
        public ObjectId nguoi_dung_id { get => Nguoi_dung_id; set => Nguoi_dung_id = value; }
    }
}
