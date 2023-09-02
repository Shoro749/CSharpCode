using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму. Створіть клас для кожної істоти
                Океанаріуму. Вони мають містити інформацію про кожну
                морську істоту. Реалізуйте підтримку ітератора для класу
                «Океанаріум». Протестуйте можливість використання
                foreach для Океанаріуму.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Shark shark = new Shark(26, 18, "море/океан", "Представники хрящових риб з обтічним видовженим тілом.");
                Turtle turtle = new Turtle(46, 18, 36, "вода/суша", "Основна особливість " +
                    "черепах - це їхній панцир, який служить захистом від " +
                    "хижаків і допомагає їм регулювати температуру тіла. " +
                    "Вони мають чотири короткі ноги з кігтями або плавцями в залежності від того, чи вони живуть на суші чи в воді.");
                Fish fish = new Fish("Риба клоун", 14, 90, "Тихий та Індійський океани", "Підродина риб родини Помацентрових, що живуть у симбіозі з актиніями.");
                Oceanarium oceanarium = new Oceanarium();
                oceanarium.add(shark, turtle, fish);
                oceanarium.ShowInfo();
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