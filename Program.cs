using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello WODLD");
            //Console.ReadLine();
            Console.Write("Введите x>");
            String x_str = Console.ReadLine();
            Console.Write("Введите y>");
            String y_str = Console.ReadLine();
            double x = double.Parse(x_str);
            double y = double.Parse(y_str);
            double z = x / y;
            Console.WriteLine("{0}+{1}={2:0.00##}",x,y,z);
            //Console.WriteLine($"{x}/{y}={z}");
            Console.ReadLine();

        }
    }
}
