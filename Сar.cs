using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Car
    {
        public string _Brand;
        public string _color;
        public string _FuelType;
        public int _EngineCapacity;
        public int _power;
        public int _revolutions;

        public Car(string brand, string color, string fuelType, int engineCapacity, int power, int revolutions)
        {
            _Brand = brand;
            _color = color;
            _FuelType = fuelType;
            _EngineCapacity = engineCapacity;
            _power = power;
            _revolutions = revolutions;
        }

        public void ToString()
        {
            Console.WriteLine($"Бренд: {_Brand}\nКолір: {_color}\nТип палива: {_FuelType}\n" +
                $"Об'єм двигуна: {_EngineCapacity} куб.см\nПотужність: {_power}\nОбороти: {_revolutions} об/хв\n");
        }
    }
}
