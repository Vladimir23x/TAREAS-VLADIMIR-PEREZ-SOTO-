using System;

public class EmailService
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Enviando correo a {email}: {message}");
    }
}

public class SmsService
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
    }
}

public class LoggerService
{
    public void LogNotification(string message)
    {
        Console.WriteLine($"Registrando notificacion: {message}");
    }
}

public class Program
{
    public static void Main()
    {
        EmailService emailService = new EmailService();
        SmsService smsService = new SmsService();
        LoggerService loggerService = new LoggerService();

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Enviar correo electronico");
        Console.WriteLine("2. Enviar SMS");
        Console.WriteLine("3. Registrar notificacion");
        Console.WriteLine("4. Salir");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("Ingresa el correo electronico: ");
                string email = Console.ReadLine();
                Console.Write("Ingresa el mensaje: ");
                string emailMessage = Console.ReadLine();
                emailService.SendEmail(email, emailMessage);
                break;
            case "2":
                Console.Write("Ingresa el numero de telefono: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Ingresa el mensaje: ");
                string smsMessage = Console.ReadLine();
                smsService.SendSMS(phoneNumber, smsMessage);
                break;
            case "3":
                Console.Write("Ingresa el mensaje de notificación: ");
                string logMessage = Console.ReadLine();
                loggerService.LogNotification(logMessage);
                break;
            case "4":
                Console.WriteLine("Saliendo del programa");
                return;
            default:
                Console.WriteLine("Opcion no válida, intentalo nuevamente.");
                break;
        }
    }
}
