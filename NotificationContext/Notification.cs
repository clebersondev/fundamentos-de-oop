namespace Balta.NotificationContext;

public sealed class Notification
{
    public Notification()
    {

    }
    public Notification(string property, string messege)
    {
        Property = property;
        Messege = messege;
    }

    public string Property { get; set; } = string.Empty;
    public string Messege { get; set; } = string.Empty;
}