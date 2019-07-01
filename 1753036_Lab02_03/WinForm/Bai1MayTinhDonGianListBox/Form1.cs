using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_calculator_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            float so1, so2;
            if (!float.TryParse(tbSoThu1.Text, out so1))
            {
                so1 = 0;
            }

            if (!float.TryParse(tbSoThu2.Text, out so2))
            {
                so2 = 0;
            }

            switch ((sender as Control).Text)
            {
                case "+":
                    lblKetQua.Text = (so1 + so2).ToString();
                    break;
                case "-":
                    lblKetQua.Text = (so1 - so2).ToString();
                    break;
                case "x":
                    lblKetQua.Text = (so1 * so2).ToString();
                    break;
                case "/":
                    if (so2 == 0)
                    {
                        so2 = 1;
                    }
                    lblKetQua.Text = (so1 / so2).ToString();
                    break;
            }
        }
    }
}
