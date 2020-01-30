using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Estudiante
    {
        [Key]
        public long EstudianteId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Primer Apellido")]
        public string Primer_Apellido { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Segundo Apellido")]
        public string Segundo_Apellido { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}
