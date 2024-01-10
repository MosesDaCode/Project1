using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Build.Data
{
    public class RPS
    {
        [Key]
        public int RockPaperScissorId { get; set; }

        [Required]
        public string PlayerMove {  get; set; } = string.Empty;

        [Required]
        public string ComputerMove {  get; set; } = string.Empty;

        [Required]
        public string Result { get; set; } = string.Empty;

        [Required]
        public DateOnly GameDate { get; set; }
    }
}
