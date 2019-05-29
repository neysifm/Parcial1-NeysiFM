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
        public String Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Costo { get; set; }
        public double ValorInventario { get; set; }

        public Productos()
        {
            ProductosId = 0;
            Descripcion = String.Empty;
            Existencia = int.Empty;
            Costo = float.Empty;
            ValorInventario = Double.Empty;
        }
    }
}
