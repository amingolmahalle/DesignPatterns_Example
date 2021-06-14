using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory notification = new ConcreteNotificationFactory();

            INotification smsNotification = notification.GeNotification(NotificationType.Sms);

            smsNotification.Send("09123456789", "No Subject", "this is a sms text");
            
            Console.WriteLine();

            INotification emailNotification = notification.GeNotification(NotificationType.Email);

            emailNotification.Send("test@gmail.com", "No Subject", "this is an email text");
        }
    }
}