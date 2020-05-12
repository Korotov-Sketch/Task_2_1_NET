using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1) Написать класс User, описывающий человека (Фамилия, Имя, Отчество, Дата рождения,
Возраст). На основе класса User создать класс Employee, описывающий сотрудника фирмы.
Дополнить класс свойствами «стаж работы» и «должность». Обеспечить нахождение
класса в заведомо корректном состоянии.
2) Создать класс Ring, описывающий кольцо, заданное координатами центра, внешним и
внутренним радиусами, а также свойствами, позволяющими узнать площадь кольца и
суммарную длину внешней и внутренней окружностей. Обеспечить нахождение класса в
заведомо корректном состоянии.*/
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User pasha = new User();
                Employee sanya = new Employee("Саня", "Усталков", "Олегович", 10, 6, 1999, 20, 5, "Начальник");
                Console.WriteLine(pasha.GetAllInfo());
                Console.WriteLine(sanya.GetAllInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
