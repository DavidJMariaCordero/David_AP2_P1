using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Articulos.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Debe introducir una descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir la existencia del producto")]
        public double Existencia { get; set; }

        [Required(ErrorMessage = "Debe introducir el costo del producto")]
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

    }
}
