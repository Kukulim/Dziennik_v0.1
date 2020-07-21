﻿using Dziennik_v0._1.Core;
using Dziennik_v0._1.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Dziennik_v0._1.Controllers.Api
{
    public class DietApiController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public DietApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IHttpActionResult GetFoodData(string search=null)
        {
            List<FoodModel> foods = new List<FoodModel>();
            string csvData = System.IO.File.ReadAllText("D:/Dziennik_v0.1/Dziennik_v0.1/App_Data/TabeleKaloryczne.csv", Encoding.GetEncoding("Windows-1250"));

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
            if (search!=null)
            {
                var upperCaseSearch = char.ToUpper(search[0]) + search.Substring(1);
                var result = foods.Where(f => f.Name.Contains(search) || f.Name.Contains(upperCaseSearch)).ToList();
                return Json(result);
            }

            return Json(foods);
        }
        [HttpPost]
        public IHttpActionResult AddFood(FoodModel foodData)
        {
            decimal calculateWeight(decimal FoodComponent)
            {
                return (FoodComponent * foodData.Weight) / 100;
            }
            FoodModel food = new FoodModel
            {
                Name = foodData.Name,
                Calories = (int)calculateWeight(foodData.Calories),
                Protein = calculateWeight(foodData.Protein),
                Fat = calculateWeight(foodData.Fat),
                Carbohydrates = calculateWeight(foodData.Carbohydrates),
                MealType = foodData.MealType,
                Weight = foodData.Weight,
                DailyMenuId = foodData.DailyMenuId
            };

            _unitOfWork.Foods.AddFoodModel(food);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
