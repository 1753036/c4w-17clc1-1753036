using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    class DisplayHelper
    {
        private ImageList imageList = new ImageList();
        private FileManager fileMan;
        private ComboBox driveOptions;
        private Label driveInfo;
        private TextBox addrBar;
        private ListView filesView;
        private ContextMenuStrip menu;

        public DisplayHelper(FileManager fm, ComboBox cb, Label lb, TextBox tb, ListView lv, ContextMenuStrip m)
        {
            fileMan = fm;
            driveOptions = cb;
            driveInfo = lb;
            addrBar = tb;
            filesView = lv;
            menu = m;

            imageList.ColorDepth = ColorDepth.Depth32Bit;

            filesView.SmallImageList = imageList;
            filesView.LargeImageList = imageList;
            filesView.FullRowSelect = true;
            filesView.LabelEdit = true;

            AddDriveOptions();
            AddFilesViewColumns();
        }

        void AddFilesViewColumns()
        {
            filesView.Columns.Add("Name", 200);
            filesView.Columns.Add("Ext", 50);
            filesView.Columns.Add("Size(KB)", 60);
            filesView.Columns.Add("Date", 100);
            filesView.Columns.Add("Attr", 500);
        }

        void AddDriveOptions()
        {
            foreach (var d in fileMan.Drives)
            {
                driveOptions.Items.Add(d.Name);
            }
        }

        ListViewItem AddFilesViewItem(string name, string ext, string size, string date, string attr, int imageIndex = 0)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(ext);
            item.SubItems.Add(size);
            item.SubItems.Add(date);
            item.SubItems.Add(attr);
            item.ImageIndex = imageIndex;
            filesView.Items.Add(item);
            return item;
        }

        ListViewItem AddFilesViewItem(DirectoryInfo dir)
        {
            return AddFilesViewItem(
                dir.Name, 
                "<DIR>", 
                "0", 
                dir.LastAccessTime.ToShortDateString(), 
                dir.Attributes.ToString()
            );
        }

        ListViewItem AddFilesViewItem(FileInfo file)
        {
            var item = AddFilesViewItem(
                file.Name,
                file.Extension.ToString(),
                (file.Length / 1024).ToString(),
                file.LastAccessTime.ToShortDateString(),
                file.Attributes.ToString(),
                GetIconIndex(file)
            );
            item.Tag = file;
            return item;
        }

        void ClearImageList()
        {
            imageList.Images.Clear();
            imageList.Images.Add(Icon.ExtractAssociatedIcon("folder.ico"));
        }

        int GetIconIndex(FileInfo file)
        {
            imageList.Images.Add(Icon.ExtractAssociatedIcon(file.FullName));
            return imageList.Images.Count - 1;
        }

        public void UpdateAddrBar()
        {
            addrBar.Text = fileMan.CurrentDir.FullName;
        }

        public void UpdateDriveInfo()
        {
            var drive = fileMan.CurrentDrive;
            var total = drive.TotalSize / 1024 / 1024 / 1024;
            var free = drive.AvailableFreeSpace / 1024 / 1024 / 1024;

            driveInfo.Text = free.ToString() + " GB/ " + total.ToString() + " GB";

            UpdateAddrBar();
            UpdateFilesView();
        }

        public void UpdateFilesView()
        {
            DirectoryInfo[] dirs = fileMan.GetDirectories();
            FileInfo[] files = fileMan.GetFiles();
            ClearImageList();
            filesView.Items.Clear();
            filesView.Refresh();

            if (fileMan.CurrentDir.Parent != null)
            {
                AddFilesViewItem( "..", "", "", "", "");
            }

            foreach (var subdir in dirs)
            {
                AddFilesViewItem(subdir);
            }

            foreach (var file in files)
            {
                AddFilesViewItem(file);
            }
        }

        public void Refresh()
        {
            UpdateDriveInfo();
        }

        public void ShowMenu(Point point)
        {
            var indices = filesView.SelectedIndices;

            if (indices.Count == 0)
            {
                for (int i = 0; i < menu.Items.Count; ++i)
                {
                    menu.Items[i].Enabled = false;
                }

                menu.Items[5].Enabled = true;
            }
            else
            {
                for (int i = 0; i < menu.Items.Count; ++i)
                {
                    menu.Items[i].Enabled = true;
                }
            }
            menu.Show(point);
        }
    }
}
