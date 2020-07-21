using Dziennik_v0._1.Core.Models;
using Dziennik_v0._1.Core.Repositories;
using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.Repositories
{
    public class FoodsRepository : IFoodsRepository
    {
        private ApplicationDbContext context;

        public FoodsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddFoodModel(FoodModel FoodModel)
        {
            context.Foods.Add(FoodModel);
        }

        public void DeleteFoodModel(int id)
        {
            var FoodModel = context.Foods.Find(id);
            context.Foods.Remove(FoodModel);
        }

        public void EditCardio(FoodModel FoodModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FoodModel> GetAllFoodModels(int Id)
        {
            throw new NotImplementedException();
        }

        public FoodModel GetFoodModel(int FoodModelId)
        {
            throw new NotImplementedException();
        }
    }
}