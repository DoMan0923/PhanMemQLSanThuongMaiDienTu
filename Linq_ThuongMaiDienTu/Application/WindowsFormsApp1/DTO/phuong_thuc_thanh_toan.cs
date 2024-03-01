using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phuong_thuc_thanh_toan : Collection
    {
        //public string ten_phuong_thuc_thanh_toan { get; set; }
        //public string anh_nen { get; set; }
        //public bool mac_dinh { get; set; }
        //public bool khoa { get; set; }
        public string ten_phuong_thuc_thanh_toan { get; set; }
        public string anh_nen { get; set; }
        public bool mac_dinh { get; set; }
        public bool khoa
        {
            get; set;
            //get
            //{
            //    if (khoa == null)
            //        return false;
            //    return khoa;
            //}
            //set { }

        }
    }
}
