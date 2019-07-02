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
    class FileManager
    {
        public DriveInfo[] Drives = DriveInfo.GetDrives();
        public DirectoryInfo CurrentDir;
        public DriveInfo CurrentDrive;
        private bool showHidden = false;

        public FileManager()
        {
            OpenDrive(0);
        }

        bool IsSystemFile(FileAttributes attributes)
        {
            return (attributes & FileAttributes.System) == FileAttributes.System;
        }

        bool IsHiddenFile(FileAttributes attributes)
        {
            return (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
        }

        public void ShowHidden(bool show)
        {
            showHidden = show;
        }

        public void OpenDrive(int index)
        {
            if (index >= Drives.Length || index < 0)
            {
                return;
            }

            CurrentDrive = Drives[index];
            CurrentDir = CurrentDrive.RootDirectory;
        }

        public void OpenChildFileOrDir(string name)
        {
            DirectoryInfo[] dirs = CurrentDir.GetDirectories();

            if (name == "..")
            {
                OpenParentDir();
                return;
            }

            foreach (var subdir in dirs)
            {
                if (subdir.Name == name)
                {
                    OpenDir(subdir.FullName);
                    return;
                }
            }

            OpenFile(CurrentDir.FullName + '\\' + name);
        }

        public void OpenParentDir()
        {
            if (CurrentDir.Parent != CurrentDrive.RootDirectory)
            {
                CurrentDir = CurrentDir.Parent;
            }
        }

        public void OpenFile(string path)
        {
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                Process.Start(path);
                return;
            }

            MessageBox.Show("File not found");
        }

        public void OpenDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                try
                {
                    dir.GetDirectories();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Permission denied!");
                    return;
                }

                CurrentDir = dir;
                return;
            }

            MessageBox.Show("Directory not found");
        }

        public void NewFolder()
        {
            string path = CurrentDir.FullName;

            if (CurrentDir != CurrentDrive.RootDirectory)
            {
                path = path + '\\';
            }

            MessageBox.Show(path + "New folder");

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }

        public void RenameChild(string name, string newname)
        {
            if (name == newname)
            {
                return;
            }

            var dirs = GetDirectories();
            var files = GetFiles();
            var path = CurrentDir.FullName;

            if (CurrentDir != CurrentDrive.RootDirectory)
            {
                path = path + '\\';
            }
            //MessageBox.Show(name + ' ' + newname);
            foreach (DirectoryInfo dir in dirs)
            {
                if (dir.Name == name)
                {
                    Directory.Move(path + name, path + newname);
                    return;
                }
            }

            foreach (FileInfo fil in files)
            {
                if (fil.Name == name)
                {
                    File.Move(path + name, path + newname);
                    return;
                }
            }
        }

        public DirectoryInfo[] GetDirectories()
        {
            var dirs = CurrentDir.GetDirectories();
            var temp = dirs.ToList();

            foreach (var dir in dirs)
            {
                if (IsSystemFile(dir.Attributes))
                {
                    temp.Remove(dir);
                }
                else if (!showHidden && IsHiddenFile(dir.Attributes))
                {
                    temp.Remove(dir);
                }
            }

            return temp.ToArray();
        }

        public FileInfo[] GetFiles()
        {
            var dirs = CurrentDir.GetFiles();
            var temp = dirs.ToList();

            foreach (var dir in dirs)
            {
                if (IsSystemFile(dir.Attributes))
                {
                    temp.Remove(dir);
                }
                else if (!showHidden && IsHiddenFile(dir.Attributes))
                {
                    temp.Remove(dir);
                }
            }

            return temp.ToArray();
        }
    }
}
