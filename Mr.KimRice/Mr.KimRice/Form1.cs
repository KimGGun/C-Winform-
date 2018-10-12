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
        Form2 form2;
        public int table_count;
        public String table_info;
        public String[] order_now;
        

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 _form)
        {
            InitializeComponent();
            form2 = _form;
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
            Table_Set();
            cur_time.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분");
            if(form2 != null)
            {
                table_count = form2.t_id;
                table_info = "[" + form2.t_id.ToString("G") + "]" + "\n";

                if(form2.table_info != null)
                {
                    for (int i = 0; i < form2.table_info.Length; i++)
                    {
                        order_now[i] = form2.table_info[i];
                        table_info = "1 \n";
                    }
                }
                table_list1.Controls[table_count].Text = table_info;
            }
            
             
        }

        private void Button_Click(object sender, EventArgs e) 
        {
            Button table_count = sender as Button;
            int new_t_id = Int32.Parse(table_count.Text);
            Form2 newForm2 = new Form2(this);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
