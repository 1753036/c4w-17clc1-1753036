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

        private void cutContextMenu_Click(object sender, EventArgs e)
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
            string srcDir = cutClipboard[0];
            string destDir = currentFileMan.CurrentDir.FullName;

            foreach (var item in cutClipboard)
            {
                if (item != srcDir)
                {
                    string src = Path.Combine(srcDir, item);
                    string dest = Path.Combine(destDir, item);
                    MessageBox.Show(src + " Move to " + dest);
                    //currentFileMan.Move(src, dest);
                }
            }

            srcDir = copyClipboard[0];

            foreach (var item in copyClipboard)
            {
                if (item != srcDir)
                {
                    string src = Path.Combine(srcDir, item);
                    string dest = Path.Combine(destDir, item);
                    MessageBox.Show(src + " Copy to " + dest);
                }
            }

            ClearClipboard();
            RefreshAll();
        }


    }
}
