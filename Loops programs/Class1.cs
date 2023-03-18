using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcmGcd
{
    internal class Class1
    {
        public void lcm()
        {
            int lcm = 0; int gcd = 0;
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            for(int i = num2; i <= num1 * num2; i++)
            {
                if(i%num1==0 && i % num2 == 0)
                {
                    lcm = i;
                    break;
                }
            }
            Console.WriteLine("LCM = " + lcm);

            gcd = num1 * num2 / lcm;
            Console.WriteLine("gcd = " + gcd);
        }
    }
}
