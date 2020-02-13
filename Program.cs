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
            int x = int.Parse(x_str);
            int y = int.Parse(y_str);
            int z = x + y;
            //Console.WriteLine("{0}+{1}={2}",x,y,z);
            Console.WriteLine($"{x}+{y}={z}");
            Console.ReadLine();

        }
    }
}
