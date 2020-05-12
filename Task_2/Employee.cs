using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Employee : User
    {
        public int experience;
        public string position;
        public Employee(string nam, string surnam, string patronym, int D, int M, int Y, int A, int exp, string pos) : base (nam, surnam, patronym, D, M, Y, A)
        {
            experience = exp;
            position = pos;
        }
        public override string GetAllInfo()
        {
            return surname + " " + name + " " + patronymic + "\n" + Age + "." + Month + "." + Year + "\n" + "Работает " + experience + " лет в должности " + position;

        }
    }
}
