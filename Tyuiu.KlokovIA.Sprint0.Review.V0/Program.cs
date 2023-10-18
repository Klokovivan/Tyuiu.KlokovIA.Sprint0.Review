using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KlokovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KlokovIA.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("X = " + x);
            int y = 4;
            Console.WriteLine("V = " + y);
            int z = 6;
            Console.WriteLine("Z = " + z);

            Console.WriteLine("Результат = " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
