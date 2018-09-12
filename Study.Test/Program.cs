using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(Write);
            Console.ReadKey();

        }
        private static void Write()
        {
            Console.WriteLine("异步编程");
        }
    }
}
