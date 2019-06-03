using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_NeysiFM.Entidades
{
    public class Inventario
    {
        [Key]
        public int InventarioId { get; set; }
        public Double ValorInventario { get; set; }

        // CONTRUCTOR
        public Inventario(double valorInventario)
        {
            ValorInventario = valorInventario;
        }

        // CONSTRUCTOR VACIO
        public Inventario()
        {
            //
        }
    }
}
