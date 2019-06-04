using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_NeysiFM.Entidades
{
    public class Ubicaciones
    {
        [Key]
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }

        // CONTRUCTOR
        public Ubicaciones()
        {
            UbicacionId = 0;
            Descripcion = String.Empty;
        }
    }
}
