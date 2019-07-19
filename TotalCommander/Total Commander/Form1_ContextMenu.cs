using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    public partial class Form1
    {
        private List<string> cutClipboard= new List<string>();
        private List<string> copyClipboard = new List<string>();

        private void ClearClipboard()
        {
            cutClipboard.Clear();
            copyClipboard.Clear();
        }

        private void DisableMenuItems()
        {
            foreach (ToolStripMenuItem item in contextMenu.Items)
            {
                item.Enabled = false;
            }
        }

        private void EnableMenuItems()
        {
            foreach (ToolStripMenuItem item in contextMenu.Items)
            {
                item.Enabled = true;
            }
        }

        private void contextMenu_Opened(object sender, EventArgs e)
        {
            EnableMenuItems();
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;

            if (currentListView.SelectedItems.Count == 0)
            {
                DisableMenuItems();
                contextMenu.Items[4].Enabled = true;
                contextMenu.Items[5].Enabled = true;
            }
            else if (currentListView.SelectedItems.Count == 1)
            {
                string path = Path.Combine(currentFileMan.CurrentDir.FullName, currentListView.SelectedItems[0].Text);
                if (File.Exists(path))
                {
                    EnableMenuItems();
                }
            }
        }

        private void renameContextMenu_Click(object sender, EventArgs e)
        {
            currentListView.SelectedItems[0].BeginEdit();
        }

        private void newFolderContextMenu_Click(object sender, EventArgs e)
        {
            string name = currentFileMan.NewFolder();
            RefreshAll();

            foreach (ListViewItem item in currentListView.Items)
            {
                if (item.Text == name)
                {
                    item.Selected = true;
                    item.BeginEdit();
                }
            }
        }

        private void deleteContextMenu_Click(object sender, EventArgs e)
        {
            bool show = true;
            foreach (ListViewItem item in currentListView.SelectedItems)
            {
                currentFileMan.Delete(item.Text, show);
                show = false;
            }
            RefreshAll();
        }

        private void moveContextMenu_Click(object sender, EventArgs e)
        {
            ClearClipboard();
            string parent = currentFileMan.CurrentDir.FullName;
            cutClipboard.Add(parent);
            foreach (ListViewItem item in currentListView.SelectedItems)
            {
                cutClipboard.Add(item.Text);
            }
        }

        private void copyContextMenu_Click(object sender, EventArgs e)
        {
            ClearClipboard();
            string parent = currentFileMan.CurrentDir.FullName;
            copyClipboard.Add(parent);
            foreach (ListViewItem item in currentListView.SelectedItems)
            {
                copyClipboard.Add(item.Text);
            }
        }

        private void pasteContextMenu_Click(object sender, EventArgs e)
        {
            if (cutClipboard.Count >= 1)
            {
                string srcDir = cutClipboard[0];
                string destDir = currentFileMan.CurrentDir.FullName;
                List<string> items = new List<string>();

                foreach (var item in cutClipboard)
                {
                    if (item != srcDir)
                    {
                        items.Add(item);
                    }
                }

                currentFileMan.MoveListFiles(srcDir, destDir, items);
            }
            else if (copyClipboard.Count >= 1)
            {
                string srcDir = copyClipboard[0];
                string destDir = currentFileMan.CurrentDir.FullName;
                List<string> items = new List<string>();

                foreach (var item in copyClipboard)
                {
                    if (item != srcDir)
                    {
                        items.Add(item);
                    }
                }

                currentFileMan.CopyListFiles(srcDir, destDir, items);
            }

            ClearClipboard();
            RefreshAll();
        }

        private void viewContextMenu_Click(object sender, EventArgs e)
        {
            if (currentListView.SelectedItems.Count == 0)
            {
                return;
            }

            string name = currentListView.SelectedItems[0].Text;
            string text = currentFileMan.ReadWholeFile(name);
            string path = Path.Combine(currentFileMan.CurrentDir.FullName, name);
            Form2 f2 = new Form2(path);
            f2.Text = path;
            f2.SetText(text);
            f2.ShowDialog();
        }

        private void editContextMenu_Click(object sender, EventArgs e)
        {
            if (currentListView.SelectedItems.Count == 0)
            {
                return;
            }
            string path = Path.Combine(currentFileMan.CurrentDir.FullName, currentListView.SelectedItems[0].Text);
            currentFileMan.EditFile(path);
        }
    }
}

