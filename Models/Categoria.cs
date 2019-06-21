using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET2.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="Este  campo es obligatorio")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "El nombre debe tener  de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256)]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
