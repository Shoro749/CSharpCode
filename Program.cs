using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Реалізуйте тип користувача «Студент» з інформацією про ім'я,
                прізвище, вік, назву навчального закладу.
                Для масиву «Студент» реалізуйте наступні запити:
                 Отримати весь масив студентів.
                 Отримати список студентів з ім'ям Boris.
                 Отримати список студентів з прізвищем, яке починається з
                Bro.
                 Отримати список студентів, старших 19 років.
                 Отримати список студентів, старших 20 років і молодших 23
                років.
                 Отримати список студентів, які навчаються в MIT.
                 Отримати список студентів, які навчаються в Oxford, і вік
                яких старше 18 років. Результат відсортуйте за віком, за
                спаданням.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Student student1 = new Student("Bob", "Brother", 21, "Oxford");
                Student student2 = new Student("Alex", "Johnson", 19, "MIT");
                Student student3 = new Student("Boris", "Brother", 24, "Oxford");
                Student student4 = new Student("Alan", "Backer", 22, "Oxford");
                Student student5 = new Student("Moris", "Scott", 17, "MIT");

                Student[] students = new Student[] { student1, student2, student3, student4, student5 };
                Console.WriteLine("1) Отримати весь масив студентів");
                Console.WriteLine("2) Отримати список студентів з ім'ям Boris");
                Console.WriteLine("3) Отримати список студентів з прізвищем, яке починається з Bro");
                Console.WriteLine("4) Отримати список студентів, старших 19 років");
                Console.WriteLine("5) Отримати список студентів, старших 20 років і молодших 23 років");
                Console.WriteLine("6) Отримати список студентів, які навчаються в MIT");
                Console.WriteLine("7) Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років");
                Console.Write("Введіть свій вибір: ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.WriteLine("\nВсі студенти: ");
                        var studList1 = from student in students
                                        select student;
                        foreach (var stud in studList1)
                        {
                            Console.Write(stud._name + " " + stud._surname + ", ");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("\nСтуденти з ім'ям Boris: ");
                        var studList2 = from student in students
                                        where student._name == "Boris"
                                        select student;
                        foreach (var stud in studList2)
                        {
                            Console.Write(stud._name + " " + stud._surname);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        string letters = "Bro";
                        Console.Write("\nСтуденти з прізвищем які починаються на Bro: ");
                        var studList3 = from student in students
                                        where char.ToUpper(student._surname[0]) == char.ToUpper(letters[0])
                                        where char.ToUpper(student._surname[1]) == char.ToUpper(letters[1])
                                        where char.ToUpper(student._surname[2]) == char.ToUpper(letters[2])
                                        select student;
                        foreach (var stud in studList3)
                        {
                            Console.Write(stud._name + " " + stud._surname + ", ");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("\nСтуденти віком старші 19 років: ");
                        var studList4 = from student in students
                                        where student._age > 19
                                        select student;
                        foreach (var stud in studList4)
                        {
                            Console.Write(stud._name + " " + stud._surname + ", ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("\nСтуденти віком старші 20 років і молодші 23 років: ");
                        var studList5 = from student in students
                                        where student._age > 20
                                        where student._age < 23
                                        select student;
                        foreach (var stud in studList5)
                        {
                            Console.Write(stud._name + " " + stud._surname + ", ");
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("\nСтуденти які навчаються в МІТ: ");
                        var studList6 = from student in students
                                        where student._school == "MIT"
                                        select student;
                        foreach (var stud in studList6)
                        {
                            Console.Write(stud._name + " " + stud._surname + ", ");
                        }
                        Console.WriteLine();
                        break;

                    case 7:
                        var studList7 = from student in students
                                        where student._school == "Oxford"
                                        where student._age > 18
                                        orderby student._age descending
                                        select student;
                        foreach (var stud in studList7)
                        {
                            Console.Write(stud._name + " " + stud._surname + " " + stud._age + ", ");
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