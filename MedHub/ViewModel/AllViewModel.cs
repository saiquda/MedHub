using MedHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedHub.ViewModel
{
    public class AllViewModel
    {
        public IEnumerable<User> Users;
        public IEnumerable<Quiz> Quizzes;
        public IEnumerable<Answer> Answers;
    }
}
