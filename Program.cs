using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        delegate void Numbers(int[] arr);
        static void EvenNumbers(int[] arr)
        {
            Console.Write("Парні числа: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        static void NotEvenNumbers(int[] arr)
        {
            Console.Write("Непарні числа: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        static void SimpleNumbers(int[] arr)
        {
            bool check = true;
            Console.Write("Прості числа: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        check = false;
                    }
                }
                if (check) { Console.Write(arr[i] + " "); }
            }
        }

        static void Fibonacci(int[] arr)
        {
            Console.Write("Числа Фібоначі: ");
            for (int j = 0; j < arr.Length ; j++)
            {
                int num1 = 0, num2 = 1;
                while (true)
                {
                    if (arr[j] == num1 || arr[j] == num2) { Console.WriteLine(arr[j] + " "); break; }
                    num1 += num2;
                    num2 += num1;
                    if (arr[j] < num1 && arr[j] < num2) { break; }
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {

/*Створіть набір методів для роботи з масивами:
■ Метод для отримання усіх парних чисел у масиві;
■ Метод для отримання усіх непарних чисел у масиві;
■ Метод для отримання усіх простих чисел у масиві;
■ Метод для отримання усіх чисел Фібоначчі в масиві.
Використовуйте механізми делегатів.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] arr = new int[10];
                Console.WriteLine("Масив: ");
                for (int i = 0;i < arr.Length;i++)
                {
                    arr[i] = rnd.Next(0, 100);
                    Console.Write(arr[i] + " ");
                }

                Numbers num = new Numbers(EvenNumbers);
                num += NotEvenNumbers;
                num += SimpleNumbers;
                num += Fibonacci;

                Console.WriteLine();
                foreach (var item in num.GetInvocationList())
                {
                    Console.WriteLine(item.DynamicInvoke(arr));
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