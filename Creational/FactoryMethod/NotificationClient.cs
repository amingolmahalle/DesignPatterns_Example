using FactoryMethod.ConcreteProducts;

namespace FactoryMethod
{
    public class NotificationClient : NotificationFactory
    {
        public override INotification GeNotification(NotificationType notificationType)
        {
            INotification notification;

            if (notificationType is NotificationType.Email)
            {
                notification = new EmailNotification();
            }
            else if (notificationType is NotificationType.Sms)
            {
                notification = new SmsNotification();
            }
            else
            {
                notification = new DefaultNotification();
            }

            return notification;
        }
    }
}