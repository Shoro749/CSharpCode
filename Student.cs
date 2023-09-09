using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace CSharpCode
{
    public class Student
    {
        public string _name;
        public string _surname;
        public int _age;
        public string _school;

        public Student(string name, string surname, int age, string school) 
        {
            _name = name;
            _surname = surname;
            _age = age;
            _school = school;
        }
    }
}
