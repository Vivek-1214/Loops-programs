﻿//Loops All Programs

using System;

namespace abc
{
    class program
    {

        static void Main()
        {
            //1)Reverse Programs

            Console.WriteLine("enter the  number");
            int Num=Convert.ToInt32( Console.ReadLine());
             int rev = 0;int rem;

            while (Num>0) {

                rem = Num % 10;              //it select last digit
                rev = rev*10 + rem;
                Num = Num / 10;               //it remove last digit

             }Console.WriteLine(rev +" is reverse number");



            /*2) palindrom  = A palindromic number  is a number (such as 16461) that remains the same when its digits are reversed. 

            Console.WriteLine("enter the  number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int rev = 0;  int rem; int copyNum = Num;

            while (Num > 0)
            {
                rem = Num % 10;
                rev = rev * 10 + rem;
                Num = Num / 10;

            }
            if (rev == copyNum)
            {
                Console.WriteLine("entered number is palindrom");
            }
            else
            {
                Console.WriteLine("entered number is not palindrom");
            }


        }*/

            /*3)Armstrong  =An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal
            //to the number itself. For example, 371 is an Armstrong number since 3**3 + 7**3 + 1**3 = 371
            // ex.0,1,153,370,371,407

            Console.WriteLine("enter the  number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int rem; int cube; int sumcube = 0; int copyNum = Num;

            while (Num > 0)
            {
                rem = Num % 10;
                cube = rem * rem * rem;
                sumcube = sumcube + cube;
                Num = Num / 10;
             }
            if (sumcube == copyNum)
            {
                Console.WriteLine("entered number is Armstrong");
            }
            else
            {
                Console.WriteLine("entered number is not Armstrong");
            }*/

            /*4)factorial =Factorial of a positive integer (number) is the sum of multiplication of all the integers
            //smaller than that positive integer. For example, factorial of 5 is 5 * 4 * 3 * 2 * 1 which equals to 120

            int Num1 = 5;

            int fact = 1; int i = 1;

            while (Num1 >= i)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(fact);*/

            /*5)prime number= it is no. which is divisible by only two number which 1 and itself

            int n = 5; int count = 0; int i = 1;

            while (n >= i){
                if (n%i==0)
                {
                    count++;

                }
                i++;

            }
            if (count<=2)
            {
                Console.WriteLine(n +" is prime number");
            }
            else
            {
                Console.WriteLine(n + " is composite number");
            }*/

            /*6) Fibonacci sequence  = Fibonacci sequence, in which each number is the sum of the two preceding ones.
            //The sequence commonly starts from 0 and 1

            Console.WriteLine("enter the  number");
            int Leng = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c; int i=2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            while (Leng>i)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                i++;
                
            }*/

           /* 7)C# Program to Convert Number in Characters
            Console.WriteLine("Enter number :");                         //345
            int Num = Convert.ToInt32(Console.ReadLine());
            int r;int rev = 0;
            if (Num >= 0)
            {
                r = Num % 10;
                rev = rev * 10 + r;
                Num = Num / 10;
            }
            Console.WriteLine(rev);                                          //543
            Num = rev;
            for(int i = 0; i <= Num; i++) {
                if (Num >= 0)
                {
                    r = Num % 10;

                    switch (r)
                    {
                        case 1:
                            Console.Write("one ");
                            break;
                        case 2:
                            Console.Write("two ");
                            break;
                        case 3:
                            Console.Write("three ");
                            break;
                        case 4:
                            Console.Write("four ");
                            break;
                        case 5:
                            Console.Write("five ");
                            break;
                        case 6:
                            Console.Write("six ");
                            break;
                        case 7:
                            Console.Write("seven ");
                            break;
                        case 8:
                            Console.Write("eight ");
                            break;
                        case 9:
                            Console.Write("nine ");
                            break;
                        case 0:
                            Console.Write("zero ");
                            break;
                        default:
                            Console.Write("tttt ");
                            break;
                    }
                    Num = Num / 10;
                }

            }*/


        }
    }
}



