using Almacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.DAO
{
    public class CrudProducto
    {
        public void AgregarProducto(Producto Parametroproducto)
        {

            using (AlmacenContext db =
                    new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = Parametroproducto.Nombre;
                producto.Descripción = Parametroproducto.Descripción;
                producto.Precio = Parametroproducto.Precio;
                producto.Stokck = Parametroproducto.Stokck;
                db.Add(producto);
                db.SaveChanges();
            }

        }

        public Producto ProductoIndividual(int id)
        {
            using (AlmacenContext bd = new AlmacenContext())
            {

                var buscar = bd.Productos.FirstOrDefault(x => x.Id == id);

                return buscar;
            }
        }
        public void ActualizarProducto(Producto Parametroproducto, int Lector)
        {
            using (AlmacenContext db =
                new AlmacenContext())
            {

                var buscar = ProductoIndividual(Parametroproducto.Id);
                if (buscar == null)
                {
                    Console.WriteLine("El id no existe");
                }
                else
                {
                    if (Lector == 1)
                    {
                        buscar.Nombre = Parametroproducto.Nombre;
                    }
                    else
                    {
                       
                        buscar.Precio = Parametroproducto.Precio;
                    }

                    
                    db.Update(buscar);
                    db.SaveChanges();

                }

            }
        }
        public string EliminarProducto(int id)
        {
            using (AlmacenContext db =
                    new AlmacenContext())
            {
                var buscar = ProductoIndividual(id);
                if (buscar == null)
                {
                    return "El Producto no existe";
                }
                else
                {
                    db.Productos.Remove(buscar);
                    db.SaveChanges();
                    return "El Productose elimino";
                }

            }
        }

        public List<Producto> ListarProducto()
        {
            using (AlmacenContext db =
                   new AlmacenContext())
            {
                return db.Productos.ToList();
            }

        }
       


    }
} 
