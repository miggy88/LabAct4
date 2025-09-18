using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAct4
{
    

    internal class MyThreadClass
    {
        public static void ThreadA()
        {
            Thread.CurrentThread.Name = "ThreadA";
            
            for (int i = 1; i<= 5; i++)
            {
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " = " + i);

                Thread.Sleep(1500);
            }
            Console.WriteLine(Thread.CurrentThread.Name + "has finished. ");
        }

        public static void ThreadB()
        {
            Thread.CurrentThread.Name = "ThreadB";
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " = " + i);
                Thread.Sleep(1500);
            }
            Console.WriteLine(Thread.CurrentThread.Name + "has finished. ");
        }


        public static void Thread1()
        {

            Thread tA = new Thread(ThreadA);
            Thread tB = new Thread(ThreadB);

            tA.Start();
            tB.Start();

            tA.Join();
            tB.Join();

            Console.WriteLine("Both threads have completed. Main thread terminating.");






            Thread.CurrentThread.Name = "Thread1";

            for (int loopCount = 1; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }

            Console.WriteLine("Thread1 loop terminated after 5 attempts. ");

        }
        class Program
        {
            static void Main(string[] args)
            {
                MyThreadClass.Thread1();
            }
        }

    }
}
