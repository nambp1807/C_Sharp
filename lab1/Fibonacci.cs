using System;

namespace t1904a.Assigment1
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1;; i++)
            {
                if (n > Fibonaccis(i) & n < Fibonaccis(i + 1))
                {
                    Console.WriteLine(Fibonaccis(i));
                }
            }
          
        }
        public static int Fibonaccis(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonaccis(n - 1) + Fibonaccis(n - 2);
        }
    }
}