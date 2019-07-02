using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Commander
{
    public partial class Form1 : Form
    {

        private DisplayHelper leftHelper;
        private DisplayHelper rightHelper;
        private FileManager leftFileMan;
        private FileManager rightFileMan;
        private string beforeLabelEditString;
        private string afterLabelEditString;
        private bool leftFocused;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(1200, 600);

            leftFileMan = new FileManager();
            leftFileMan.ShowHidden(true);
            rightFileMan = new FileManager();
            rightFileMan.ShowHidden(false);

            leftHelper = new DisplayHelper(
                leftFileMan,
                cb_left_drives,
                lb_left_info,
                tb_left_addressbar,
                lv_left_view,
                mainMenu);

            rightHelper = new DisplayHelper(
                rightFileMan,
                cb_right_drives,
                lb_right_info,
                tb_right_addressbar,
                lv_right_view,
                mainMenu);

            cb_right_drives.SelectedIndex = 0;
            cb_left_drives.SelectedIndex = 0;
        }
        
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

        private void tb_right_addressbar_Click(object sender, MouseEventArgs e)
        {
            tb_right_addressbar.ReadOnly = false;
        }

        private void tb_left_addressbar_Click(object sender, MouseEventArgs e)
        {
            tb_left_addressbar.ReadOnly = false;
        }

        private void tb_left_addressbar_Leave(object sender, EventArgs e)
        {
            tb_left_addressbar.ReadOnly = true;
        }

        private void tb_right_addressbar_Leave(object sender, EventArgs e)
        {
            tb_left_addressbar.ReadOnly = true;
        }

        private void lv_left_view_DoubleClick(object sender, EventArgs e)
        {
            var item = lv_left_view.SelectedItems[0];

            leftFileMan.OpenChildFileOrDir(item.Text);
            leftHelper.Refresh();
        }

        private void lv_right_view_DoubleClick(object sender, EventArgs e)
        {
            var item = lv_right_view.SelectedItems[0];

            rightFileMan.OpenChildFileOrDir(item.Text);
            rightHelper.Refresh();
        }

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leftFocused)
            {
                leftFileMan.NewFolder();
                leftHelper.Refresh();
            }
            else
            {
                rightFileMan.NewFolder();
                rightHelper.Refresh();
            }
        }

        private void lv_left_view_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                leftHelper.ShowMenu(MousePosition);
            }
        }

        private void lv_right_view_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightHelper.ShowMenu(MousePosition);
            }
        }

        private void newFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (leftFocused)
            {
                leftFileMan.NewFolder();
                leftHelper.Refresh();
            }
            else
            {
                rightFileMan.NewFolder();
                rightHelper.Refresh();
            }
        }

        private void lv_left_view_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                return;
            }

            afterLabelEditString = e.Label.ToString();

            if (afterLabelEditString.Length == 0)
            {
                return;
            }

            leftFileMan.RenameChild(beforeLabelEditString, afterLabelEditString);
            leftFileMan.OpenDir(tb_left_addressbar.Text);
            leftHelper.Refresh();
        }

        private void lv_left_view_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            beforeLabelEditString = lv_left_view.SelectedItems[0].Text;
        }

        private void lv_right_view_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                return;
            }

            afterLabelEditString = e.Label.ToString();

            if (afterLabelEditString.Length == 0)
            {
                return;
            }

            rightFileMan.RenameChild(beforeLabelEditString, afterLabelEditString);
            rightFileMan.OpenDir(tb_right_addressbar.Text);
            rightHelper.Refresh();
        }

        private void lv_right_view_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            beforeLabelEditString = lv_right_view.SelectedItems[0].Text;
        }

        private void lv_left_view_Click(object sender, EventArgs e)
        {
            leftFocused = true;
        }

        private void lv_right_view_Click(object sender, EventArgs e)
        {
            leftFocused = false;
        }
    }
}
