using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            bool condition = true;
            byte number4 = 255;   // 8 bit  0 --> 255
            short number3 = -32768;  // 16 bit  -32768 --> 32767
            int number1 = 2147483647;  // 32 bit  -2147483648 --> 2147483647
            long number2 = 9223372036854775807;  // 64 bit  -9223372036854775808 --> 9223372036854775807

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.ReadLine();
        }
    }
}
