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
            Console.Write("Nhap vao n: ");
            string strLine = Console.ReadLine();
            int n = 0;
            int[] arr;
            int from = 0;
            int to = 0;

            if (int.TryParse(strLine, out n) == false)
            {
                n = 0;
            }

            CorrectDauVao(ref n);
            PhatSinhSo(out arr, n);
            InManHinh(arr, 0, n - 1);

            TimChuoiConTangDaiNhat(arr, n, ref from, ref to);
            Console.WriteLine();
            Console.WriteLine("Day con dai nhat {0}-{1}", from, to);
            InManHinh(arr, from, to);
        }

        static void CorrectDauVao(ref int n)
        {
            if (n > 100)
            {
                n = 100;
            }

            if (n < 0)
            {
                n = 0;
            }
        }

        static void PhatSinhSo(out int[] arr, int n)
        {
            Random rand = new Random();
            arr = new int[n];

            for (int i = 0; i < n; ++i)
            {
                arr[i] = rand.Next(1000);
            }
        }

        static void InManHinh(int[] arr, int from, int to)
        {
            Console.WriteLine();

            for (int i = from; i <= to; ++i)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }

        static void TimChuoiConTangDaiNhat(int[] arr, int n, ref int maxFrom, ref int maxTo)
        {
            int from = 0;
            int to = 0;
            int count = 1;
            int maxCount = 1;

            for (int i = 1; i <= n; ++i)
            {
                

                if (i < n && arr[i] >= arr[i - 1])
                {
                    ++count;
                    to = i;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxFrom = from;
                        maxTo = to;
                    }

                    //Console.WriteLine("From {0} To {1}, Count {2}", from, to, count);

                    from = i;
                    to = i;
                    count = 1;
                }
            }
        }
    }
}
