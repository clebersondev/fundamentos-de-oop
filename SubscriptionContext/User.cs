using Balta.SharedContext;

namespace Balta.SubscritionContext;
public class User : Base
{
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}