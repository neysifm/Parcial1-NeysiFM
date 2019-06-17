using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_NeysiFM.Entidades
{
   public class PrecioDetalle
    {
        [Key]
        public int PrecioId { get; set; }
        public Double Precio { get; set; }
        public String TipoPrecio { get; set; }

        public PrecioDetalle ()
        {
            PrecioId = 0;
            Precio = 0;
            TipoPrecio = string.Empty;
        }
    }
}
