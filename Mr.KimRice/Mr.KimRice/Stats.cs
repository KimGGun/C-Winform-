﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.KimRice
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main newForm1 = new Main();
            this.Hide();
            newForm1.Show();
        }
    }
}
