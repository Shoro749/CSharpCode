using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Turtle : Oceanarium
    {
        private int _size;
        private int _mass;
        private int _carapace;
        private string _location;
        private string _desc;

        public Turtle(int size, int mass, int carapace, string location, string desc)
        {
            _size = size;
            _mass = mass;
            _carapace = carapace;
            _location = location;
            _desc = desc;
        }

        public void ToString()
        {
            Console.WriteLine($"Назва: Черепаха\nРозмір: {_size}\nМаса: {_mass}\nДовжина панцира: " +
                $"{_carapace}\nМожна знайти: {_location}\nОпис: {_desc}\n");
        }
    }
}
