using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaAggregationServer.Models
{
    public class JavaData
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime RequestTime { get; set; }
        public String Org { get; set; }
    }
}
