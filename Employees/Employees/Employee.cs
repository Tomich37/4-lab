using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        //Методы
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        //Свойства
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }


        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Имя должно быть меньше 16 символов");
                }
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
    }
}
