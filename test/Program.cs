using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal sealed class Foo
    {
        private readonly int _id = 100;
        public int id => _id;
        public int Calculate()
        {
            
            Console.WriteLine("Some test");

            #if (DEBUG == true)
            global::System.Console.WriteLine(  "Debug!");
            #endif

            int a = 100;
            int b = 200;
            int result = a + b;
            Console.WriteLine($"Result is {result}");
            return result;
        }

        static void Main(string[] args)
        {

            Foo foo = new Foo();
            foo.Calculate();

            Console.ReadKey();
        }
    }
}
