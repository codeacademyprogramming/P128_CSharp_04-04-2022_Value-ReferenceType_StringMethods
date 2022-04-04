using System;

namespace P128MethodSignatureMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(5.7, 7.2, 8.3,9);
        }


        //Method Signature
        //Method Name
        //Method Parametr Type
        //Method Paramethr Count
        //Method Parametr Order
        static void Sum(int a, int b)
        {

        }

        static void Sum(int a, int b, int c)
        {

        }
        //Methdo Overload - Same Name Of Method
        //Method Parametr Type - Different Or
        //Method Paramethr Count - Different Or
        //Method Parametr Order - Dirfferent
        static void Sum(double a, double b)
        {

        }

        static void Sum(double a, double b, double c, int d)
        {

        }

        static void Sum(int a, double b, double c, double d)
        {

        }
    }
}
