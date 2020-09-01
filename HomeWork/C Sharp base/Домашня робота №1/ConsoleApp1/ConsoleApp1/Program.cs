using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool checkSimply(long n)
        {
            for (long i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int reverse_number(int number)
        {
            int n = 0;
            while (number > 0)
            {
                n = 10 * n + number % 10;
                number /= 10;
            }
            return n;
        }
        static bool checkPalindrom(int number)
        {
            int n = reverse_number(number);
            if (n == number)
                return true;
            else
                return false;
        }
        static int NOD(int Fnum, int Snum)
        {
            while ((Fnum > 0) && (Snum > 0))
                if (Fnum < Snum)
                    Snum %= Fnum;
                else
                    Fnum %= Snum;
            return Fnum + Snum;
        }
        static int NSC(int Fnum, int Snum)
        {
            return (Fnum / NOD(Fnum, Snum)) * Snum;
        }
        static void Main(string[] args)
        {
            //1


            //int sum = 0, count = 0;
            //for (int i = 3; i < 1000; i+=3)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //for (int i = 5; i < 1000; i+=5)
            //{
            //    if (i % 3 != 0)
            //    {
            //        sum += i;
            //    }
            //    count++;
            //}
            //Console.WriteLine("Sum -> " + sum);
            //Console.WriteLine("Count -> " + count);



            //2

            //int f1 = 1, f2 = 2, sum = 0, buf, count = 0;
            //while (f2 < 4000000)
            //{
            //    if (f2 % 2 == 0)
            //    {
            //        sum += f2;
            //        for (int i = 0; i < 3; i++)
            //        {
            //            buf = f2;
            //            f2 = f2 + f1;
            //            f1 = buf;
            //        }
            //        count++;
            //    }
            //}
            //Console.WriteLine("Sum -> " + sum);
            //Console.WriteLine("Count -> " + count);


            //3



            //long num = 600851475143, count = 0, max = 0;
            //long size = Convert.ToInt64(Math.Sqrt(num));
            //for (long i = 2; i <= size; i++)
            //{
            //    if (checkSimply(i))
            //    {
            //        if (num % i == 0)
            //        {
            //            max = i;
            //            count++;
            //            continue;
            //        }
            //    }
            //    count++;
            //}


            //long prime = 600851475143;
            //int count = 0;
            //long i = 2;
            //while (i < prime)
            //{

            //    if (prime % i == 0)
            //    {
            //        count++;
            //        prime = prime / i;
            //        continue;
            //    }
            //    count++;
            //    i += 1;
            //}
            //Console.WriteLine("Max -> " + prime);
            //Console.WriteLine("Count -> " + count);


            //4


            //int max = 0, count = 0;
            //for (int i = 100; i < 1000; i++)
            //{
            //    for (int j = 100; j < 1000; j++)
            //    {
            //        if (checkPalindrom(i * j))
            //        {
            //            if (max <= (i * j))
            //            {
            //                max = (i * j);
            //                count++;
            //                continue;
            //            }
            //        }
            //        count++;
            //    }
            //}
            //Console.WriteLine("Max -> " + max);
            //Console.WriteLine("Count -> " + count);


            //5

            int number = 1;
            for (int i = 2; i <= 20; i++)
            {
                number = NSC(number, i);
            }
            Console.WriteLine("Res -> " + number);
        }
    }
}