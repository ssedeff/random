﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int elemansayisi=listBox1.Items.Count;
            Random rnd=new Random();
            int secim =rnd.Next(elemansayisi);
            listBox1.SelectedIndex = secim;
        }
    }
}
