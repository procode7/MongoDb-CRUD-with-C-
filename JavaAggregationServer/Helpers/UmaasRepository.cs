using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JavaAggregationServer.Models;
using MongoDB.Driver;

namespace JavaAggregationServer.Helpers
{
    public class UmaasRepository : IUmaasRepository
    {
        private readonly IMongoContext _context;
        public UmaasRepository(IMongoContext context)
        {
            _context = context;
        }

        public async Task Create(JavaData javadata)
        { 
            try
            {
                await _context.JavaData.InsertOneAsync(javadata);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public async Task<JavaData> GetData(string org)
        {
            try
            {
                FilterDefinition<JavaData> filter = Builders<JavaData>.Filter.Eq(m => m.Org, org);
                return await _context
                        .JavaData
                        .Find(filter)
                        .FirstOrDefaultAsync();

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
