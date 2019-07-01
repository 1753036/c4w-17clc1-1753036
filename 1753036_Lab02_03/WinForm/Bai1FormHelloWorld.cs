using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab02_Form
{
    public class Form1 : Form
    {
        Label lbl;
        public Form1()
        {
            lbl = new Label();
            lbl.Text = "Hello World!";
            lbl.Font = new Font("tahoma", 20f);
            lbl.AutoSize = true;
            lbl.Left = 50;
            lbl.Top = 100;
            this.Controls.Add(lbl);
        }
    }

    class Program
    {
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
