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

    public partial class Loding : Form
    {

        public Loding()
        {
            InitializeComponent();
            

            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 10;

            timer1.Start();

            


            /*progressBar1.Style = ProgressBarStyle.Continuous;
            while(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }

            CheckProg();*/
            
        }

       

        public void timer1_Tick(object semder, EventArgs e)
        {
            if(this.progressBar1.Value >= 100)
            {
                
                this.Dispose();
                
            }
            progressBar1.PerformStep();
        }

        /*private void CheckProg()
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                Form1 newForm = new Form1();
                this.Hide();
                newForm.Show();
            }
        }*/

        
    }
}
