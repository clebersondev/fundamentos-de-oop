using Balta.SharedContext;

namespace Balta.SubscritionContext;
public class Plan : Base
{
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }

}