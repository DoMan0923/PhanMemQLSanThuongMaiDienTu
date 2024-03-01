using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Driver;

namespace DAL
{
    public class OrderDAL : BuildCollectionDAL<don_hang>
    {
        public override UpdateDefinition<don_hang> BuildersUpdate(don_hang data)
        {
            throw new NotImplementedException();
        }
    }
}
