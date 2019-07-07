using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Commander
{
    public partial class Form1
    {
        private void cb_left_drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftFileMan.OpenDrive(cb_left_drives.SelectedIndex);
            leftHelper.UpdateDriveInfo();
        }

        private void cb_right_drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightFileMan.OpenDrive(cb_right_drives.SelectedIndex);
            rightHelper.UpdateDriveInfo();
        }
    }
}
