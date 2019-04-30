using JavaAggregationServer.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaAggregationServer.Helpers
{
    public interface IMongoContext
    {
        IMongoCollection<JavaData> JavaData { get; }
    }
}
