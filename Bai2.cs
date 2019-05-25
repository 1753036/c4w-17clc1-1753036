    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] moneyLevels = {1388, 1433, 1660, 2082, 2324, 2399};
        static int[] kWhLevels = { 50, 50, 100, 100, 100, int.MaxValue };

        static void Main(string[] args)
        {
            Console.Write("Nhap so kWh: ");
            string strLine = Console.ReadLine();
            int kWh = 0;

            if (int.TryParse(strLine, out kWh) == false)
            {
                kWh = 0;
                Console.WriteLine("Dau vao sai!");
            }

            Console.WriteLine("So tien gia dinh phai dong: {0} dong: ", TinhTienDien(kWh));
        }

        static int TinhTienDien(int kWh)
        {
            int totalMoney = 0;

            for (int i = 0; i < 6; ++i)
            {
                int curK = kWh - kWhLevels[i];

                if (curK <= 0)
                {
                    totalMoney += kWh * moneyLevels[i];
                    return totalMoney;
                }

                kWh -= kWhLevels[i];
                totalMoney += kWhLevels[i] * moneyLevels[i];
            }

            return totalMoney;
        }
    }
}
