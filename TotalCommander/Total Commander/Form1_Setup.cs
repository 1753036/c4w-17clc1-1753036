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
                leftComboBox,
                leftLabelInfo,
                leftAddressBar,
                lv_left_view,
                contextMenu);

            rightHelper = new DisplayHelper(
                rightFileMan,
                rightComboBox,
                rightLabelInfo,
                rightAddressBar,
                lv_right_view,
                contextMenu);

            currentFileMan = leftFileMan;
            currentHelper = leftHelper;

            rightComboBox.SelectedIndex = 0;
            leftComboBox.SelectedIndex = 0;
        }
    }
}
