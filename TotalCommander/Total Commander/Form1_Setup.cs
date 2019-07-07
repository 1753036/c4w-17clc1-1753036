using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Commander
{
    public partial class Form1
    {
        private void SetupComponents()
        {
            leftFileMan = new FileManager();
            leftFileMan.ShowHidden(false);
            rightFileMan = new FileManager();
            rightFileMan.ShowHidden(false);

            leftHelper = new DisplayHelper(
                leftFileMan,
                cb_left_drives,
                lb_left_info,
                tb_left_addressbar,
                lv_left_view,
                contextMenu);

            rightHelper = new DisplayHelper(
                rightFileMan,
                cb_right_drives,
                lb_right_info,
                tb_right_addressbar,
                lv_right_view,
                contextMenu);

            currentFileMan = leftFileMan;
            currentHelper = leftHelper;

            cb_right_drives.SelectedIndex = 0;
            cb_left_drives.SelectedIndex = 0;
        }
    }
}
