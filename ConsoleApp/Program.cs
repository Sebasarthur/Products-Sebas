public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Por favor, elige una opción:");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Mostrar productos");
        Console.WriteLine("0. Salir");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                // Lógica para agregar producto
                Console.WriteLine("Digite la informacion del producto a continuacion:");
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