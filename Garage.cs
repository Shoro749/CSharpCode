using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Гараж». Клас має містити інформацію
про машини, які знаходяться в гаража. Створіть клас
«Автомобіль», в якому, відповідно, міститься інформація
про автомобіль. Реалізуйте підтримку ітератора для класу
«Гараж». Протестуйте можливість використання foreach
для класу «Гараж».*/

namespace CSharpCode
{
    public class Garage
    {
        private List<int> cars = new List<int>();
    }
}
