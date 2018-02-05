using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //Поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        public int Age
        {
            get { return empAge;  }
            set { empAge = value; }
        }

        // Метод доступа (get)
        public string GetName()
        {
            return empName;
        }

        //Метод изменения (set)
        public void SetName (string name)
        {
            //Перед присваиванием проверить входное значение
            if (name.Length > 15)
            {
                //Вывод ошибки
                Console.WriteLine("Error! Name must be less than 16 characteres!");
            }
            else
            {
                empName = name;
            }
        }

        //Конструкторы
        public Employee() {}
        public Employee(string name, int id, float pay)
            :this(name, 0, id, pay) { }
        public Employee (string name, int age, int id, float pay )
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }

        // Методы
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Age: {0}", empAge);
        }
    }
}
