using Parcial1_NeysiFM.DAL;
using Parcial1_NeysiFM.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_NeysiFM.BLL
{
    public class InventarioBLL
    {
        // METODO GUARDAR
        public static bool Guardar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inventario.Add(inventario) != null)
                    paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        // METODO ELIMINAR
        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Inventario.Find(Id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        // METODO MODIFICAR
        public static bool Modificar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                contexto.Entry(inventario).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        // METODO BUSCAR
        public static Inventarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventarios inventario = new Inventarios();
            try
            {
                inventario = contexto.Inventario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return inventario;
        }

        // LISTAR INVENTARIO
        public static List<Inventarios> GetList(Expression<Func<Inventarios, bool>> inventario)
        {
            List<Inventarios> Lista = new List<Inventarios>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Inventario.Where(inventario).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
