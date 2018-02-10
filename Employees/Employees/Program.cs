using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            Salesperson jill = new PTSalesperson("Jill", 834, 3002, 100000, "111-12-1234", 90);
            GivePromotion((Manager)frank);
            GivePromotion(moonUnit);
            GivePromotion(jill);
            Salesperson prototypeSaleperson = frank as Salesperson;
            if (prototypeSaleperson == null)
                Console.WriteLine("Sorry, frank is not a Salesperson");

        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted", emp.Name);
            if (emp is Salesperson)
            {
                Console.WriteLine("{0} made {1}, sale(s)!", emp.Name, 
                    ((Salesperson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, 
                    ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
           
            Salesperson fran = new Salesperson("Fran", 43, 93, 3000, "932-23-2322", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            CastingExamples();

            Console.ReadLine();
        }
    }
}
