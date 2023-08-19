using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створити базовий клас «Пристрій» і похідні класи:
                «Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
                За допомогою конструктора, встановити назву до кожного
                пристрою і його характеристики.
                Реалізуйте для кожного з класів методи:
                ■ Sound — видає звук пристрою (пишемо текстом у
                консоль);
                ■ Show — відображає назву пристрою;
                ■ Desc — відображає опис пристрою.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Teapot teapot = new Teapot("Чайник", "Кипятить воду!");
                Microwave microwave = new Microwave("Мікрохвильовка", "Нагріває їжу!");
                Car car = new Car("Машина", "Швидко доставляє користувача з точки А в точку Б!");
                Steamboat steamboat = new Steamboat("Пароплав", "Перевозить людей і вантаж через воду!");

                teapot.Show();
                teapot.Desc();
                teapot.Sound();
                microwave.Show();
                microwave.Desc();
                microwave.Sound();
                car.Show();
                car.Desc();
                car.Sound();
                steamboat.Show();
                steamboat.Desc();
                steamboat.Sound();
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