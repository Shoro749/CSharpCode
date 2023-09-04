using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Футбольна Команда». Клас має містити
інформацію про гравців футбольної команди. Реалізуйте
підтримку ітератора для класу «Футбольна Команда».
Протестуйте можливість використання foreach для класу
«Футбольна Команда».*/

namespace CSharpCode
{
    public class FootballTeam
    {
        private Dictionary<int, string> team = new Dictionary<int, string>();

        public FootballTeam(string plDesc)
        {
            team[1] = plDesc;
        }

        public void AddTeammate(int id, string desc)
        {
            team[id] = desc;
        }

        public void RemoveTeammate(int id)
        {
            team.Remove(id);
        }

        public void ToString()
        {
            foreach (var teammate in team) 
            {
                Console.WriteLine($"\nГравець з номером {teammate.Key} на ім'я {teammate.Value}");
            }
        }
    }
}
