using System;

namespace _27._10.Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine("Enter  number");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number");
            //int b =Convert.ToInt32(Console.ReadLine());


            //Arg(a, b);

            #endregion

            #region Task 2
            // Console.WriteLine("Enter the number");
            //int a=Convert.ToInt32(Console.ReadLine());

            // Args(a);

            #endregion

            #region Task 3
            //Console.WriteLine("Enter the number");
            //int a=Convert.ToInt32(Console.ReadLine());

            //Argu(a);
            #endregion

            #region Taks 4

            //Console.WriteLine("enter the number");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the index");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Argus(a, b);

            #endregion

            #region Task 5

            //Console.WriteLine("enter the number to convert");
            //int n=Convert.ToInt32( Console.ReadLine());


            //Arguse(n);
            #endregion

            #region Task 6
            //Console.WriteLine("enter the number find the cube");
            //int n=Convert.ToInt32(Console.ReadLine());

            //cub(n);
            #endregion

            #region Task 7

            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());


            //total(n);
            #endregion

            #region Task 8

            //Console.WriteLine("enter the number");
            //string a = Console.ReadLine();
            

            //taks(a);
            #endregion

            #region Task 9
            //string a = Console.ReadLine();
            //int b = Int32.Parse(Console.ReadLine());

            //Console.Clear();
            


            //for (int i = 0, c = b; i < b; i++)
            //{

            //   for (int j = 0; j <c; j++)
            //    {
            //        Console.Write(a);

            //    }
            //    Console.WriteLine();
            //    c--;
            //}


            #endregion

        }
        static void Arg(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"Fisrt number {a} second number {b}");

            }
            else
            {
                Console.WriteLine($"Fisrt number {b} second number {a}");
            }



        }

        static int Args(int a)
        {
            int b = a;
            int sum = 0;
            while (a > 0)
            {

                sum = sum + a % 10;
                a = a / 10;



            }
            Console.WriteLine($"The sum of the digits of the number  {b}: is {sum}");
            return sum;


        }

        static void Argu(int a)
        {

            int f = 1;
            for (int i = 1; i <= a; i++)
            {

                f = f * i;
            }

            Console.WriteLine($"The factorial {a} is {f}");

        }

        static int Argus(int a, int b)
        {

            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = a % 10;
                a = a / 10;

            }
            Console.WriteLine($" {b} index number {c}");
            return c;
        }

        static void Arguse(int n)
        {
            //int[] a = new int[10];
            //for (int i = 0; n > 0; i++)
            //{
            //    a[i] = n % 2;
            //    n = n / 2;
            //}
            //for (int i = i - 1; i >= 0; i--)
            //{
            //    Console.Write($"Binary of the given number={a[i]} ");
            //}

        }

        static int cub(int n)
        {
            int c = 1;
            for (int i = 1; i <= 3; i++)
            {
                c = c * n;

            }
            Console.WriteLine($"the number {n} the cube is {c}");
            return c;

        }
        static int total(int n)
        {
            int c = n;
            int sum = 0;
            while (n > 0)
            {

                n = n / 10;
                sum = sum + 1;

            }


            Console.WriteLine($"{c} ededinin  sayi {sum}");
            return sum;


        }

        static void taks(string a)
        {
            int n = 5;
            int sum = 0;
            string Str = " ";
            for (int i = 0; i < n; i++)
            {


                Str = Str + a;
                sum += Convert.ToInt32(Str);
            }
            Console.WriteLine(sum);




        }


        
    }
}
