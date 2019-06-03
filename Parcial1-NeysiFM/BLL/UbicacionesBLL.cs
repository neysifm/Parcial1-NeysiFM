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
    public class UbicacionesBLL
    {
        // METODO GUARDAR
        public static bool Guardar(Ubicaciones ubicaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Add(ubicaciones) != null)
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
                var eliminar = contexto.Ubicacion.Find(Id);
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
        public static bool Modificar(Ubicaciones ubicaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                contexto.Entry(ubicaciones).State = EntityState.Modified;
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
        public static Ubicaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ubicaciones ubicaciones = new Ubicaciones();
            try
            {
                ubicaciones = contexto.Ubicacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ubicaciones;
        }

        // LISTAR INVENTARIO
        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicaciones)
        {
            List<Ubicaciones> Lista = new List<Ubicaciones>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Ubicacion.Where(ubicaciones).ToList();
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
