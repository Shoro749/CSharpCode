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