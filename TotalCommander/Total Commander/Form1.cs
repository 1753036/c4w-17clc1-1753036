using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Commander
{
    public partial class Form1 : Form
    {

        private DisplayHelper leftHelper;
        private DisplayHelper rightHelper;
        private FileManager leftFileMan;
        private FileManager rightFileMan;
        private FileManager currentFileMan;
        private DisplayHelper currentHelper;
        private ListView currentListView;
        private string beforeLabelEditString;
        private string afterLabelEditString;
        private bool leftFocused;

        public Form1()
        {
            Size = new Size(1200, 600);
            InitializeComponent();
            SetupComponents();
        }

        private void RefreshAll()
        {
            leftHelper.Refresh();
            rightHelper.Refresh();
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            var item = currentListView.SelectedItems[0];

            currentFileMan.OpenChildFileOrDir(item.Text);
            currentHelper.Refresh();
        }

        private void ListView_AfterEdit(object sender, LabelEditEventArgs e)
        {
            string name = currentListView.SelectedItems[0].Text;
            string newname = name;

            if (e.Label != null)
            {
                newname = e.Label.ToString();
            }

            if (currentFileMan.Rename(name, newname))
            {
                RefreshAll();
            }
        }

        private void leftListView_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Left");
            leftFocused = true;
            currentListView = lv_left_view;
            currentFileMan = leftFileMan;
            currentHelper = leftHelper;
        }

        private void rightListView_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Right");
            leftFocused = false;
            currentListView = lv_right_view;
            currentFileMan = rightFileMan;
            currentHelper = rightHelper;
        }
    }
}
