using System.Linq;
using Balta.ContentContext;

var articles = new List<Article>();

articles.Add(new Article("Fundamentos de C#", "fundamentos-de-c#"));
articles.Add(new Article("Fundamentos de OOP", "fundamentos-de-OOP"));
articles.Add(new Article("Fundamentos de Blazor", "fundamentos-de-Blazor"));

// foreach (var article in articles)
// {
//     Console.WriteLine(article.Id);
//     Console.WriteLine(article.Title);
//     Console.WriteLine(article.Url);
//     Console.WriteLine("-----------------------");
// };

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careerItem2 = new CareerItem(2, "Curso de OOP", "", courseOOP);
var careerItem = new CareerItem(1, "Curso de C#", "", courseCsharp);
var careerItem3 = new CareerItem(3, "Curso de ASP.NET", "", courseAspNet);


var careers = new List<Career>();
var career1 = new Career(".NET Fullstack", "dotnet-fullstack");
career1.Items.Add(careerItem);
career1.Items.Add(careerItem2);
career1.Items.Add(careerItem3);
careers.Add(career1);

foreach (var career in careers)
{
    Console.WriteLine($"Carreira {career.Title}:");
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Url);
    }
}