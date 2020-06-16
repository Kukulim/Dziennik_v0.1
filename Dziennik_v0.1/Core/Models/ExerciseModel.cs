using System.ComponentModel.DataAnnotations;

namespace Dziennik_v0._1.Core.Models
{
    public class Exercise 
    {
        [Required]
        public int Id { get; set; }

        public int WorkoutId { get; set; }

        public Workout Workout { get; set; }

        [Required]
        [Display(Name = "Ćwiczenie:")]
        public string Name { get; set; }

        [Display(Name = "Serie:")]
        public int Series { get; set; }

        [Display(Name = "Powtórzenia:")]
        public int Repetitions { get; set; }

        [Display(Name = "Ciężar:")]
        public int Weight { get; set; }

        [Display(Name = "Objętość:")]
        [Required]
        [Range(1,9000000, ErrorMessage="Pole Wymagane")]
        public int Volume { get; set; }
    }
}