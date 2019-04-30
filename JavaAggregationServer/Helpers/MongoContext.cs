using JavaAggregationServer.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaAggregationServer.Helpers
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoDatabase _db;
        public MongoContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<JavaData> JavaData => _db.GetCollection<JavaData>("UMaaS");
    }
}
