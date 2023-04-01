// See https://aka.ms/new-console-template for more information
using Almacen.DAO;
using Almacen.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        CrudProducto crudProducto = new CrudProducto();
        Producto Producto = new Producto();


        bool Continuar = true;
        while (Continuar)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Pulse 1 para realizar insertar Producto");
            Console.WriteLine("Pulse 2 para realizar una actualizacion de Producto");
            Console.WriteLine("Pulse 3 para realizar unaEliminacion de Producto");
            Console.WriteLine("Pulse 4 para realizar una Listado de Producto");

            var Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {

                case 1:
                    int bucle = 1;
                    while (bucle == 1)
                    {

                    }
                    break;
                case 2:
                    Console.WriteLine("Actualizar datos");
                    Console.WriteLine("Ingresa el ID del producto a actualizar");
                    var ProductoIndividualU = crudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));
                    if (ProductoIndividualU == null)
                    {
                        Console.WriteLine("ElProducto no existe");
                    }
                    else
                    {
                        Console.WriteLine($"Nombre {ProductoIndividualU.Nombre} , Precio {ProductoIndividualU.Precio}");


                        Console.WriteLine("Para actulizar nombre coloca el # 1");

                        Console.WriteLine("Para actulizar el precio coloca el # 2");

                        var Lector = Convert.ToInt32(Console.ReadLine());
                        if (Lector == 1)
                        {
                            Console.WriteLine("Ingrese el nombre");
                            ProductoIndividualU.Nombre = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el precio");
                            ProductoIndividualU.Descripción = Console.ReadLine();
                        }
                        crudProducto.ActualizarProducto(ProductoIndividualU, Lector);
                        Console.WriteLine("Actualizacion correcta");
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingresa el ID delproducto a eliminar");
                    var ProductoIndividualD = crudProducto.ProductoIndividual(Convert.ToInt32(Console.ReadLine()));
                    if (ProductoIndividualD == null)
                    {
                        Console.WriteLine("Este producto no existe");
                    }
                    else
                    {
                        Console.WriteLine("Eliminar producto");
                        Console.WriteLine($"Nombre {ProductoIndividualD.Nombre} , Precio {ProductoIndividualD.Precio}");
                        Console.WriteLine("El producto encontrado es el correcto?");
                        var Lector = Convert.ToInt32(Console.ReadLine());
                        if (Lector == 1)
                        {
                            var Id = Convert.ToInt32(ProductoIndividualD.Id);
                            Console.WriteLine(crudProducto.EliminarProducto(Id));
                        }
                        else
                        {
                            Console.WriteLine("Inicia nuevamente");
                        }

                    }
                    break;
                case 4:
                    Console.WriteLine("Lista de Producto");
                    var ListarProducto = crudProducto.ListarProducto();
                    foreach (var iteracionProducto in ListarProducto)
                    {
                        Console.WriteLine($"{iteracionProducto.Id} , {iteracionProducto.Nombre} , {iteracionProducto.Precio}");
                    }
                    break;
            }
            Console.WriteLine("Desea continuar ?");
            var cont = Console.ReadLine();
            if (cont.Equals("N"))
            {
                Continuar = false;
            }
        }

    }
}