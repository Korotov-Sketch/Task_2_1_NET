using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class User
    {
        public string name;
        public string surname;
        public string patronymic;
        public int Day;
        public int Month;
        public int Year;
        public int Age;
        

        public User()
        {
            name = "Иван";
            surname = "Иванов";
            patronymic = "Иванович";
            Day = 1;
            Month = 1;
            Year = 1999;
            Age = 21;
        }
        public User(string nam, string surnam, string patronym, int D, int M, int Y, int A)
        {
            name = nam;
            surname = surnam;
            patronymic = patronym;
            Day = D;
            Month = M;
            Year = Y;
            Age = A;
        }

        public virtual string GetAllInfo()
        {
            return surname + " " + name + " " + patronymic + "\n" + Age + "." + Month + "." + Year;
        }
        public string GetNames()
        {
            return surname + " " + name + " " + patronymic;
        }
        public int GetAge()
        {
            return Age;
        }

        public string GetBirthDate()
        {
            return Age + "." + Month + "." + Year;
        }
    }
}
