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
        static void Main()
        {
            int mon;
            int year;

            GetInput(out mon, out year);

            int days = GetDaysInMonth(mon, year);

            if (days == 0)
            {
                Console.WriteLine("Dau vao sai!");
                return;
            }

            Console.WriteLine("So ngay trong thang {0}/{1} la {2} ngay", mon, year, GetDaysInMonth(mon, year));
        }

        static void GetInput(out int mon, out int year)
        {
            Console.Write("Nhap vao thang: ");
            string strMon = Console.ReadLine();

            if (!int.TryParse(strMon, out mon))
            {
                mon = 0;
                Console.WriteLine("Sai format!");
            }

            Console.Write("Nhap vao nam: ");
            string strYear = Console.ReadLine();
            
            if (!int.TryParse(strYear, out year))
            {
                year = 0;
                Console.WriteLine("Sai format!");
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }

            return false;
        }

        static int GetDaysInMonth(int mon, int year)
        {
            if (mon <= 0 || year <= 0 || mon > 12)
            {
                return 0;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int ind = mon - 1;

            if (IsLeapYear(year))
            {
                daysInMonth[ind] = 29;
            }

            return daysInMonth[ind];
        }
    }
}
