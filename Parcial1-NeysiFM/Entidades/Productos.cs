using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Parcial1_NeysiFM.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }
        public int UbicacionId { get; set; }
        public String Descripcion { get; set; }
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

        // CONSTRUCTOR
        public Productos()
        {
            ProductosId = 0;
            Descripcion = String.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }
    }
}
