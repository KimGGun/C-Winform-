using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mr.KimRice
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            progress.BringToFront();
        }

        private void loading(object sender, EventArgs e)
        {
            Thread load = new Thread(step);
            load.Start();
        }

        private void step()
        {
            for(int i = 1; i <= progress.Maximum; i++)
            {
                Thread.Sleep(10);
            }
            Thread.Sleep(3000);
            Form4 form4 = new Form4();
            this.Close();
            form4.Show();
        }

    }
}
