using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class MusicInstrument : IMusicInstrument
    {
        public string _name;
        public string _desc;

        public MusicInstrument(string name, string desc)
        {
            _name = name;
            _desc = desc;
        }

        public void Show() { Console.WriteLine("\n" + _name); }
        public void Desc() { Console.WriteLine(_desc); }
    }
}
