namespace FactoryMethod
{
    public abstract class NotificationFactory
    {
        public abstract INotification GeNotification(NotificationType notificationType);
    }
}