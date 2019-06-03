using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parcial1_NeysiFM.Entidades;


namespace Parcial1_NeysiFM.DAL
{
    public class Contexto : DbContext
    {
        public DbSet <Productos> Producto { get; set; }
        public DbSet <Inventario> Inventario { get; set; }
        public DbSet <Ubicaciones> Ubicacion { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
