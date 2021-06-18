using System;

namespace FactoryMethod.ConcreteProducts
{
    public class SmsNotification : INotification
    {
        public void Send(string receptor, string subject, string text)
        {
            Console.WriteLine($"send message for Mobile Number: {receptor} with subject: {subject} and text: {text}");
        }
    }
}