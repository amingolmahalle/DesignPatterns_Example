using FactoryMethod.Services;

namespace FactoryMethod
{
    public class ConcreteNotificationFactory : NotificationFactory
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