using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dziennik_v0._1.Controllers.Api
{
    public class DietApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetFoodData()
        {
            string csvData = System.IO.File.ReadAllText("D:/Dziennik_v0.1/Dziennik_v0.1/App_Data/TabeleKaloryczne.csv");
            return Ok(csvData);
        }
    }
}
