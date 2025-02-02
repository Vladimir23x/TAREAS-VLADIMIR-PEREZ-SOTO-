using System;

public class Payroll
{
    private decimal CalcularSalarioNeto(decimal salario)
    {
        decimal impuesto = salario * 0.18m;
        decimal bono = salario * 0.05m;
        return salario - impuesto + bono;
    }

    public decimal CalcularSalarioTiempoCompleto(decimal salarioBase)
    {
        return CalcularSalarioNeto(salarioBase);
    }

    public decimal CalcularSalarioTiempoParcial(decimal tarifaPorHora, int horasTrabajadas)
    {
        decimal salario = tarifaPorHora * horasTrabajadas;
        return CalcularSalarioNeto(salario);
    }

    public static void Main()
    {
        Payroll nomina = new Payroll();

        Console.WriteLine("Ingresa el tipo de empleado (1 para tiempo completo, 2 para medio tiempo):");
        int tipoEmpleado = int.Parse(Console.ReadLine());

        if (tipoEmpleado == 1)
        {
            Console.Write("Ingresa el salario base: ");
            decimal salarioBase = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Salario neto: " + nomina.CalcularSalarioTiempoCompleto(salarioBase));
        }
        else if (tipoEmpleado == 2)
        {
            Console.Write("Ingresa la tarifa por hora: ");
            decimal tarifaPorHora = decimal.Parse(Console.ReadLine());
            Console.Write("Ingresa las horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario neto: " + nomina.CalcularSalarioTiempoParcial(tarifaPorHora, horasTrabajadas));
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }
    }
}
