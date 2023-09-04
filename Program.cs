using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Кафе» з інформацією про працівників кафе. Реалізуйте підтримку ітератора для класу
                «Кафе». Протестуйте можливість використання foreach
                для «Кафе».*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Cafe cafe = new Cafe("ПІБ", "01.01.2000", 0684645184, "gmail", "manager", "description");
                Employee employee2 = new Employee("Bob", "02.02.2000", 0654861886, "gmail", "офіціант", "опис");
                cafe.AddEmployee(employee2);
                cafe.ToString();
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