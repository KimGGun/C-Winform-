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
    public partial class Form2 : Form
    {
        public static int t_id;
        public static int order_price = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            menu 불고기김밥 = new menu("불고기김밥", "kimbab", 2999);
            menu 새싹김밥 = new menu("새싹김밥", "kimbab", 2999);
            menu 야채김밥 = new menu("야채김밥", "kimbab", 1999);
            menu 오징어김밥 = new menu("오징어김밥", "kimbab", 3499);
            menu 날치알롤 = new menu("날치알롤", "kimbab", 5555);
            menu 땡초김밥 = new menu("땡초김밥", "kimbab", 2555);
            menu 짬뽕라면 = new menu("짬뽕라면", "noodle", 3499);
            menu 떡라면 = new menu("떡라면", "noodle", 3499);
            menu 만두라면 = new menu("만두라면", "noodle", 3999);
            menu 우동 = new menu("우동", "noodle", 3499);
            menu 잔치국수 = new menu("잔치국수", "noodle", 3999);
            menu 칼국수 = new menu("칼국수", "noodle", 4499);
            menu 수제비 = new menu("수제비", "noodle", 4499);
            menu 치즈라면 = new menu("치즈라면", "noodle", 3999);
            menu 떡볶이 = new menu("떡볶이", "bs", 3999);
            menu 치즈떡볶이 = new menu("치즈떡볶이", "bs", 4999);
            menu 라볶이 = new menu("라볶이", "bs", 4999);
            menu 만두국 = new menu("만두국", "bs", 4499);
            menu 군만두 = new menu("군만두", "bs", 3999);
            menu 고기만두 = new menu("고기만두", "bs", 4499);
            menu 비빔밥 = new menu("비빔밥", "meal", 3999);
            menu 김치덮밥 = new menu("김치덮밥", "meal", 3999);
            menu 뚝배기불고기 = new menu("뚝배기불고기", "meal", 4999);
            menu 고등어조림 = new menu("고등어조림", "meal", 5999);
            menu 황태해장국 = new menu("황태해장국", "meal", 5999);
            menu 오므라이스 = new menu("오므라이스", "meal", 4499);
            menu 육개장 = new menu("육개장", "meal", 4499);

            order_list.View = View.Details;

            order_list.GridLines = true;
            order_list.FullRowSelect = true;

            order_list.Columns.Add("음식명",230, HorizontalAlignment.Center);
            order_list.Columns.Add("수량", 75, HorizontalAlignment.Center);
            order_list.Columns.Add("가격",90, HorizontalAlignment.Center);


            // order list Item add
            ListViewItem newmenu = new ListViewItem("날치롤알");
            int ea = 오므라이스.Get_ea();
            newmenu.SubItems.Add("3");
            newmenu.SubItems.Add("16497");

            order_list.Items.Add(newmenu);
            order_list.Items.Add("12331");
            order_list.Items.Add("#####");
            order_list.Items.Add("@!#!#");
            //

            // 테이블 번호 출력
            this.label_teble_count.Text = t_id + "번 테이블";

            // 주문시간 출력
            this.label_order_time.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분");

            food_list.MaximumSize = new Size(food_list.Width, food_list.Height);
            food_list.AutoScroll = true;
           
            
            
        }

        private void btn_all_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_all_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

        }

        private void btn_kimbab_Click(object sender, EventArgs e)
        {

        }

        private void btn_bs_Click(object sender, EventArgs e)
        {

        }

        private void btn_noodle_Click(object sender, EventArgs e)
        {

        }


        private void btn_back_toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }


        // 주문 취소 버튼
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            var item_idx = order_list.SelectedIndices;

            // index 기준 삭제 : 역순으로 삭제 해야 함
            for(int i = item_idx.Count - 1; i >= 0; i--)
            {
                order_list.Items[i].Remove();
            }
        }

        // 주문 전체 취소 버튼
        private void btn_all_cancel_Click_1(object sender, EventArgs e)
        {
            var item_idx = order_list.Items;

            // index 기준 삭제 : 역순으로 삭제 해야 함
            for (int i = item_idx.Count - 1; i >= 0; i--)
            { 
                order_list.Items[i].Remove();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
