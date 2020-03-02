using System;
using System.Threading;

namespace t1904a.lab3
{
    public class Program
    {
        public static bool flag = false;
        static void Main(string[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Thread t1 = new Thread(findFibo);
            t1.Start(n);
            Thread t2 = new Thread(count);
            t2.Start();
        }

        public static void findFibo(Object n)
        {
            Int32 na = Convert.ToInt32(n);
            int f1 = 1,f2 = 2,fn = 0;
            while (f1 + f2 < na)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;                
                Thread.Sleep(100);

            }
            Program.flag = true;
            Console.WriteLine(fn);
        }
        public static void count()
        {
            int i = 0;
            while (true)
            {
                i++;
                if (Program.flag)
                {
                    
                    Console.WriteLine(i*100 + "milis");
                    return;
                }
                Thread.Sleep(100);
            }
            
        }
    }
}