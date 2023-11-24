namespace Balta.ContentContext;

public class Lecture : Base
{
    // public Lecture(string title)
    // {
    //     Title = title;       
    // }
    public int Order { get; set; }
    public string? Title { get; set; }
    public int DurationInMinutes { get; set; }
}