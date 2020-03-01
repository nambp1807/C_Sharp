using System;
using System.Threading;

namespace t1904a.Multithread
{
    public class DemoMultithread
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(RunInThread);
            t1.Start("object demo");
            
            Thread t2 = new Thread(new DemoMultithread().RunInThread2);
            //Main Thread
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine("Main Run...."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        public static void RunInThread(object o)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine("Run..."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e) { }
            }
        }


        public void RunInThread2()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine("Run.2.."+i);
                    Thread.Sleep(100);
                }
                catch (Exception e) { }
            }
        }
    }
}