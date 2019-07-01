using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    class DisplayHelper
    {
        private static ImageList imageList = new ImageList();
        private FileManager fileMan;
        private ComboBox driveOptions;
        private Label driveInfo;
        private TextBox addrBar;
        private ListView filesView;

        public DisplayHelper(FileManager fm, ComboBox cb, Label lb, TextBox tb, ListView lv)
        {
            fileMan = fm;
            driveOptions = cb;
            driveInfo = lb;
            addrBar = tb;
            filesView = lv;

            imageList.Images.Add(Icon.ExtractAssociatedIcon("folder.ico"));
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
            filesView.Columns.Add("Size(MB)", 100);
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

        void AddFilesViewItem(string name, string ext, string size, string date, string attr, int imageIndex = 0)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(ext);
            item.SubItems.Add(size);
            item.SubItems.Add(date);
            item.SubItems.Add(attr);
            item.ImageIndex = imageIndex;
            filesView.Items.Add(item);
        }

        void AddFilesViewItem(DirectoryInfo dir)
        {
            AddFilesViewItem(
                dir.Name, 
                "", 
                "", 
                dir.LastAccessTime.ToShortDateString(), 
                dir.Attributes.ToString()
            );
        }

        void AddFilesViewItem(FileInfo file)
        {
            AddFilesViewItem(
                file.Name,
                file.Extension.ToString(),
                (file.Length / 1024 / 1024).ToString(),
                file.LastAccessTime.ToShortDateString(),
                file.Attributes.ToString(),
                GetIconIndex(file)
            );
        }

        int GetIconIndex(FileInfo file)
        {
            string key = file.Extension;

            if (!imageList.Images.Keys.Contains(key)) 
            {
                imageList.Images.Add(key, Icon.ExtractAssociatedIcon(file.FullName));
            }

            return imageList.Images.IndexOfKey(key);
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
    }
}
