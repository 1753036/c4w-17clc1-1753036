using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    class XLTinhToan
    {
        public static void Cong(decimal a, decimal b)
        {
            Console.WriteLine("{0} + {1} = {2}",a, b, a + b);
        }
        public static void Tru(decimal a, decimal b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public static void Nhan(decimal a, decimal b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public static void Chia(decimal a, decimal b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }

    class DelXLTinhToan
    {
        delegate void KQTinhToan(decimal a, decimal b);
        static void Main(string[] agrs)
        {
            KQTinhToan tt = XLTinhToan.Cong;
            tt += XLTinhToan.Tru;
            tt += XLTinhToan.Nhan;
            tt += XLTinhToan.Chia;

            decimal v1, v2;
            char c = 'a';
            while (c != 'q')
            {
                Console.Write("Nhap vao 2 so: ");
                v1 = NhapSo();
                v2 = NhapSo();
                tt(v1, v2);
                Console.Write("Tiep tuc?");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        static decimal NhapSo()
        {
            decimal n = 0;
            string strLine = Console.ReadLine();

            if (!decimal.TryParse(strLine, out n))
            {
                n = -1;
            }

            return n;
        }
    }
}
