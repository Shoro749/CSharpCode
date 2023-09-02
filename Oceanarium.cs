using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Oceanarium
    {
        List<Oceanarium> fishes = new List<Oceanarium>();

        public Oceanarium() { }

        public void add(Shark obj1, Turtle obj2, Fish obj3) 
        {
            fishes.Add(obj1);
            fishes.Add(obj2);
            fishes.Add(obj3);
        }

        public void ShowInfo()
        {
            foreach (var fish in fishes)
            {
                fish.ToString();
            }
        }
    }
}
