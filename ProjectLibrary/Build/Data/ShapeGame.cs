using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.Build.Data
{
    public class ShapeGame
    {
        [Key]
        public int ShapeId { get; set; }

        [Required]
        public string ShapeForm { get; set; } = string.Empty;

        [Required]
        public double Base {  get; set; } 

        [Required]
        public double Height { get; set; }

        public double CathetusOne { get; set; }
        public double CathetusTwo { get; set; }
        public double Hypotenuse {  get; set; }

        [Required]
        public double Area { get; set; }

        [Required]
        public double Circumference { get; set; }

        [Required]
        public DateOnly Date { get; set; }
        
        
        public DateOnly EditDate { get; set; }
    }
}
