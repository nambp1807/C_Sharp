using System;
using System.Threading;

namespace t1904a.lab4
{
    public class Lab4
    {
            
        static void Main(string[] args)
        {
            Thread t1 =new Thread(donghodemnguoc);
            t1.Start();
        }

        public static void donghodemnguoc()
        {
            for (int i = 9; i >= 0; i--)
            {
                try
                {
                    for (int j = 59; j >= 0; j--)
                    {
                        try
                        {
                            if (j < 10)
                            {
                                Console.WriteLine(i + ":" + "0" + j);
                            }
                            else
                            {
                                Console.WriteLine(i + ":" + j);
                            }

                            Thread.Sleep(10);
                            if (i == 0 && j == 0)
                            {
                                Console.WriteLine("Bum ....");
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}