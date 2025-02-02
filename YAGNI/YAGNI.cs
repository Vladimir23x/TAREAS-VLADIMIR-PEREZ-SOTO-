using System;

public class ServicioProducto
{
    public void AgregarProducto(string nombre, decimal precio)
    {
        Console.WriteLine($"Producto {nombre} agregado con precio {precio}.");
    }

    public void EliminarProducto(int idProducto)
    {
        Console.WriteLine($"Producto {idProducto} eliminado.");
    }

    public static void Main()
    {
        ServicioProducto servicioProducto = new ServicioProducto();

        while (true)
        {
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Salir");
            
            string opcion = Console.ReadLine();
            
            if (opcion == "1")
            {
                Console.Write("Ingresa el nombre del producto: ");
                string nombre = Console.ReadLine();
                
                Console.Write("Ingresa el precio del producto: ");
                decimal precio;
                while (!decimal.TryParse(Console.ReadLine(), out precio))
                {
                    Console.Write("Precio invalido. Ingresa otra vez: ");
                }
                
                servicioProducto.AgregarProducto(nombre, precio);
            }
            else if (opcion == "2")
            {
                Console.Write("Ingresa el ID del producto que quieres eliminar: ");
                int idProducto;
                while (!int.TryParse(Console.ReadLine(), out idProducto))
                {
                    Console.Write("ID invalido. Ingresa otra vez: ");
                }
                
                servicioProducto.EliminarProducto(idProducto);
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Saliendo del programa");
                break;
            }
            else
            {
                Console.WriteLine("Opcion no valida, intentalo nuevamente");
            }
        }
    }
}
