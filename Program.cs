using System;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "C-sharp"));
            articles.Add(new Article("Artigo sobre .Net", "Dot-Net"));


            // foreach(var article in articles){
            //     System.Console.WriteLine(article.Id);
            //     System.Console.WriteLine(article.Title);
            //     System.Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-OOP");
            var courseCSharp = new Course("Fundamentos C#", "C-sharp");
            var courseDotNet = new Course("Fundamentos .Net", "Dote-Net");

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseDotNet);


            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET","especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Começe por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Aprenda ASP.Net", "", courseDotNet);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach(var career in careers){
                System.Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x=>x.Order)){
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                    System.Console.WriteLine(item.Course?.Title);
                    System.Console.WriteLine(item.Course?.Level);

                    foreach(var notification in item.Notifications){
                        System.Console.WriteLine($"{notification.Property} - {notification.Message}");

                    }
                }
            }

            var paypalSubscription = new PaypalSubscription();

            var student = new Student();
            student.CreateSubscription(paypalSubscription);
        }
    }
}

