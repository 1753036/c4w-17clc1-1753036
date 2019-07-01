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
            string s = "nGuYen vAN a";
            ChuanHoa(ref s);
            Console.WriteLine("{0}", s);
        }

        static void XoaKhoanTrang(ref StringBuilder s)
        {
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != ' ')
                {
                    s.Remove(0, i);
                    break;
                }
            }
        }
        
        static void ChuanHoa(ref string s)
        {
            StringBuilder strBuilder = new StringBuilder(s.ToLower());

            XoaKhoanTrang(ref strBuilder);

            strBuilder[0] = char.ToUpper(strBuilder[0]);

            for (int i = 1; i < strBuilder.Length; ++i)
            {
                if (strBuilder[i] == ' ')
                {
                    strBuilder[i + 1] = char.ToUpper(strBuilder[i + 1]);
                }
            }

            s = strBuilder.ToString();
        }
    }
}
