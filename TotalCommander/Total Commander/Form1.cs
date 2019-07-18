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
using System.Diagnostics;

namespace Total_Commander
{
    public partial class Form1 : Form
    {

        private DisplayHelper leftHelper;
        private DisplayHelper rightHelper;
        private FileManager leftFileMan;
        private FileManager rightFileMan;
        private FileManager currentFileMan;
        private DisplayHelper currentHelper;
        private ListView currentListView;
        private bool leftFocused;

        public Form1()
        {
            Size = new Size(1200, 600);
            InitializeComponent();
            SetupComponents();
        }

        private void RefreshAll()
        {
            //MessageBox.Show("ASDSAD");
            leftHelper.Refresh();
            rightHelper.Refresh();
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            var item = currentListView.SelectedItems[0];

            currentFileMan.OpenChildFileOrDir(item.Text);
            currentHelper.Refresh();
        }

        private void ListView_AfterEdit(object sender, LabelEditEventArgs e)
        {
            string name = currentListView.SelectedItems[0].Text;
            string newname = name;

            if (e.Label != null)
            {
                newname = e.Label.ToString();
            }

            if (currentFileMan.Rename(name, newname))
            {
                RefreshAll();
            }
        }

        private void leftListView_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Left");
            leftFocused = true;
            currentListView = lv_left_view;
            currentFileMan = leftFileMan;
            currentHelper = leftHelper;
        }

        private void rightListView_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Right");
            leftFocused = false;
            currentListView = lv_right_view;
            currentFileMan = rightFileMan;
            currentHelper = rightHelper;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hiddenFIlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftFileMan.ShowHidden(!leftFileMan.IsHidden());
            leftHelper.Refresh();
            rightFileMan.ShowHidden(!rightFileMan.IsHidden());
            rightHelper.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftFileMan.DefaultEdit = "notepad.exe";
            rightFileMan.DefaultEdit = "notepad.exe";
        }

        private void sublimeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftFileMan.DefaultEdit = "subl.exe";
            rightFileMan.DefaultEdit = "subl.exe";
        }

        private void buttonViewF3_Click(object sender, EventArgs e)
        {
            viewContextMenu_Click(sender, e);
        }

        private void buttonEditF4_Click(object sender, EventArgs e)
        {
            editContextMenu_Click(sender, e);
        }

        private void buttonCopyF5_Click(object sender, EventArgs e)
        {
            FileManager nextFileMan = leftFileMan;
            FileManager oldFileMan = currentFileMan;
            if (currentFileMan == leftFileMan)
            {
                nextFileMan = rightFileMan;
            }
            copyContextMenu_Click(sender, e);
            currentFileMan = nextFileMan;
            pasteContextMenu_Click(sender, e);
            currentFileMan = oldFileMan;
        }

        private void buttonMoveF6_Click(object sender, EventArgs e)
        {
            FileManager nextFileMan = leftFileMan;
            FileManager oldFileMan = currentFileMan;
            if (currentFileMan == leftFileMan)
            {
                nextFileMan = rightFileMan;
            }
            moveContextMenu_Click(sender, e);
            currentFileMan = nextFileMan;
            pasteContextMenu_Click(sender, e);
            currentFileMan = oldFileMan;
        }

        private void buttonNewFolderF7_Click(object sender, EventArgs e)
        {
            newFolderContextMenu_Click(sender, e);
        }

        private void buttonDeleteF8_Click(object sender, EventArgs e)
        {
            deleteContextMenu_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abt = new About();
            abt.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "help.pdf"));
        }

        private void lv_left_view_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    buttonViewF3_Click(sender, null);
                    break;
                case Keys.F4:
                    buttonEditF4_Click(sender, null);
                    break;
                case Keys.F5:
                    buttonCopyF5_Click(sender, null);
                    break;
                case Keys.F6:
                    buttonMoveF6_Click(sender, null);
                    break;
                case Keys.F7:
                    buttonNewFolderF7_Click(sender, null);
                    break;
                case Keys.F8:
                    buttonDeleteF8_Click(sender, null);
                    break;
                default: break;
            }
        }
    }
}
