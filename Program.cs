// See https://aka.ms/new-console-template for more information
using Almacen.DAO;
using Almacen.Models;

CrudProducto crudProducto = new CrudProducto();
Producto Producto = new Producto();


Console.WriteLine("Menu");
Console.WriteLine("Pulse 1 para realizar insertar Producto");
Console.WriteLine("Pulse 2 para realizar una actualizacion de Producto");
var Menu = Convert.ToInt32(Console.ReadLine());


switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("Ingresa el nombre del Producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa La descripción");
            Producto.Descripción = Console.ReadLine();
            Console.WriteLine("Ingresa su Precio");
            Producto.Precio = Convert.ToInt32(Console.ReadLine());
            CrudProducto.AgregarProducto(Producto);
            Console.WriteLine("El Nombre del producto  se ingreso correctamente");
            Console.WriteLine("Pulsa 1 para continuar insertando Productos");
            Console.WriteLine("Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
    case 2:
        Console.WriteLine("Actualizar datos");
        break;
}
//Usuario.Id = 3;



//CrudUsuarios.AgregarUsuario(Usuario);
//CrudUsuarios.ActualizarUsuario(Usuario);




//OrmEntityFrameworkContext db = new OrmEntityFrameworkContext();

//var buscar = db.Usuarios.FirstOrDefault(x => x.Id == 1);

//db.Usuarios.Remove(buscar);
//db.SaveChanges();
#region Actualizar
//buscar.Nombre = "Efrain";
//buscar.Apellido = "Villacorta";

//db.Usuarios.Update(buscar);
//db.SaveChanges();
#endregion
//Console.WriteLine(buscar);
#region Listar
//var ListUsuarios = db.Usuarios.ToList();

//        foreach (var usu in ListUsuarios) {
//            Console.WriteLine(usu.Nombre);
//        }

#endregion
#region Insertar
//Usuario usuario = new Usuario();
//usuario.Nombre = "Mario";
//usuario.Apellido = "Alas";
//usuario.Edad = 18;

//db.Usuarios.Add(usuario);
//db.SaveChanges();
#endregion