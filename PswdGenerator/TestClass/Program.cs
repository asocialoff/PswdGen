using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PswdGenerator;

namespace TestClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PswdGen.Generate(8, 16, true, true, true, true, 2, 2, 2, 2));
            Thread.Sleep(200000);
        }
    }
}
