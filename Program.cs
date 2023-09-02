using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Будинок», в якому має міститися інформація про квартири в цьому будинку. Створіть клас
                «Квартира» з інформацією про мешканців квартир. Реалізуйте підтримку ітератора для класів «Будинок» і «Квартира». 
                Протестуйте можливість використання foreach для
                класів «Будинок» і «Квартира».*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                House house = new House();
                house.OutPut();
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