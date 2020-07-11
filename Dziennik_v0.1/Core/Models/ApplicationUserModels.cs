using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Dziennik_v0._1.Core.Helpers;
using Dziennik_v0._1.Core.Models.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Dziennik_v0._1.Core.Models
{
    // Możesz dodać dane profilu dla użytkownika, dodając więcej właściwości do klasy ApplicationUser. Odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=317594, aby dowiedzieć się więcej.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Imię:")]
        public string Name { get; set; }
        [Display(Name = "Wiek:")]
        public int Age { get; set; }
        [Display(Name = "Waga:")]
        public float Weight { get; set; }
        [Display(Name = "Waga docelowa:")]
        public float Target { get; set; }
        [Display(Name = "Wzrost:")]
        public int Height { get; set; }
        [Display(Name = "Zawartość procentowa tłuszczu:")]
        public float BodyFat { get; set; }
        [Display(Name = "Płeć:")]
        public SexType Sex { get; set; }

        public int AchievementsPoints { get; set; }

        public List<Achievement> Achievements { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }
    }
}