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
        private void change_View(View v)
        {
            if (leftFocused)
            {
                lv_left_view.View = v;
            }
            else
            {
                lv_right_view.View = v;
            }
        }

        private void tsb_view_Click(object sender, EventArgs e)
        {
            change_View(View.SmallIcon);
        }

        private void tsb_list_Click(object sender, EventArgs e)
        {
            change_View(View.List);
        }

        private void tsb_detail_Click(object sender, EventArgs e)
        {
            change_View(View.Details);
        }
    }
}
