
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsForms_Table
{
    public class Form2 : Form
    {
        FlowLayoutPanel mFlowLayout;
        int mRows, mCols;
        Button[,] mButtons;

        public Form2(int rows, int cols)
        {
            mRows = rows;
            mCols = cols;
            mFlowLayout = new FlowLayoutPanel();
            mFlowLayout.Size = new System.Drawing.Size(cols * 36 + 20, rows * 36 + 20);
            mFlowLayout.Location = new System.Drawing.Point(10, 10);
            AddButtons();

            this.Controls.Add(mFlowLayout);
            this.ClientSize = mFlowLayout.Size;
        }

        private void ButtonClick(Object sender, EventArgs e)
        {
            int num = int.Parse((sender as Button).Text);
            int row = num / mRows;
            int col = num % mCols;
            MessageBox.Show(row.ToString() + ", " + col.ToString());
        }

        private void AddButtons()
        {
            mButtons = new Button[mRows, mCols];

            for (int i = 0; i < mRows; ++i)
            {
                for (int j = 0; j < mCols; ++j)
                {
                    mButtons[i, j] = new Button();
                    mButtons[i, j].Text = (i * mRows + j).ToString();
                    mButtons[i, j].Size = new System.Drawing.Size(30, 30);
                    mButtons[i, j].Click += new EventHandler(ButtonClick);
                    mFlowLayout.Controls.Add(mButtons[i, j]);
                }
            }
        }
    }
}
