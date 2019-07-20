using System;
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
        private bool replaceAll = false;
        private bool skipAll = false;
        public string DefaultEdit = "notepad.exe";

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

        public bool IsHidden()
        {
            return showHidden;
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
                Process.Start(@path);
                return;
            }

            MessageBox.Show("File not found");
        }

        public void EditFile(string path)
        {
            if (Directory.Exists(path))
            {
                return;
            }
            //path = path.Replace(" ", "\\ ");
            Console.WriteLine(path);
            //Process.Start(@"subl.exe", path);
            Process.Start(@DefaultEdit, path);
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

        public string ReadWholeFile(string filename)
        {
            string path = Path.Combine(CurrentDir.FullName, filename);

            if (Directory.Exists(path))
            {
                return "";
            }

            byte[] bytes = File.ReadAllBytes(path);

            for (int i = 0; i < bytes.Length; ++i)
            {
                if (bytes[i] == 0)
                {
                    bytes[i] = 40;
                }
            }

            return Encoding.UTF8.GetString(bytes);
        }

        public void Delete(string item, bool showDialog = true)
        {
            // @FIXME: delete recursive
            if (showDialog)
            { 
                Dialog2Item frm = new Dialog2Item("Do you want to delete " + item + "?", "Delete", "Cancle");
                frm.ShowDialog();
                if (frm.DialogResult != DialogResult.OK)
                {
                    return;
                }
            }

            string path = Path.Combine(CurrentDir.FullName, item);            
            if (File.Exists(path))
            {
                File.Delete(path);
                return;
            }

            Directory.Delete(path, true);
        }

        public string NewFolder()
        {
            string name = "New Folder";
            string path = Path.Combine(CurrentDir.FullName, name);

            for (int i = 1; Directory.Exists(path); ++i)
            {
                name = "New Folder (" + i.ToString() + ")";
                path = Path.Combine(CurrentDir.FullName, name);
            }
            
            Directory.CreateDirectory(path);
            return name;
        }

        public bool Rename(string name, string newname)
        {
            var parent = CurrentDir.FullName;
            var src = Path.Combine(parent, name);
            var dest = Path.Combine(parent, newname);
            return Move(src, dest);
        }

        public bool Copy(string src, string dest, bool deleted = false)
        {
            Console.WriteLine($"Deleted {deleted}");
            bool copied = true;
            DialogResult result = DialogResult.Abort;
            if (src == dest)
            {
                return false;
            }

            if (!replaceAll && (File.Exists(dest) || Directory.Exists(dest)))
            {
                Dialog dialog = new Dialog("File or Directory conflict: " + src + " & " + dest);
                dialog.ShowDialog();
                result = dialog.DialogResult;
            }

            if (Directory.Exists(src) && Directory.Exists(dest) == false)
            {
                Console.WriteLine("Make Folder " + dest);
                Directory.CreateDirectory(dest);
            }

            switch (result)
            {
                case DialogResult.OK:
                    replaceAll = true;
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.Ignore:
                    Console.WriteLine("Skip " + src + " - " + dest);
                    return false;
                case DialogResult.Cancel:
                    skipAll = true;
                    break;
            }

            if (File.Exists(src))
            {
                Console.WriteLine($"Copy File FROM {src} TO {dest}");
                File.Copy(src, dest, true);
                if (deleted)
                {
                    Console.WriteLine("Delete " + src);
                    File.Delete(src);
                }
                return true;
            }

            Console.WriteLine($"Copy Folder FROM {src} TO {dest}");
            string[] filepaths = Directory.GetDirectories(src);
            foreach (string path in filepaths)
            {
                if (skipAll == false)
                {
                    string filename = Path.GetFileName(path);
                    copied = copied & Copy(Path.Combine(src, filename), Path.Combine(dest, filename), deleted);
                }
            }

            filepaths = Directory.GetFiles(src);
            foreach (string path in filepaths)
            {
                if (skipAll == false)
                {
                    string filename = Path.GetFileName(path);
                    copied = copied & Copy(Path.Combine(src, filename), Path.Combine(dest, filename), deleted);
                }
            }

            try
            {
                Console.WriteLine("Try Delete Folder " + src);
                Directory.Delete(src);
            }
            catch
            {
                
            }

            return copied;
        }

        public void CopyListFiles(string srcDir, string destDir, List<string> list)
        {
            replaceAll = false;
            skipAll = false;

            foreach (var item in list)
            {
                if (skipAll)
                {
                    break;
                }

                string src = Path.Combine(srcDir, item);
                string dest = Path.Combine(destDir, item);
                Copy(src, dest);
            }
        }

        public bool Move(string src, string dest)
        {
            return Copy(src, dest, true) & skipAll == false;
        }

        public void MoveListFiles(string srcDir, string destDir, List<string> list)
        {
            replaceAll = false;
            skipAll = false;

            foreach (var item in list)
            {
                if (skipAll)
                {
                    break;
                }

                string src = Path.Combine(srcDir, item);
                string dest = Path.Combine(destDir, item);
                Move(src, dest);
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
