using DTO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBConnection:DBConnect
    {
        public DBConnection()
        {
            connect();
            database = client.GetDatabase(databaseName);
        }
        public IMongoCollection<T> GetCollection<T>(string table) where T : Collection
        {
            IMongoCollection<T> derivedCollection = database.GetCollection<T>(table);
            return derivedCollection;
        }
    }
}
