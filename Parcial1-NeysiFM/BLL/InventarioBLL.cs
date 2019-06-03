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
        public static bool Guardar(Inventario inventario)
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

        public static bool Modificar(Inventario inventario)
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

        public static Inventario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
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

        public static List<Inventario> GetList(Expression<Func<Inventario, bool>> inventario)
        {
            List<Inventario> Lista = new List<Inventario>();
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
