using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Security : Worker, ISecurity
    {
        private string _desc;

        public Security(string job, string desc) : base(job)
        {
            _desc = desc;
        }

        override public void Print() { Console.WriteLine($"Професія: {_job}\nОпис: {_desc}\nУмови щоб стати {_job}: " +
            $"Як правило, стати охоронцем може людина, що пройшла спеціальну фізичну і тактичну підготовку, що володіє " +
            $"різними видами бойового мистецтва, що вміє стріляти, визначати можливі загрози " +
            $"і миттєво реагувати з метою їх запобігання."); }
    }
}
