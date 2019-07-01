using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSinhVien
{
    class SinhVien
    {
        int mMSSV;
        string mHoTen;
        string mQueQuan;

        public int MSSV
        {
            get { return mMSSV; }
            set { mMSSV = value; }
        }

        public string HoTen
        {
            get { return mHoTen; }
            set { mHoTen = value; }
        }

        public string QueQuan
        {
            get { return mQueQuan; }
            set { mQueQuan = value; }
        }

        public override string ToString()
        {
            return string.Format("<{0}>-{1}-[{2}]", mMSSV, mHoTen, mQueQuan);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = rd.Next(5, 10);
            SinhVien[] dsSV = new SinhVien[n];
            for (int i = 0; i < n; ++i)
            {
                dsSV[i] = new SinhVien()
                {
                    MSSV = 1364000 + rd.Next(999),
                    HoTen = string.Format("{0}HT", (char)rd.Next(0x41, 0x5A)),
                    QueQuan = string.Format("{0}QQ", (char)rd.Next(0x61, 0x7A))
                };

                char c = 'a';
                while (c != 'q')
                {
                    Console.Write("Sap xep theo tieu chi (1, 2, 3)");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Array.Sort(dsSV, delegate (SinhVien sv1, SinhVien sv2)
                            {
                                return sv1.MSSV.CompareTo(sv2.MSSV);
                            });
                            break;
                        case '2':
                            Array.Sort(dsSV, delegate (SinhVien sv1, SinhVien sv2)
                            {
                                return sv1.HoTen.CompareTo(sv2.HoTen);
                            });
                            break;
                        case '3':
                            Array.Sort(dsSV, delegate (SinhVien sv1, SinhVien sv2)
                            {
                                return sv1.QueQuan.CompareTo(sv2.QueQuan);
                            });
                            break;
                    }

                    Console.WriteLine();
                    foreach (var sv in dsSV)
                    {
                        Console.WriteLine(sv);
                    }
                    Console.Write("Tiep tuc?");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }
        }
    }
}
