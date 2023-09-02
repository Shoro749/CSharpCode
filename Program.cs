using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Гараж». Клас має містити інформацію
                про машини, які знаходяться в гаражі. Створіть клас
                «Автомобіль», в якому, відповідно, міститься інформація
                про автомобіль. Реалізуйте підтримку ітератора для класу
                «Гараж». Протестуйте можливість використання foreach
                для класу «Гараж».*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Car car1 = new Car("BMW", "Black", "Дизель", 1685, 141, 4000);
                Car car2 = new Car("Toyota", "Gray", "Бензин", 1591, 135, 6300);
                Garage garage = new Garage(car1, car2);
                garage.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}