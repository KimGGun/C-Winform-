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

            progressBar1.Style = ProgressBarStyle.Continuous;
            while(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
               
            }
            
        }

        
    }
}
