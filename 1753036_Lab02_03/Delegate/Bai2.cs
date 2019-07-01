using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_DeleteTuCho
{
    class KeyEvent
    {
        public delegate void PressKeyHandler(char key);

        public event PressKeyHandler OnKeyPress;

        public void PollEvent()
        {
            while (true)
            {
                char c = Console.ReadKey().KeyChar;

                if (OnKeyPress != null)
                {
                    OnKeyPress(c);
                }
            }
        }
    }

    class Program
    {
        static public void Main()
        {
            KeyEvent keyEvent = new KeyEvent();
            keyEvent.OnKeyPress += test;
            keyEvent.OnKeyPress += test2;
            keyEvent.PollEvent();
        }

        static public void test(char c)
        {
            Console.WriteLine(" Test Key: {0}", c);
        }
        
        static public void test2(char c)
        {
            Console.WriteLine("  Test 2 Key: {0}", c);
        }
    }
}
