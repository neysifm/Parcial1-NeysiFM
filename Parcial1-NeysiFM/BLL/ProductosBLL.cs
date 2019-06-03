using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parcial1_NeysiFM.DAL;
using Parcial1_NeysiFM.Entidades;
using System.Linq.Expressions;

namespace Parcial1_NeysiFM.BLL
{
    public class ProductosBLL
    {
        // METODO GUARDAR
        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Producto.Add(producto) != null)
                {
                    Inventario iv = contexto.Inventario.Find(1);
                    iv.ValorInventario += producto.ValorInventario;
                    contexto.Entry(iv).State = EntityState.Modified;

                    paso = contexto.SaveChanges() > 0;
                }
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
                var eliminar = contexto.Producto.Find(Id);
                Inventario inventario = InventarioBLL.Buscar(1);
                inventario.ValorInventario -= eliminar.ValorInventario;
                contexto.Entry(inventario).State = EntityState.Modified;
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
        public static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Double valorModificar = 0;
                Productos productoAnterior = ProductosBLL.Buscar(producto.ProductosId);
                if (productoAnterior.ValorInventario > producto.ValorInventario)
                {
                  valorModificar = producto.ValorInventario - productoAnterior.ValorInventario;
                } else if (productoAnterior.ValorInventario < producto.ValorInventario)
                {
                  valorModificar = producto.ValorInventario - productoAnterior.ValorInventario;
                }
                Inventario inventario = InventarioBLL.Buscar(1);
                if(valorModificar >= 0)
                {
                  inventario.ValorInventario += valorModificar;
                } else
                {
                    if((inventario.ValorInventario + valorModificar) >= 0)
                    {
                        inventario.ValorInventario += valorModificar;
                    }
                }          
                contexto.Entry(inventario).State = EntityState.Modified;
                contexto.Entry(producto).State = EntityState.Modified;
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
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos producto = new Productos();
            try
            {
                producto = contexto.Producto.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return producto;
        }

        // LISTAR PRODUCTOS
        public static List<Productos> GetList(Expression<Func<Productos, bool>> producto)
        {
            List<Productos> Lista = new List<Productos>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Producto.Where(producto).ToList();
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
