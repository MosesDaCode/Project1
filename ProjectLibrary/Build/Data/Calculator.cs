using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Build.Data
{
    public class Calculator
    {
        [Key]
        public int CalculatorId { get; set; }

        [Required]
        public double FirstNum { get; set; }

        [Required]
        public double SecondNum { get; set; }

        [Required]
        public string Operation { get; set; } = string.Empty;

        [Required]
        public double Result { get; set; }

        [Required]
        public DateOnly CalculationDate { get; set; }

    }
}
