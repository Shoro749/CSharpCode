using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void CurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Поточний час: " + currentTime.ToString("HH:mm:ss"));
        }

        static void CurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Поточна дата: " + currentDate.ToString("dd.MM.yyyy"));
        }

        static void CurrentDayOfWeek()
        {
            DateTime currentDayOfWeek = DateTime.Now;
            Console.WriteLine("Поточний день тижня: " + currentDayOfWeek.DayOfWeek);
        }

        static void AreaTriangle()
        {
            Console.Write("Введіть основу трикутника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть висоту трикутника: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площа: " + (a *h)/2);
        }

        static void AreaRectangle()
        {
            int[] arr = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Введіть сторону прямокутника: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Площа: " + arr[0] * arr[1]);
        }


        static void Main(string[] args)
        {
            try
            {
                /*Створіть набір методів:
                ■ Метод відображення поточного часу;
                ■ Метод відображення поточної дати;
                ■ Метод відображення поточного дня тижня;
                ■ Метод для підрахунку площі трикутника;
                ■ Метод для підрахунку площі прямокутника.
                Для реалізації проєкту використовуйте делегати: Action, Predicate, Func.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Action action = CurrentTime;
                action += CurrentDate;
                action += CurrentDayOfWeek;
                action += AreaTriangle;
                action += AreaRectangle;
                action();
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