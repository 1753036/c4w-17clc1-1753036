using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    public partial class Dialog2Item : Form
    {
        public Dialog2Item(string msg, string okButtonText, string cancleButtonText)
        {
            InitializeComponent();
            textBox1.Text = msg;
            button1.Text = okButtonText;
            button2.Text = cancleButtonText;
        }
    }
}
