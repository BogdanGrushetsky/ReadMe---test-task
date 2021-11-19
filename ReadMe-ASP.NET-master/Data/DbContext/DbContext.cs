using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbContext
{
    public class DbContext
    {
        private readonly IMongoDatabase _dbContext;

        public DbContext(IMongoClient client,string dbName)
        {
            _dbContext = client.GetDatabase(dbName);
        }
    }
}
