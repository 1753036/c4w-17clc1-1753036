using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Commander
{
    public partial class Form1
    {

        private void leftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftFileMan.OpenDrive(leftComboBox.SelectedIndex);
            leftHelper.UpdateDriveInfo();
        }

        private void rightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightFileMan.OpenDrive(rightComboBox.SelectedIndex);
            rightHelper.UpdateDriveInfo();
        }
    }
}
