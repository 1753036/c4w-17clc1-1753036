﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Commander
{
    public partial class Form2 : Form
    {
        public Form2(bool view = true)
        {
            InitializeComponent();
            richTextBoxView.ReadOnly = view;
        }

        public void SetText(string text)
        {
            richTextBoxView.Text = text;
        }
    }
}