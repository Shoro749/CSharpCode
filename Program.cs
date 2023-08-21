using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

///*Створити базовий клас «Музичний інструмент» і похідні
//класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
//допомогою конструктора, встановити назву до кожного
//музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо
//текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного
//інструменту.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Violin violin = new Violin("Скрипка", "Струнний музичний смичковий інструмент.", "Майстрові", 60, 3000, "YAMAHA");
                Trombone trombone = new Trombone("Тромбон", "Музичний інструмент сімейства мідних духових.", "Тенор", 160000, "YAMAHA");
                Ukulele ukulele = new Ukulele("Укулеле", "Гавайський чотириструнний різновид гітари, що використовується для акордового " +
                    "супроводу пісень та гри соло.", "Сопрано", 53, 1000, "Bodasan");
                Cello cello = new Cello("Віолончель", "Струнний смичковий музичний інструмент, родини скрипкових, басо-тенорового " +
                    "регістру.", "акустичний", 76, 11000, "Maxtone");

                MusicInstrument[] musicInstrument = { violin, trombone, ukulele, cello };
                foreach (var instruments in musicInstrument)
                {
                    instruments.Show();
                    instruments.Desc();
                    instruments.Sound();
                    instruments.History();
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