namespace Notifier
{
    public class Notification
    {
        public virtual void SendMessage(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }
}
