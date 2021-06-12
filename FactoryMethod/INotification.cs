namespace FactoryMethod
{
    public interface INotification
    {
        void Send(string receptor, string subject, string text);
    }
}