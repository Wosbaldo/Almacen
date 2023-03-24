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

             Producto ProductoIndividual(int id)
            {
                using (AlmacenContext bd = new AlmacenContext())
                {

                    var buscar = bd.Productos.FirstOrDefault(x => x.Id == id);

                    return buscar;
                }
            }
             void ActualizarProducto(Producto ParamentroProducto)
            {
                using (AlmacenContext db =
                    new AlmacenContext())
                {

                    var buscar = ProductoIndividual(ParamentroProducto.Id);
                    if (buscar == null)
                    {
                        Console.WriteLine("El id no existe");
                    }
                    else
                    {
                        buscar.Precio = ParamentroProducto.Precio;
                        db.Update(buscar);
                        db.SaveChanges();

                    }

                }
            }
        }
    }

}