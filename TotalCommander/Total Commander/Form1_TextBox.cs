using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    public partial class Form1
    {
        private void tb_left_addressbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                leftFileMan.OpenDir(tb_left_addressbar.Text);
                leftHelper.Refresh();
            }
        }

        private void tb_right_addressbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rightFileMan.OpenDir(tb_right_addressbar.Text);
                rightHelper.Refresh();
            }
        }

        private void tb_addressbar_Click(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = false;
        }

        private void tb_addressbar_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = true;
        }
    }
}
