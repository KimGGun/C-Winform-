using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Table_Set();
        }

        private void Table_Set()
        {
            for(int i = 0; i  < 5; i++)
            {
                Button newbtn = new Button();
                newbtn.Text = "[" + i + "]";
                newbtn.Width = 200;
                newbtn.Height = 200;
                newbtn.Click += Button_Click;

                table_list1.Controls.Add(newbtn);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e) 
        {
            Form2 newForm2 = new Form2();
            this.Hide();
            newForm2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.Show();
        }
    }
}
