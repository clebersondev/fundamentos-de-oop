using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscritionContext;
public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
            return;
        }
        else
        {
            Subscriptions.Add(subscription);
        }
    }
}