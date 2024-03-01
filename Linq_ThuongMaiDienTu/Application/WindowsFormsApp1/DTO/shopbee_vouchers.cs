using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class shopbee_vouchers : Collection
    {       
        public string loai_voucher { get; set; }
        public string loai_chi_phi_ap_dung { get; set; }
        public List<voucher> vouchers { get; set; }
        public DateTime updated_at { get; set; }
    }
}
