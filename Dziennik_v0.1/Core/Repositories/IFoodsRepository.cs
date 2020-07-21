using Dziennik_v0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Core.Repositories
{
    public interface IFoodsRepository
    {
        FoodModel GetFoodModel(int FoodModelId);
        IEnumerable<FoodModel> GetAllFoodModels(int Id);

        void AddFoodModel(FoodModel FoodModel);
        void DeleteFoodModel(int id);
        void EditCardio(FoodModel FoodModel);
    }
}