using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Футбольна Команда». Клас має містити
                інформацію про гравців футбольної команди. Реалізуйте
                підтримку ітератора для класу «Футбольна Команда».
                Протестуйте можливість використання foreach для класу
                «Футбольна Команда».*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                FootballTeam team = new FootballTeam("Боб, у команді 65 днів!");
                team.AddTeammate(2, "Пітер, у команді тиждень!");
                team.AddTeammate(3, "Патрік, у команді місяць!");
                while (true)
                {
                    bool exit = false;
                    Console.WriteLine("1) Додати нового гравця в команду");
                    Console.WriteLine("2) Вигнати гравця з команди");
                    Console.WriteLine("3) Показати інформацію про команду");
                    Console.WriteLine("4) Закрити програму");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch(select)
                    {
                        case 1:
                            Console.Write("\nВведіть номер гравця: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть ім'я та скільки состоїть в команді: ");
                            string? desc = Convert.ToString(Console.ReadLine());
                            team.AddTeammate(num, desc);
                            break;

                        case 2:
                            Console.Write("\nВведіть номер гравця: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            team.RemoveTeammate(num);
                            break;

                        case 3:
                            team.ToString();
                            break;

                        case 4:
                            exit = true;
                            break;
                    }

                    if (exit) { break; }
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