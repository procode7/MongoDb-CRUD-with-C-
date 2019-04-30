using JavaAggregationServer.Helpers;
using JavaAggregationServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaAggregationServer.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    public class RequestController : ControllerBase
    {
       
        private readonly IUmaasRepository _umaasRepository;
        public RequestController(IUmaasRepository umaasRepository)
        {
            _umaasRepository = umaasRepository;
        }

        // POST: api/post
        [HttpPost,Route("post")]
        public async Task<IActionResult> Post([FromBody]JavaData javaData)
        {
            await _umaasRepository.Create(javaData);
            return new OkObjectResult(javaData);
        }

        // GET: api/GetData
        [HttpGet("{org}", Name = "getdata")]
        public async Task<IActionResult> GetGata(string org)
        {
            var orginization = await _umaasRepository.GetData(org);
            if (orginization == null)
                return new NotFoundResult();
            return new ObjectResult(orginization);
        }

    }
}
