using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Car : Device, IDevices
    {
        public Car(string name, string desc) : base(name, desc) { }

        public void Sound() { Console.WriteLine("*buzz*"); }
    }
}
