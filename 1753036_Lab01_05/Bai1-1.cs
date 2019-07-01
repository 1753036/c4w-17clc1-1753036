using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTTH01_SumS_n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            string s = Console.ReadLine();
            uint n = 1;

            if (!uint.TryParse(s, out n))
            {
                n = 1;
            }

            Console.WriteLine();
            Console.WriteLine("S({0}) = {1}", n, TinhSn(n));

            Thread.Sleep(1000);
        }

        static double TinhSn(uint n)
        {
            double s = 0;

            for (; n > 0; --n)
            {
                s = Math.Sqrt(s + n);
            }

            return s;
        }
    }
}
