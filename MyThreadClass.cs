using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MoratallaLabMidterm
{
    class MyThreadClass
    {


        public static void Thread1()
        {
            for (int i = 0; i < 6; i++)
            {

                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process" + " = " + i);

                

            }
        }
    }


  



}
