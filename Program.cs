using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Для масиву цілих реалізуйте наступні запити:
                 Отримати весь масив цілих.
                 Отримати парні цілі.
                 Отримати непарні цілі.
                 Отримати значення більше заданого.
                 Отримати числа в заданому діапазоні.
                 Отримати числа, кратні семи. Результат відсортуйте за
                зростанням.
                 Отримати числа, кратні восьми. Результат відсортуйте за
                спаданням.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] arr = new int[6];
                Console.WriteLine("Array: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(0, 100);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");

                Console.WriteLine("1) Отримати весь масив цілих");
                Console.WriteLine("2) Отримати парні цілі");
                Console.WriteLine("3) Отримати непарні цілі");
                Console.WriteLine("4) Отримати значення більше заданого");
                Console.WriteLine("5) Отримати числа в заданому діапазоні");
                Console.WriteLine("6) Отримати числа, кратні семи");
                Console.WriteLine("7) Отримати числа, кратні восьми");
                Console.Write("Введіть свій вибір: ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.Write("\nArray:");
                        var numbers = from x in arr
                                      select x;
                        foreach (int x in numbers)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("\nПарні числа:");
                        var numbers1 = from x in arr
                                       where x % 2 == 0
                                       select x;
                        foreach (int x in numbers1)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("\nНепарні числа:");
                        var numbers2 = from x in arr
                                       where x % 2 == 1
                                       select x;
                        foreach (int x in numbers2)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("\nВведіть число: ");
                        sel = Convert.ToInt32(Console.ReadLine());
                        var numbers3 = from x in arr
                                       where sel < x
                                       select x;
                        Console.Write($"Числа більші за {sel}:");
                        foreach (int x in numbers3)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        int temp;
                        Console.Write("\n1) Введіть число: ");
                        sel = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2) Введіть число: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (sel > num)
                        {
                            temp = sel;
                            sel = num;
                            num = temp;

                        }
                        var numbers4 = from x in arr
                                       where sel < x
                                       where x < num
                                       select x;
                        Console.Write($"Числа в діапазоні від {sel} до {num}:");
                        foreach (int x in numbers4)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("\nЧисла кратні сіми:");
                        var numbers5 = from x in arr
                                       where x % 7 == 0
                                       orderby x ascending
                                       select x;
                        foreach (int x in numbers5)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("\nЧисла кратні вісьми:");
                        var numbers6 = from x in arr
                                       where x % 8 == 0
                                       orderby x descending
                                       select x;
                        foreach (int x in numbers6)
                        {
                            Console.Write(" " + x);
                        }
                        Console.WriteLine();
                        break;
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