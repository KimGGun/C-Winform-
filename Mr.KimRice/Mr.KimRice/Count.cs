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
    public partial class Count : Form
    {
        public static int table_id;
        public static String info;
        public static int price;
        public static Order OrderForm;

        public Count()
        {
            InitializeComponent();
        }

        public Count(Order _form)
        {
            InitializeComponent();
            OrderForm = _form;
        }

        private void Count_Load(object sender, EventArgs e)
        {
            SetText();
        }

        private void SetText()
        {
            int t_id = OrderForm.t_id;
            int price = OrderForm.order_price;
            String count_info = "";

            for(int i = 0; i < OrderForm.order_list.Items.Count; i++)
            {
                count_info += OrderForm.order_list.Items[i].Text+ " X " ;
                count_info += OrderForm.order_list.Items[i].SubItems[0].Text + "\n";
            }
            
            table_id_label.Text = t_id.ToString("G");
            count_price.Text = price.ToString("G");
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
