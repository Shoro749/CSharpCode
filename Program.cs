using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створити абстрактний базовий клас Worker (працівник)
                з методом Print(). Створіть чотири похідні класи: President,
                Security, Manager, Engineer. Перевизначте метод.
                Print() для виведення інформації, яка відповідає кожному типу працівника.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                President president = new President("Президент", "Голова держави в країнах з республіканською або змішаною формою правління.");
                Security security = new Security("Охоронець", "Це різновид військового спецпризначенця, державного спецслужбовця або," +
                    " найчастіше, приватного охоронця, на якого покладено обов'язки охорони і захисту особи чи групи осіб.");
                Manager manager = new Manager("Менеджер", "Керівник, керуючий - спеціаліст, зайнятий управлінням процесами " +
                    "та персоналом на певній ділянці комерційного підприємства, організації.");
                Engineer engineer = new Engineer("Інженер", "Особа, що професійно займається інженерією, тобто на основі " +
                    "поєднання прикладних наукових знань, математики та винахідництва знаходить нові рішення технічних проблем.");

                Worker[] workers = { president, security, manager, engineer };
                foreach (Worker worker in workers) 
                {
                    worker.Print();
                    Console.WriteLine();
                }
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