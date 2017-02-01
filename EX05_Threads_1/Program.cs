using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EX05_Threads_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Thread firstThread = new Thread(new ThreadStart(FirstThread));
            firstThread.Start();

            }
      static void FirstThread()
            {

            for (int i = 0; i<5; i++)
                {
                Console.WriteLine("C# thread is easy");
                Thread.Sleep(2000);

                }
            Console.ReadKey();
            }
        }
    }
