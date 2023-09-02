using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                /*Створіть клас «Будинок», в якому має міститися інформація про квартири в цьому будинку. Створіть клас
                «Квартира» з інформацією про мешканців квартир. Реалізуйте підтримку ітератора для класів «Будинок» і «Квартира». 
                Протестуйте можливість використання foreach для
                класів «Будинок» і «Квартира».*/

namespace CSharpCode
{
    public class House
    {
        Dictionary<int, List<string>> apartments = new Dictionary<int, List<string>>();
        
        public House() 
        {
            apartments.Add(1, new List<string> { "Bob", "Alice" });
            apartments.Add(2, new List<string> { "Patric", "Tom", "Barbara" });
            apartments.Add(3, new List<string> { "Andrew" });
        }

        public House(string[] names)
        {
            apartments.Add(1, new List<string> { names[0], names[1] });
            apartments.Add(2, new List<string> { names[2], names[3], names[4] });
            apartments.Add(3, new List<string> { names[5] });
        }

        public void OutPut()
        {
            foreach (var kvp in apartments)
            {
                int key = kvp.Key;
                List<string> values = kvp.Value;

                Console.Write($"\nВ квартирі номер {key} проживають ");

                foreach (string value in values)
                {
                    Console.Write($"{value}, ");
                }
            }
        }
    }
}
