using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAct4
{
    

    internal class MyThreadClass
    {
        public static void Thread1()
        {
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
