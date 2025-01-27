using System;

namespace CalculadoraSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULOS DE SALARIOS.");

            while (true)
            {
                Console.WriteLine("\nSELECCIONE EL TIPO DE EMPLEADO:");
                Console.WriteLine("1. DOCENTE POR HORA");
                Console.WriteLine("2. DOCENTE DE CONTRATO FIJO");
                Console.WriteLine("3. EMPLEADO ADMINISTRATIVO");
                Console.WriteLine("4. SALIR");
                Console.Write("OPCION: ");
                string opcion = Console.ReadLine();

                if (opcion == "4")
                {
                    Console.WriteLine("SALIENDO DEL SISTEMA");
                    break;
                }

                Console.Write("INGRESA EL NOMBRE DEL EMPLEADO: ");
                string nombre = Console.ReadLine();

                Console.Write("¿ALCANZO LA META? (s/n): ");
                bool alcanzoMeta = Console.ReadLine().ToLower() == "s";

                Empleado empleado = null;

                switch (opcion)
                {
                    case "1":
                        Console.Write("INGRESA LAS HORAS TRABAJADAS: ");
                        int horasTrabajadas = int.Parse(Console.ReadLine());
                        empleado = new DocentePorHora(nombre, alcanzoMeta, horasTrabajadas);
                        break;

                    case "2":
                        Console.Write("INGRESA EL SALARIO BASE: ");
                        double salarioBaseDocente = double.Parse(Console.ReadLine());
                        empleado = new DocenteContratoFijo(nombre, alcanzoMeta, salarioBaseDocente);
                        break;

                    case "3":
                        Console.Write("INGRESA EL SALARIO BASE: ");
                        double salarioBaseAdmin = double.Parse(Console.ReadLine());
                        empleado = new EmpleadoAdministrativo(nombre, alcanzoMeta, salarioBaseAdmin);
                        break;

                    default:
                        Console.WriteLine("LA OPCION NO ES VALIDA, INTENTA DE NUEVO");
                        continue;
                }

                if (empleado != null)
                {
                    double salario = empleado.CalcularSalario();
                    Console.WriteLine($"\nEL SALARIO DE {empleado.Nombre} ES: {salario:C}");
                }
            }
        }
    }
}