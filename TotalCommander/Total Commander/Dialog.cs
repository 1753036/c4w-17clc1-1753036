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
    public partial class Dialog : Form
    {
        public Dialog(string msg)
        {
            InitializeComponent();
            textBox1.Text = msg;
        }
    }
}
