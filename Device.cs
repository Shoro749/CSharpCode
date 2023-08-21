using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Device : IDevice
    {
        public string _name;
        public string _desc;

        public Device(string name, string desc)
        {
            _name = name;
            _desc = desc;
        }

        virtual public void Sound() { Console.WriteLine(" "); }
        public void Show() { Console.WriteLine("\n" + _name); }
        virtual public void Desc()
        {
            Console.WriteLine(" ");
        }
    }
}
