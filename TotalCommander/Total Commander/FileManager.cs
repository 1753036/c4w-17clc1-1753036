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

            //var files = Directory.GetFiles(path);
            //foreach (var f in files)
            //{
            //    File.Delete(f);
            //}

            //var folders = Directory.GetDirectories(path);
            //foreach (var f in folders)
            //{
            //    Delete(f);
            //}

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

        public bool Copy(string src, string dest, bool showMergeDialog = true)
        {
            if (src == dest)
            {
                return false;
            }

            if (File.Exists(src))
            {
                bool overwrite = false;
                if (File.Exists(dest))
                {
                    Dialog frm = new Dialog("Copy from " + src + " To " + dest);
                    frm.ShowDialog();
                    overwrite = frm.DialogResult == DialogResult.Yes || frm.DialogResult == DialogResult.OK;
                    if (frm.DialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                    else if (frm.DialogResult == DialogResult.Ignore)
                    {
                        return false;
                    }
                }

                File.Copy(src, dest, overwrite);
                return true;
            }

            if (Directory.Exists(dest) == false)
            {
                Directory.CreateDirectory(dest);
            }
            else
            {
                if (showMergeDialog == true)
                {
                    var frm = new Dialog2Item("Do you want to merge folder from" + src + " To " + dest + "?", "Merge", "Cancle");
                    frm.ShowDialog();
                    if (frm.DialogResult != DialogResult.OK)
                    {
                        return false;
                    }
                    else if (frm.DialogResult == DialogResult.OK)
                    {
                        showMergeDialog = false;
                    }
                }
            }

            var files = Directory.GetFiles(src);
            bool overwriteall = false;
            foreach (var f in files)
            {
                bool overwrite = overwriteall;
                string name = Path.GetFileName(f);
                string destPath = Path.Combine(dest, name);
                if (File.Exists(destPath))
                {
                    if (overwriteall == false)
                    {
                        Dialog frm = new Dialog("Copy from " + src + " To " + dest);
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.Cancel)
                        {
                            break;
                        }
                        else if (frm.DialogResult == DialogResult.Ignore)
                        {
                            continue;
                        }
                        else if (frm.DialogResult == DialogResult.Yes)
                        {
                            overwrite = true;
                        }
                        else if (frm.DialogResult == DialogResult.OK)
                        {
                            overwriteall = true;
                            overwrite = true;
                        }
                    }
                }

                File.Copy(f, destPath, overwrite);
            }

            var folders = Directory.GetDirectories(src);
            foreach (var f in folders)
            {
                string name = Path.GetFileName(f);
                //MessageBox.Show(Path.Combine(dest, name));
                Copy(f, Path.Combine(dest, name), showMergeDialog);
            }

            return true;
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
                try
                {
                    File.Move(src, dest);
                }
                catch
                {
                    MessageBox.Show("Permission denied!");
                }
                return true;
            }

            return false;
        }

        public bool Move(string src, string dest)
        {
            if (src == dest)
            {
                return false;
            }

            if (Copy(src, dest))
            {
                Delete(src, false);
            }
            return true;
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
