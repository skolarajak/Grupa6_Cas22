using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas22
{
    class Program
    {

        static void GetValueOfX(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void AddTwoNumbers(int n1, int n2, out int result, out int resultSquared)
        {
            int r = n1 + n2;
            result = r;
            resultSquared = r * r;
        }

        static int Sum(string text, params int[] numbers)
        {
            Console.WriteLine("*** {0} ***", text);
            int r = 0;
            foreach(int num in numbers)
            {
                r = r + num;
            }
            return r;
        }

        static int SumA(string text, int[] numbers)
        {
            Console.WriteLine("*** {0} ***", text);
            int r = 0;
            foreach (int num in numbers)
            {
                r = r + num;
            }
            return r;
        }

        static int Avg(params int[] numbers)
        {
            int r = 0;
            foreach(int n in numbers)
            {
                r = r + n;
            }
            return r / numbers.Length;
        }

        static double Calc(string operation, int[] numbers)
        {
            double r = 0;
            foreach(int num in numbers)
            {
                switch(operation)
                {
                    case "+":
                        r = r + num;
                        break;
                    case "-":
                        r = r - num;
                        break;
                    case "*":
                        r = r * num;
                        break;
                    case "/":
                        r = r / num;
                        break;
                    default:
                        return 0;
                        break;
                }
            }
            return r;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 10 };
            double rez = Calc("/", nums);
            Console.WriteLine("Calc() = {0}", rez);
            Console.ReadKey();
            return;

            int r = Avg(4, 4, 7, 4, 5, 100, 1, 1, 1);
            Console.WriteLine("Avg() = {0}", r);
            Console.ReadKey();
            return;

            //methods();

            int[] numbers = { 1, 5, 8, 10, 12 };
            Console.WriteLine("Vrednosti pre povecavanja za 1. Broj elemenata niza je {0}", numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Vrednost numbers[{0}] = {1}", i, numbers[i]);
                //numbers[i] = i;
            }
            Console.WriteLine("Vrednosti nakon povecavanja za 1");
            foreach(int number in numbers)
            {
                Console.WriteLine("Vrednost je {0}", number);
            }

            int result = Sum("Ovo je Sum() funkcija", 5, 8, 10, 14, 1, 7, 22, 8, 10, 22);
            Console.WriteLine("Rezultat Sum() funkcije je = {0}", result);
            int resultA = SumA("Ovo je Sum() funkcija", numbers);
            Console.WriteLine("Rezultat SumA() funkcije je = {0}", resultA);

            Console.ReadKey();
        }

        static void methods()
        {
            int a = 100;
            Console.WriteLine("Pre poziva funkcije, vrednost a = {0}", a);
            GetValueOfX(out a);
            Console.WriteLine("Nakon poziva funkcije, vrednost a = {0}", a);

            int b1 = 4, b2 = 8;
            int r1, r2;
            AddTwoNumbers(b1, b2, out r1, out r2);
            Console.WriteLine("{0} + {1} = {2}, {2}^2 = {3}", b1, b2, r1, r2);
        }
    }
}
