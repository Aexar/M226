using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFraction1
{
    public class ComputeGCD
    {

        public int ComputeGcd(int a, int b)
        {
            int gcd = 1;
            int num = 2;

            List <int> compoA = new List<int>();
            List<int> compoB = new List<int>();

            // get table for a
            while (a > 1)
            {
                if (a % num == 0)
                {
                    System.Console.Write(num + ",");
                    
                    a = a / num;
                    compoA.Add(num);
                }
                else
                {
                    num = num + 1;
                }
            }

            System.Console.WriteLine("\n ------");
            num = 2;
            // get table for b
            while (b > 1)
            {
                // if num divides b
                if (b % num == 0)
                {
                    System.Console.Write(num+",");
                    b = b / num;
                    compoB.Add(num);
                }
                else
                {
                    num = num + 1;
                }
            }

            foreach (var itemA in compoA)
            {
                foreach (var itemB in compoB)
                {
                    if (itemA == itemB)
                    {
                        gcd = gcd * itemA;
                        compoB.Remove(itemB);
                        break;
                    }
                }
            }
            return gcd;
        }


    }
}
