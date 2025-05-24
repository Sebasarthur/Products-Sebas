using BusinessLogic;
using Entities;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Por favor, elige una opción:");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Mostrar productos");
        Console.WriteLine("0. Salir");
        Console.Write("hola");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                
                // Lógica para agregar producto
                Console.WriteLine("Digite la informacion del producto a continuacion:");
                Console.WriteLine("ID:");
                var id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nombre:");
                var name = Console.ReadLine();
                Console.WriteLine("Precio:");
                var price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Stock:");
                var stock = Int32.Parse(Console.ReadLine());
                var producto = new Product
                {
                    ID = id,
                    name = name,
                    price = price,
                    stock = stock
                };
                

                var pm = new ProductManager();
                try
                {
                    pm.AddProduct(producto);
                    Console.WriteLine("Producto agregado con éxito.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                break;
            case 2:
                // Lógica para mostrar productos
                Console.WriteLine("Listado de productos existentes");
                
                break;
            case 0:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        
    }

  
}