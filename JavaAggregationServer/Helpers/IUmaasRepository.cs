using JavaAggregationServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaAggregationServer.Helpers
{
    public interface IUmaasRepository
    {
        Task Create(JavaData javadata);
        Task<JavaData> GetData(string name);
    }
}
