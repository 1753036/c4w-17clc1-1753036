using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class MathOperations
    {
        public static decimal Cong(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Tru(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Nhan(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Chia(decimal a, decimal b)
        {
            return a / b;
        }
        public static decimal NA(decimal a, decimal b)
        {
            return 0;
        }
    }


    class DelTinhToan
    {
        delegate decimal TinhToan(decimal a, decimal b);

        static void Main(string[] args)
        {
            Random rd = new Random();
            decimal a, b;
            char c = 'a', pt;
            while (c != 'q')
            {
                TinhToan tt = LuaChonPhepToan(out pt);
                a = rd.Next(1000);
                b = rd.Next(1000);
                Console.WriteLine("\n{0} {1} {2} = {3}", a, pt, b, tt(a, b));
                Console.Write("Tiep tuc");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        static TinhToan LuaChonPhepToan(out char pt)
        {
            TinhToan tt = null;
            Console.Write("Lua chon phep tinh: ");
            pt = Console.ReadKey().KeyChar;
            switch (pt)
            {
                case '+':
                    tt = new TinhToan(MathOperations.Cong);
                    break;
                case '-':
                    tt = new TinhToan(MathOperations.Tru);
                    break;
                case '*':
                    tt = new TinhToan(MathOperations.Nhan);
                    break;
                case '/':
                    tt = new TinhToan(MathOperations.Chia);
                    break;
                default:
                    tt = new TinhToan(MathOperations.NA);
                    break;
            }

            return tt;
        }
    }
}
