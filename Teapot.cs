using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Teapot : Device, IDevices
    {
        public Teapot(string name, string desc) : base(name, desc) { }

        public void Sound() { Console.WriteLine("*gurgle*");  }
    }
}
