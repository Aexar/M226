using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM
{
    class Program
    {
        static void Main(string[] args)
        {

            Client john = new Client("John", new BillingPlanVIP(10));

            john.Add(new Beverage("Guiness", 8, 50));
            john.Add(new Beverage("Guiness", 8, 50));
            john.Add(new Beverage("Guiness", 8, 50));

            System.Console.Write("Bill of John : " + john.GetBill());

            Client jane = new Client("Jane", new BillingPlanStandard());

            jane.Add(new Beverage("Coca", 3, 50));
            jane.Add(new Beverage("Pepis", 4, 50));
            jane.Add(new Beverage("Guiness", 8, 50));

            System.Console.Write("Bill of Jane : " + jane.GetBill());
        }
    }
}
