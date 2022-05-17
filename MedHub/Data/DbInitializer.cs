using MedHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedHub.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                var users = new User[]
                {
                    new User{Nickname = "admin", Password = "admin@boba"}
                };
                foreach (User s in users)
                {
                    context.Users.Add(s);
                }
                context.SaveChanges();
                var quizes = new Quiz[]
                {
                    new Quiz{Name = "Composite Morningness Questionnaire", Url="<iframe src=\"https://docs.google.com/forms/d/e/1FAIpQLSdRNt5tpYZ7V94VL6w2hJ3u39LMtveMuEByAvIoNC5l9nzSjQ/viewform?embedded=true\" width=\"640\" height=\"4770\" frameborder=\"0\" marginheight=\"0\" marginwidth=\"0\">Загрузка…</iframe>"}
                };
                foreach (Quiz s in quizes)
                {
                    context.Quizzes.Add(s);
                }
                context.SaveChanges();
            }
        }
    }
}
