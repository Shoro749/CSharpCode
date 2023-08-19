using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Microwave : Device, IDevices
    {
        public Microwave(string name, string desc) : base(name, desc) { }

        public void Sound() { Console.WriteLine("*wwwwww*, *peep*, *peep*"); }
    }
}
