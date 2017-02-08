using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Day1DataType
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Hacker Rannk !";
            // Declare second integer, double, and String variables.
            i += Convert.ToInt32(Console.ReadLine());
            d += Convert.ToDouble(Console.ReadLine());
            s += Console.ReadLine();
            Console.WriteLine(i);
            Console.WriteLine(d.ToString("F1"));
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
