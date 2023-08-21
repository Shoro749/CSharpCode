using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    abstract public class Worker : IWorker
    {
        public string _job;

        public Worker(string job)
        {
            _job = job;
        }

        virtual public void Print()
        {
            Console.WriteLine("\nНе відома робота працівника!");
        }
    }
}
