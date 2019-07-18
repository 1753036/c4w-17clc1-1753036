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
    public partial class Form2 : Form
    {
        public Form2(string label, bool view = true)
        {
            InitializeComponent();
            textBox1.Text = label;

            richTextBoxView.ReadOnly = view;
        }

        public void SetText(string text)
        {
            richTextBoxView.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
