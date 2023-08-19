using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Steamboat : Device, IDevices
    {
        public Steamboat(string name, string desc) : base(name, desc) { }

        public void Sound() { Console.WriteLine("*the noise of a steam engine*"); }
    }
}
