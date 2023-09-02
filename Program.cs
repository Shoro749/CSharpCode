using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Алфавіт», в якому мають міститися
                літери англійського алфавіту. Реалізуйте підтримку ітератора. Протестуйте можливість використання foreach
                для класу «Алфавіт».*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] arr = new string[26] { "a", "b", "c", "d", "e", "f", "g",
                "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z"};

                ABC abc = new ABC(arr);
                abc.OutPut();
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