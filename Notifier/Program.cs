using Notifier;

Notification notification = new Notification();

notification = new FacebookDecorator(notification);
notification = new SlackDecorator(notification);
notification = new SmsDecorator(notification);

OnCriticalEvent(notification);










void OnCriticalEvent(Notification notification)
{
    const string message = "CRITICAL EVENT";
    notification.SendMessage(message);
}
