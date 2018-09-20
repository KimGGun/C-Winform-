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
            for(int i = 0; i  < 10; i++)
            {
                Button newbtn = new Button();
                newbtn.Text = i.ToString("G") ;
                newbtn.Width = 180;
                newbtn.Height = 180;
                newbtn.Click += Button_Click;

                table_list1.Controls.Add(newbtn);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e) 
        {
            Button table_count = sender as Button;
            int new_t_id = Int32.Parse(table_count.Text);
            Form2 newForm2 = new Form2();
            newForm2.t_id = new_t_id;
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
