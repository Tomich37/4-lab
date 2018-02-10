using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Salesperson : Employee
    {
        public Salesperson() { }
        public Salesperson(string fullName, int age, int empID,
                        float currPay, string ssn, int numbOfSales)
            :base(fullName, age, empID, currPay, ssn)
        {
           SalesNumber = numbOfSales;
        }

        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of stock option: {0}", SalesNumber);
        }
        public int SalesNumber { get; set; }
    }
}
