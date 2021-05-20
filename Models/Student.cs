using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ByeMed.Models
{
    public class Student
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
    }
}
