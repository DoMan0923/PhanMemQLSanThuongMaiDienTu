using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class voucher : EmbedCollection
    {
        //[BsonId]
        //ObjectId _id;
        //public ObjectId Id { get => _id; set => _id = value; }
        public string ma_voucher { get; set; }
        string Ten_voucher;     
        public string ten_voucher
        {
            get
            {
                if (Ten_voucher == null)
                    return "";
                return Ten_voucher;
            }
            set
            {
                Ten_voucher = value;
            }
        }
        public double ty_le_giam_gia { get; set; }
        public int don_hang_toi_thieu { get; set; }
        public int muc_giam_toi_da { get; set; }
        public int so_luong { get; set; }        
        public DateTime ngay_bat_dau { get; set; }
        public DateTime ngay_ket_thuc { get; set; }
        List<string> Doi_tuong_tham_chieu;
        public List<string> doi_tuong_tham_chieu
        {
            get
            {
                if (Doi_tuong_tham_chieu == null)
                    return new List<string>();
                return Doi_tuong_tham_chieu;
            }
            set
            {
                Doi_tuong_tham_chieu = value;
            }
        }
        List<ObjectId> Danh_mucs;
        public List<ObjectId> danh_mucs
        {
            get
            {
                if (Danh_mucs == null)
                    return new List<ObjectId>();
                return Danh_mucs;
            }
            set
            {
                Danh_mucs = value;
            }
        }
        List<ObjectId> Phuong_thuc_van_chuyens;
        public List<ObjectId> phuong_thuc_van_chuyens
        {
            get
            {
                if (Phuong_thuc_van_chuyens == null)
                    return new List<ObjectId>();
                return Phuong_thuc_van_chuyens;
            }
            set
            {
                Phuong_thuc_van_chuyens = value;
            }
        }
        List<ObjectId> Phuong_thuc_thanh_toans;
        public List<ObjectId> phuong_thuc_thanh_toans
        {
            get
            {
                if (Phuong_thuc_thanh_toans == null)
                    return new List<ObjectId>();
                return Phuong_thuc_thanh_toans;
            }
            set
            {
                Phuong_thuc_thanh_toans = value;
            }
        }
        private List<ObjectId> Cua_hangs;
        public List<ObjectId> cua_hangs
        { 
            get
            {
                if (Cua_hangs == null)
                    return new List<ObjectId>();
                return Cua_hangs;
            }
            set
            {
                Cua_hangs = value;
            }
        }


        public string doi_tuong_tham_chieu_str
        {
            get
            {
                if (doi_tuong_tham_chieu == null)
                    return "Không áp dụng điều kiện";
                string data = "";
                foreach (var doi_tuong in doi_tuong_tham_chieu)
                {
                    data += doi_tuong.ToString() + ", ";
                }
                return data;
            }
        }
        public string danh_mucs_str
        {
            get
            {

                if (doi_tuong_tham_chieu != null && doi_tuong_tham_chieu.Where(dt => dt.Equals("danh_muc")).FirstOrDefault() != null)
                {
                    if (danh_mucs == null)
                        return null;
                    string data = "";

                    foreach (var id in danh_mucs)
                    {
                        data += id.ToString() + ", ";
                    }
                    return data;
                }
                return "Không sử dụng";
            }
        }
        public string phuong_thuc_van_chuyens_str
        {
            get
            {

                if (doi_tuong_tham_chieu != null && doi_tuong_tham_chieu.Where(dt => dt.Equals("phuong_thuc_van_chuyen")).FirstOrDefault() != null)
                {
                    if (phuong_thuc_van_chuyens == null)
                        return null;
                    string data = "";

                    foreach (var id in phuong_thuc_van_chuyens)
                    {
                        data += id.ToString() + ", ";
                    }
                    return data;
                }
                return "Không sử dụng";
            }
        }
        public string phuong_thuc_thanh_toans_str
        {
            get
            {
                if (doi_tuong_tham_chieu != null && doi_tuong_tham_chieu.Where(dt => dt.Equals("phuong_thuc_thanh_toan")).FirstOrDefault() != null)
                {
                    if (phuong_thuc_thanh_toans == null)
                        return null;
                    string data = "";
                    foreach (var id in phuong_thuc_thanh_toans)
                    {
                        data += id.ToString() + ", ";
                    }
                    return data;
                }
                return "Không sử dụng";
            }
        }
        public string cua_hangs_str
        {
            get
            {
                if(doi_tuong_tham_chieu !=null && doi_tuong_tham_chieu.Where(dt=>dt.Equals("cua_hang")).FirstOrDefault()!=null)
                {
                    if (Cua_hangs == null)
                        return "Chưa có cửa hàng đăng ký";
                    string data = "";
                    foreach (var id in Cua_hangs)
                    {
                        data += id.ToString() + ", ";
                    }
                    return data;
                }
                return "Không sử dụng";
            }
        }


    }
}
