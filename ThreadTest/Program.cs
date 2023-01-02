using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(thread1);
            t1.IsBackground = true;
            t1.Start();
            Console.ReadKey();
        }
        private static void thread1() {
            int step = 0;
            int i = 0;
            while (true) {
                switch (step) {
                    case 0:
                        step=1;
                        Console.WriteLine("这是第1步");
                        Console.WriteLine("这是一个测试");
                        break;
                    case 1:
                        Console.WriteLine("这是第2步");
                        step = 2;
                        break;
                    case 2:
                        Console.WriteLine("这是第3步");
                        step = 3;
                        break;
                    case 3:
                        Console.WriteLine("这是第4步");
                        step = 0;
                        break;
                }
                i++;
                if (i == 10000) break;
            }
        }
    }
}
