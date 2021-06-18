using System;

namespace FactoryMethod.ConcreteProducts
{
    public class EmailNotification : INotification
    {
        public void Send(string receptor, string subject, string text)
        {
            Console.WriteLine($"send message for Email Address: {receptor} with subject: {subject} and text: {text}");
        }
    }
}