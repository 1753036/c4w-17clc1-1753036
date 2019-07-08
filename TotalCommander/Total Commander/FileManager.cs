﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void Delete(string item)
        {
            // @FIXME: delete recursive
            string path = Path.Combine(CurrentDir.FullName, item);
            if (File.Exists(path))
            {
                File.Delete(path);
                return;
            }

            var files = Directory.GetFiles(path);
            foreach (var f in files)
            {
                File.Delete(f);
            }

            var folders = Directory.GetDirectories(path);
            foreach (var f in folders)
            {
                Delete(f);
            }

            Directory.Delete(path);
        }

        public void NewFolder()
        {
            string path = Path.Combine(CurrentDir.FullName,"New Folder");

            for (int i = 1; Directory.Exists(path); ++i)
            {
                path = Path.Combine(CurrentDir.FullName, "New Folder (" + i.ToString() +")");
            }

            //MessageBox.Show(path);
            Directory.CreateDirectory(path);
        }

        public bool Rename(string name, string newname)
        {
            var parent = CurrentDir.FullName;
            var src = Path.Combine(parent, name);
            var dest = Path.Combine(parent, newname);
            return Move(src, dest);
        }

        public void Copy(string src, string dest)
        {
            if (File.Exists(src))
            {
                File.Copy(src, dest);
                return;
            }

            if (Directory.Exists(dest) == false)
            {
                Directory.CreateDirectory(dest);
            }

            var files = Directory.GetFiles(src);
            foreach (var f in files)
            {
                string name = Path.GetFileName(f);
                File.Copy(f, Path.Combine(dest, name));
            }

            var folders = Directory.GetDirectories(src);
            foreach (var f in folders)
            {
                string name = Path.GetFileName(f);
                //MessageBox.Show(Path.Combine(dest, name));
                Copy(f, Path.Combine(dest, name));
            }
        }
        public bool MoveTheSameDrive(string src, string dest)
        {
            if (Directory.Exists(src) && !Directory.Exists(dest))
            {
                Directory.Move(src, dest);
                return true;
            }

            if (File.Exists(src) && !File.Exists(dest))
            {
                File.Move(src, dest);
                return true;
            }

            return false;
        }

        public bool Move(string src, string dest)
        {
            //MessageBox.Show("KHong the move accross volume!!!");
            var folders = GetDirectories();

            if (Path.GetPathRoot(src) == Path.GetPathRoot(dest))
            {
                return MoveTheSameDrive(src, dest);
            }
            else
            {
                Copy(src, dest);
                Delete(src);
                return true;
            }

            return false;
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
