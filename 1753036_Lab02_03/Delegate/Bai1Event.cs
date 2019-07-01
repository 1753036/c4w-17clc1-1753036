using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class KhachHang
    {
        public delegate void HangMucHandler();

        public event HangMucHandler DatMucBinhDan;
        public event HangMucHandler DatMucTrungCap;
        public event HangMucHandler DatMucCaoCap;

        static long mucTrungCap = 10000000;
        static long mucCaoCap = 10000000;
        long _taiKhoan = 0;

        public long TaiKHoan
        {
            get { return _taiKhoan; }
            set
            {
                _taiKhoan = value;

                if (_taiKhoan < mucTrungCap)
                {
                    if (DatMucBinhDan != null)
                    {
                        DatMucBinhDan();
                    }
                }
                else if (_taiKhoan < mucCaoCap)
                {
                    if (DatMucTrungCap != null)
                    {
                        DatMucTrungCap();
                    }
                }
                else if (DatMucCaoCap != null)
                {
                    DatMucCaoCap();
                }
            }
        }

        public void ThemThuNhap(long soTien)
        {
            TaiKHoan += soTien;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Random rd = new Random();
            KhachHang kh = new KhachHang();

            kh.DatMucBinhDan += new KhachHang.HangMucHandler(TTBinhDan);
            kh.DatMucTrungCap += TTTrungCap;
            kh.DatMucCaoCap += TTCaoCap;

            char c = 'a';

            while (c != 'q')
            {
                Console.Write("Nhan a de them thu nhap");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    kh.ThemThuNhap(rd.Next(1000000, 9000000));
                }

                Console.WriteLine();
                Console.Write("Tiep tuc?");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        static void TTBinhDan()
        {
            Console.WriteLine();
            Console.WriteLine("Tiep thi hang binh dan");
        }

        static void TTTrungCap()
        {
            Console.WriteLine();
            Console.WriteLine("Tiep thi hang trung cap");
        }

        static void TTCaoCap()
        {
            Console.WriteLine();
            Console.WriteLine("Tiep thi cao cap");
        }
    }
}
