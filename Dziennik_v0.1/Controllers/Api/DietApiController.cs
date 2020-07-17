using Dziennik_v0._1.Core.Models;
using Newtonsoft.Json;
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
            List<FoodModel> foods = new List<FoodModel>();
            string csvData = System.IO.File.ReadAllText("D:/Dziennik_v0.1/Dziennik_v0.1/App_Data/TabeleKaloryczne.csv");

            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    foods.Add(new FoodModel
                    {
                        Name = row.Split('.')[0],
                        Calories = Convert.ToInt32(row.Split('.')[1]),
                        Protein = Convert.ToDecimal(row.Split('.')[2]),
                        Fat = Convert.ToDecimal(row.Split('.')[3]),
                        Carbohydrates = Convert.ToDecimal(row.Split('.')[4]),
                    });
                }
            }
                var jsonResault = JsonConvert.SerializeObject(foods);
            return Json(jsonResault);
        }
    }
}
