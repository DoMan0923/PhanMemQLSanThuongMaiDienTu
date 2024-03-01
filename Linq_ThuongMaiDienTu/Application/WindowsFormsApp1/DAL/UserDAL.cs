using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Driver;

namespace DAL
{
    public class UserDAL : BuildCollectionDAL<nguoi_dung>
    {
        public override UpdateDefinition<nguoi_dung> BuildersUpdate(nguoi_dung data)
        {
            throw new NotImplementedException();
        }
    }
}
