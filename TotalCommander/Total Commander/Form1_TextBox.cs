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
        private void AddressBar_Click(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = false;
        }

        private void AddressBar_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = true;
        }

        private void rightAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rightFileMan.OpenDir(rightAddressBar.Text);
                rightHelper.Refresh();
            }
        }

        private void leftAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                leftFileMan.OpenDir(leftAddressBar.Text);
                leftHelper.Refresh();
            }
        }
    }
}
