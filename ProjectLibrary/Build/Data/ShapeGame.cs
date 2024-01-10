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
        public int Base {  get; set; } 

        [Required]
        public int Height { get; set; }

        public int CathetusOne { get; set; }
        public int CathetusTwo { get; set; }
        public int Hypotenuse {  get; set; }

        [Required]
        public double Area { get; set; }

        [Required]
        public double Circumference { get; set; }

        [Required]
        public DateOnly Date { get; set; }
    }
}
