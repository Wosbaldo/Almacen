// See https://aka.ms/new-console-template for more information
using Almacen.Models;

//Console.WriteLine("Hello, World!");


using (AlmacenContext db = new AlmacenContext())
{
    var ListProductos = db.Productos.ToList();

    foreach (var product in ListProductos)
    {
        Console.WriteLine(product.Id);
        Console.WriteLine(product.Nombre);
        Console.WriteLine(product.Descripción);
        Console.WriteLine(product.Precio);
        Console.WriteLine(product.Stokck);
    }

    //Producto producto = new Producto();
    //producto.Id = 01;
    //producto.Nombre = "Manzana";
    //producto.Descripción = "Frutas frescas";
    //producto.Precio = 2;
    //producto.Stokck = 50;

    //db.Productos.Add(producto);
    //db.SaveChanges();
}