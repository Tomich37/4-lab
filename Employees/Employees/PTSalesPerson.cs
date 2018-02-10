using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesperson : Salesperson
    {
        private float salaryReduction = 9/10;
        public PTSalesperson(string fullName, int age, int empID,
                        float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
        }
        //методы
        public void ReductionSalary()
        {
            currPay = currPay * salaryReduction;
        }
    }
}