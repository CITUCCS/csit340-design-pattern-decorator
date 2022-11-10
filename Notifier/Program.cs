using Notifier;

Notification notification = new Notification();
OnCriticalEvent(notification);

notification = new FacebookNotification();
OnCriticalEvent(notification);

notification = new SmsNotification();
OnCriticalEvent(notification);

notification = new SlackNotification();
OnCriticalEvent(notification);




void OnCriticalEvent(Notification notification)
{
    const string message = "CRITICAL EVENT";
    notification.SendMessage(message);
}