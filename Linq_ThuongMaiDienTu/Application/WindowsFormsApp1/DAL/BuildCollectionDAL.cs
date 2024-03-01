using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Reflection;

namespace DAL
{
    public abstract class BuildCollectionDAL<T> where T : Collection
    {
        protected IMongoQueryable<T> queryable;
        protected readonly IMongoCollection<T> _collection;
        static DBConnection db = null;
        public static string collectionName;
        internal DBConnection Db { get => db; set => db = value; }
        public BuildCollectionDAL()
        {
            Db = new DBConnection();
            //collectionName = getColectionName();
            collectionName = typeof(T).Name;
            _collection = Db.GetCollection<T>(collectionName);
            queryable = from item in _collection.AsQueryable() select item;            
        }
        public IMongoQueryable<T> All()
        {
            return queryable;
        }
        public T Find(ObjectId id)
        {
            return All().ToList().Where(svc => svc._id.Equals(id)).FirstOrDefault();

        }
        public T Find(string id)
        {
            return Find(ObjectId.Parse(id));
        }
        public List<T> GetByIds(List<ObjectId> ids)
        {
            if (ids == null)
                return null;
            var dataFilter = from dt in queryable
                                        where ids.Contains(dt._id)
                                        select dt;
            return dataFilter.ToList();
        }
        public List<T> GetNotByIds(List<ObjectId> ids)
        {
            var dataFilter = from dt in queryable
                                        where !ids.Contains(dt._id)
                                        select dt;            
            return dataFilter != null ? dataFilter.ToList() : null;
        }

        public string[] FindByIdsAsString(List<ObjectId> ids, string propName = null)
        {
            if (ids == null)
                return null;
            if (propName == null)
                propName = "ten_"+ collectionName;
            List<T> colections = GetByIds(ids);
            string[] items = new string[colections.Count];
            for (int i = 0; i < items.Length; i++)
            {
                PropertyInfo propInfo = colections[i].GetType().GetProperty(propName);
                string name = propInfo != null ? propInfo.GetValue(colections[i]).ToString() : "";
                items[i] = name + " - " + colections[i]._id.ToString();
            }
            return items;
        }

        public void Insert(T data)
        {
            _collection.InsertOne(data);
        }

        public void Insert(List<T> datas)
        {
            _collection.InsertMany(datas);
        }       
        public void Update(T data)
        {
            var filter = Builders<T>.Filter.Eq("_id", data._id);
            var update = BuildersUpdate(data);
            //var update = Builders<T>.Update;
            //UpdateDefinition<T> updateMain = update as UpdateDefinition<T>;
            //PropertyInfo[] properties = data.GetType().GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    string propertyName = property.Name;                
            //    if (propertyName != "_id")
            //    {
            //        object propertyValue = property.GetValue(data);
            //        updateMain = updateMain.Set(propertyName, propertyValue);
            //    }                
            //}
            _collection.UpdateOne(filter, update);
        }
        public abstract UpdateDefinition<T> BuildersUpdate(T data);

        public void Delete(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq("_id", id);
            _collection.DeleteOne(filter);
        }
        public void Delete(T data)
        {
            Delete(data._id);
        }
        public void Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            _collection.DeleteOne(filter);
        }
    }
}
