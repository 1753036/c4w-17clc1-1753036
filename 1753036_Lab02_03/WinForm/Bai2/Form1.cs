using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnTaoForm_Click(object sender, EventArgs e)
        {
            int rows = 0;
            int cols = 0;

            if (!int.TryParse(tbDong.Text, out rows))
            {
                rows = 0;
            }

            if (!int.TryParse(tbCot.Text, out cols))
            {
                cols = 0;
            }
            Form2 frm = new Form2(rows, cols);
            frm.Show();
        }
    }
}
