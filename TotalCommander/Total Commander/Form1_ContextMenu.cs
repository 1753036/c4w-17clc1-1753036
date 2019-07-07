using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Commander
{
    public partial class Form1
    {
        private void renameContextMenu_Click(object sender, EventArgs e)
        {
            currentFileMan.Rename(currentListView.SelectedIndices[0], "test1", "test2");
        }

        private void newFolderContextMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void cutContextMenu_Click(object sender, EventArgs e)
        {
            var indices = currentListView.SelectedIndices;
            var items = currentListView.SelectedItems;
            var srcPath = currentFileMan.CurrentDir.FullName;
            var destPath = leftFileMan.CurrentDir.FullName;

            foreach (int index in indices)
            {
                if (leftFocused)
                {
                    destPath = rightFileMan.CurrentDir.FullName;
                }
                var src = Path.Combine(srcPath, items[index].Text);
                var dest = Path.Combine(destPath, items[index].Text);
                currentFileMan.Move(index, src, dest);
            }
        }
    }
}
