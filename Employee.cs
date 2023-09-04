using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Employee
    {
        private string NSM;
        private string birthday;
        private int telephone;
        private string email;
        private string position;
        private string JobDescription;

        public Employee(string nSM, string birthday, int telephone, string email, string position, string jobDescription)
        {
            NSM = nSM;
            this.birthday = birthday;
            this.telephone = telephone;
            this.email = email;
            this.position = position;
            JobDescription = jobDescription;
        }

        public void getInfo()
        {
            Console.WriteLine($"ПІБ: {NSM}\nДата народження: {birthday}\nНомер телефону: {telephone}\n" +
                $"Емейл: {email}\nПосада: {position}\nОпис службових обов’язків:{JobDescription}\n");
        }
    }
}
