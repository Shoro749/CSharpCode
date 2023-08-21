using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Manager : Worker, IManager
    {
        private string _desc;

        public Manager(string job, string desc) : base(job)
        {
            _desc = desc;
        }

        override public void Print()
        {
            Console.WriteLine($"Професія: {_job}\nОпис: {_desc}\nУмови щоб стати {_job}: " +
            $"Щоб займати керівні посади, потрібно обов'язково мати вищу профільну освіту.");
        }
    }
}
