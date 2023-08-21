using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class President : Worker, IPresident
    {
        private string _desc;

        public President(string job, string desc) : base(job)
        {
            _desc = desc; 
        }

        override public void Print() { Console.WriteLine($"Професія: {_job}\nОпис: {_desc}\nУмови щоб посісти посаду: " +
            $"Президентом України може бути обраний громадянин України, який досяг тридцяти п'яти років, має право голосу," +
            $" проживає в Україні протягом десяти останніх перед днем виборів років та володіє державною мовою." +
            $" Одна й та сама особа не може бути Президентом України більше ніж два строки підряд."); }
    }
}
