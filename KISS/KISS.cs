using System;
using System.Linq;

public class RestaurantBill
{
    public static decimal CalculateTotal(decimal[] prices, decimal? tipPercentage)
    {
        decimal total = prices.Sum();
        decimal tip = total * (tipPercentage ?? 10) / 100;
        return total + tip;
    }

    public static void Main()
    {
        Console.WriteLine("Ingresa los precios de los platos:");
        decimal[] prices = Console.ReadLine()
                                  .Split(',')
                                  .Select(decimal.Parse)
                                  .ToArray();

        Console.WriteLine("¿Desea ingresar un porcentaje de propina o usar la predeterminada de 10%? (S/N)");
        string response = Console.ReadLine().Trim().ToUpper();

        decimal? tipPercentage = null;
        if (response == "S")
        {
            Console.WriteLine("Ingresa el porcentaje de propina:");
            tipPercentage = decimal.Parse(Console.ReadLine());
        }

        decimal total = CalculateTotal(prices, tipPercentage);
        Console.WriteLine($"Total a pagar: {total:C}");
    }
}

