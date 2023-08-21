using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Engineer : Worker, IEngineer
    {
        private string _desc;

        public Engineer(string job, string desc) : base(job)
        {
            _desc = desc;
        }

        override public void Print()
        {
            Console.WriteLine($"Професія: {_job}\nОпис: {_desc}\nУмови щоб стати {_job}: " +
            $"Для того, щоб отримати роботу інженера, потрібно обов'язково мати диплом про вищу профільну освіту.");
        }
    }
}
