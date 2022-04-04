using System;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task - 8
            //İsdifadəçi 2 Dənə Ədəd Daxil Edir. Daxil Edilən Ədədlərdə Daxil Olmaqla
            //Bu Ədədlərin Aralığında Olan Ədədlərin Çəmin Tapan Alqoritm Qurun.
            //Console.WriteLine("Birinci Deyeri Daxil Et:");
            //string num1Str = Console.ReadLine();
            //Console.WriteLine("Ikinci Deyeri Daxil Et:");
            //string num2Str = Console.ReadLine();
            //try
            //{
            //    int num1 = int.Parse(num1Str);
            //    int num2 = int.Parse(num2Str);

            //    SumInterval(num1, num2);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yalniz Reqem Daxil Edile Biler");
            //}
            #endregion

            #region Task - 9
            //İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri.
            //m Ədədinin n Qüvvətini Tapan Alqoritm Qururn.

            //Console.WriteLine("m deyerini Daxil Et");
            //string num1Str = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("n deyerini Daxil Et");
            //string num2Str = Console.ReadLine();
            ////Console.BackgroundColor = ConsoleColor.Red;
            ////Console.ForegroundColor = ConsoleColor.Green;
            ////Console.WindowTop = 0;
            ////Console.Clear();

            //try
            //{
            //    int num1 = int.Parse(num1Str);
            //    int num2 = int.Parse(num2Str);

            //    Pow(num1, num2);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            double a1 = 5;
            double a2 = 6;
            double a3 = 7;
            double a4 = 8;
            double a5 = 10;

            double result = (a1 + a2 + a3 + a4 + a5) / 5;
            Console.WriteLine(result);
        }

        #region Task - 8
        //İsdifadəçi 2 Dənə Ədəd Daxil Edir. Daxil Edilən Ədədlərdə Daxil Olmaqla
        //Bu Ədədlərin Aralığında Olan Ədədlərin Çəmin Tapan Alqoritm Qurun.
        static void SumInterval(int a, int b)
        {
            //int min = 0;
            //int max = 0;
            //int sum = 0;

            int min = 0, max = 0, sum = 0;

            if (a != b)
            {
                if (a > b)
                {
                    min = b;
                    max = a;
                }
                else
                {
                    min = a;
                    max = b;
                }

                while (min <= max)
                {
                    sum += min;
                    min++;
                }

                Console.WriteLine($"Cemi: {sum}");
                return;
            }
            else
            {
                Console.WriteLine("Daxil Edilen Ededler Beraberdir.");
            }
        }

        #endregion

        #region Task - 9
        //İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri.
        //m Ədədinin n Qüvvətini Tapan Alqoritm Qururn.
        static void Pow(int m, int n)
        {
            int pow = 1;

            if (m > 0 && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    pow = pow * m;
                }
            }

            Console.WriteLine(pow);
        }
        #endregion
    }
}





