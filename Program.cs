using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting(0);

        }

        static void greeting(int message)
        {
            if (message == 1)
                Console.WriteLine("Hello World");
            if (message == 2)
                Console.WriteLine("Hello Mars");
			if (message == 3)
				Console.WriteLine("Hello Venus");
            else
                Console.WriteLine("No Greeting");
        }
    }
}
