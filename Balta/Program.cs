using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dot-net"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            
            courses.Add(courseOop);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especilista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Aprende .NET", "", courseAspNet);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOop);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(item => item.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }

            var paypalSubscription = new PaypalSubscription();
            var student = new Student();
            student.CreateSubscription(paypalSubscription);
        }
    }
}