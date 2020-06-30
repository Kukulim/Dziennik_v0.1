using Dziennik_v0._1.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dziennik_v0._1.Presistence.UserDbInitializer
{
    public class UserDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Users.Add(new Core.Models.ApplicationUser { Id = "6d99442e-f680-4bef-bd30-6441f6238afa",SecurityStamp= "f7c82b55-fa9e-43bd-a05d-0cc521f5f6d6", Email = "test@test.test", UserName = "test@test.test", PasswordHash= "AAs+h0C5tUc4l1deZozs3nyDzJjFMrzIL+wsv3Mrfyca4ZIkscTroBo2PfPPz8qT0w==" });

            base.Seed(context);
        }
    }
}