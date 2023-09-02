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
        private List<Car> cars = new List<Car>();

        public Garage(Car obj, Car obj2) 
        {
            cars.Add(obj);
            cars.Add(obj2);
        }

        public void ShowInfo()
        {
            foreach (Car car in cars) 
            {
                car.ToString();
            }
        }
    }
}
