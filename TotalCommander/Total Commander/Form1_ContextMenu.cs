using System;
using System.Collections.Generic;
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

        private void renameContextMenu_Click(object sender, EventArgs e)
        {
            currentListView.SelectedItems[0].BeginEdit();
        }

        private void newFolderContextMenu_Click(object sender, EventArgs e)
        {
            currentFileMan.NewFolder();
            RefreshAll();
        }

        private void deleteContextMenu_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in currentListView.SelectedItems)
            {
                currentFileMan.Delete(item.Text);
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
            // @FIXME
            if (cutClipboard.Count >= 1)
            {
                string srcDir = cutClipboard[0];
                string destDir = currentFileMan.CurrentDir.FullName;

                foreach (var item in cutClipboard)
                {
                    if (item != srcDir)
                    {
                        string src = Path.Combine(srcDir, item);
                        string dest = Path.Combine(destDir, item);
                        //MessageBox.Show(src + " Move to " + dest);
                        currentFileMan.Move(src, dest);
                    }
                }
            }
            else if (copyClipboard.Count >= 1)
            {
                string srcDir = copyClipboard[0];
                string destDir = currentFileMan.CurrentDir.FullName;

                foreach (var item in copyClipboard)
                {
                    if (item != srcDir)
                    {
                        string src = Path.Combine(srcDir, item);
                        string dest = Path.Combine(destDir, item);
                        MessageBox.Show(src + " Copy to " + dest);
                        currentFileMan.Copy(src, dest);
                    }
                }
            }

            ClearClipboard();
            RefreshAll();
        }

        private void viewContextMenu_Click(object sender, EventArgs e)
        {
            string name = currentListView.SelectedItems[0].Text;
            Form2 f2 = new Form2();
            f2.Text = name;
            f2.SetText(currentFileMan.ReadWholeFile(name));
            f2.Show();
        }
    }
}
