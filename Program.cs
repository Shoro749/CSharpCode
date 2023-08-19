using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Запрограмуйте клас Money (об'єкт класу оперує однією
                валютою) для роботи з грошима.
                У класі мають бути передбачені: поле для зберігання
                цілої частини грошей (долари, євро, гривні тощо) і поле
                для зберігання копійок (центи, євроценти, копійки тощо)
                Реалізувати методи виведення суми на екран, задання
                значень частин.
                На базі класу Money створити клас Product для роботи
                з продуктом або товаром. Реалізувати метод, який дозволяє
                зменшити ціну на задане число.
                Для кожного з класів реалізувати необхідні методи і
                поля.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Product product = new Product(5000, 95, 2000, 90, 50000, 95);
                product.Tostring();
                product.ProductInfo();
                product.Discount();
                product.Payment();
                product.ProductInfo();
                product.Tostring();
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