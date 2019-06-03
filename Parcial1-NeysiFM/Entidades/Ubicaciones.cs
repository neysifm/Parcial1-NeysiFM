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
        public int UbicacionesId { get; set; }
        public string Descripcion { get; set; }

        // CONTRUCTOR
        public Ubicaciones()
        {
            UbicacionesId = 0;
            Descripcion = String.Empty;
        }
    }
}
