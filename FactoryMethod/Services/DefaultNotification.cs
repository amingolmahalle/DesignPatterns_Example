using System;

namespace FactoryMethod.Services
{
    public class DefaultNotification : INotification
    {
        public void Send(string receptor, string subject, string text)
        {
            Console.WriteLine("not available");
        }
    }
}