using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Кредитна картка». Клас повинен містити:
                ■ Номер картки;
                ■ ПІБ власника;
                ■ Термін дії карти;
                ■ PIN;
                ■ Кредитний ліміт;
                ■ Сума грошей.
                Створіть потрібний набір способів класу. Реалізуйте
                події для наступних ситуацій:
                ■ Поповнення рахунку;
                ■ Витрата коштів з рахунку;
                ■ Старт використання кредитних коштів;
                ■ Досягнення ліміту заданої суми грошей;
                ■ Зміна PIN.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                CreditCard creditCard = new CreditCard("1234 5678 9012 3456", "Fullname", "08/27", 1234, 1000, 500);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("1) Показати інформацію про карту");
                    Console.WriteLine("2) Поповнити баланс");
                    Console.WriteLine("3) Оплатити рухунок");
                    Console.WriteLine("4) Змінити PIN код");
                    Console.WriteLine("5) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            creditCard.Info();
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.Write("Введіть суму для поповнення рахунку: ");
                            creditCard.Add(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.Write("Введіть суму для оплати: ");
                            creditCard.Subtraction(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.Write("Введіть новий PIN код: ");
                            creditCard.ChangePIN(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case 5:
                            Exit = true;
                            break;
                    }

                    if (Exit)
                    {
                        break;
                    }
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