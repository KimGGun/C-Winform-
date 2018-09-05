using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr.KimRice
{
    public partial class Form2 : Form
    {
        public int t_id;
        public int order_price;
        public int menu_int;

        public List<menu> all_food = new List<menu>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Food_init();
            Set_foodlist();
            Set_orderlist();
            Set_orderPrice();
            
            // order list Item add
            /*ListViewItem newmenu = new ListViewItem("날치롤알");
            newmenu.SubItems.Add("3");
            newmenu.SubItems.Add("16497");
            
            order_list.Items.Add(newmenu);
            order_list.Items.Add("12331");
            order_list.Items.Add("#####");
            order_list.Items.Add("@!#!#");
            //*/

            // 테이블 번호 출력
            this.label_teble_count.Text = t_id + "번 테이블";

            // 주문시간 출력
            this.label_order_time.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분");

            food_list.MaximumSize = new Size(food_list.Width, food_list.Height);
            food_list.AutoScroll = true;
           
            
            
        }

        private void Set_orderPrice()
        {
            if(order_list.Items.Count == 0)
            {
                text_order_price.Text += 0;
            } else
            {
                for(int i = 0; i < order_list.Items.Count; i++)
                {
                    order_price += Int32.Parse(order_list.Items[i].SubItems[2].Text);
                }
                text_order_price.Text = "전체 금액 : "; 
                text_order_price.Text += order_price;
                order_price = 0;
            }
        }

        private void Set_orderlist()
        {
            order_list.View = View.Details;
            order_list.GridLines = true;
            order_list.FullRowSelect = true;
            order_list.Columns.Add("음식명", 230, HorizontalAlignment.Center);
            order_list.Columns.Add("수량", 75, HorizontalAlignment.Center);
            order_list.Columns.Add("가격", 90, HorizontalAlignment.Center);
        }

        private void Food_init()
        {
            menu 불고기김밥 = new menu("불고기김밥", "kimbab", 2999, "boolkim");
            menu 새싹김밥 = new menu("새싹김밥", "kimbab", 2999, "saessackim");
            menu 야채김밥 = new menu("야채김밥", "kimbab", 1999, "yakim");
            menu 오징어김밥 = new menu("오징어김밥", "kimbab", 3499, "ojingkim");
            menu 날치알롤 = new menu("날치알롤", "kimbab", 5555, "nalchirol");
            menu 땡초김밥 = new menu("땡초김밥", "kimbab", 2555, "ttangchokim");
            menu 짬뽕라면 = new menu("짬뽕라면", "noodle", 3499,"jjambbongmen");
            menu 떡라면 = new menu("떡라면", "noodle", 3499, "ttukbokki");
            menu 만두라면 = new menu("만두라면", "noodle", 3999, "mandumen");
            menu 우동 = new menu("우동", "noodle", 3499, "woodongment");
            menu 잔치국수 = new menu("잔치국수", "noodle", 3999, "janchimen");
            menu 칼국수 = new menu("칼국수", "noodle", 4499, "swardmen");
            menu 수제비 = new menu("수제비", "noodle", 4499, "soojebi");
            menu 치즈라면 = new menu("치즈라면", "noodle", 3999, "cheezemen");
            menu 떡볶이 = new menu("떡볶이", "bs", 3999, "ttukboki");
            menu 라볶이 = new menu("라볶이", "bs", 4999, "rabokki");
            menu 만두국 = new menu("만두국", "bs", 4499, "manduguk");
            menu 고기만두 = new menu("고기만두", "bs", 4499, "gogimandu");
            menu 비빔밥 = new menu("비빔밥", "meal", 3999, "bibimbab");
            menu 김치덮밥 = new menu("김치덮밥", "meal", 3999, "kimchibab");
            menu 뚝배기불고기 = new menu("뚝배기불고기", "meal", 4999, "ttucbool");
            menu 고등어조림 = new menu("고등어조림", "meal", 5999, "highjorim");
            menu 황태해장국 = new menu("황태해장국", "meal", 5999, "hwangtaehae");
            menu 오므라이스 = new menu("오므라이스", "meal", 4499, "omrice");
            menu 육개장 = new menu("육개장", "meal", 4499, "sixjang");
            

            all_food.Add(불고기김밥);
            all_food.Add(새싹김밥);
            all_food.Add(야채김밥);
            all_food.Add(오징어김밥);
            all_food.Add(날치알롤);
            all_food.Add(땡초김밥);
            all_food.Add(짬뽕라면);
            all_food.Add(떡라면);
            all_food.Add(만두라면);
            all_food.Add(우동);
            all_food.Add(잔치국수);
            all_food.Add(칼국수);
            all_food.Add(수제비);
            all_food.Add(치즈라면);
            all_food.Add(떡볶이);
            all_food.Add(라볶이);
            all_food.Add(만두국);
        }

        private void Set_foodlist()
        {
            try
            {
                ResourceManager rm = Properties.Resources.ResourceManager;
                food_list.AutoScroll = true;
                int buttonWidth = 260;
                int buttonHeight = 256;
                for (int i = 0; i < all_food.Count+1; i++)
                {
                    Button thisButton = new Button
                    {
                        Width = buttonWidth,
                        Height = buttonHeight
                    };
                    thisButton.Click += menu_click;
                    menu_int = i;
                    Bitmap backImage = (Bitmap)rm.GetObject(all_food[i].imgpath);
                    backImage = new Bitmap(backImage, new Size(260, 256));
                    thisButton.BackgroundImage = backImage;

                    thisButton.Text = all_food[i].name+"  "+all_food[i].price+"원";
                    thisButton.TextAlign = ContentAlignment.BottomLeft;
                    thisButton.Font = new Font("Serif", 16, FontStyle.Bold);

                    food_list.Controls.Add(thisButton);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
                
        }

        // 이미지 크기를 버튼 크기에 맞추기
        private Bitmap ResizeBit(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;

            return image;
        }


        private void btn_all_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }

      

        private void btn_all_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
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

        private void menu_click(object sender, EventArgs e)
        {
            int i = menu_int;
            add_order(all_food[i].name, all_food[i].ea, all_food[i].price);
            Set_orderPrice();
        }

        private void add_order(String name, int ea, int price)
        {
            ListViewItem newOrder = new ListViewItem(name);
            for(int i = 0; i < order_list.Items.Count; i++)
            {
                if(order_list.Items[i].Text == name)
                {
                    int new_ea = Int32.Parse(order_list.Items[i].SubItems[1].Text);
                    int new_price = Int32.Parse(order_list.Items[i].SubItems[2].Text);

                    new_ea += 1;
                    new_price = new_ea * new_price;

                    order_list.Items[i].SubItems[1].Text = new_ea.ToString("G");
                    order_list.Items[i].SubItems[2].Text = new_price.ToString("G");

                    return;
                }
            }

            newOrder.SubItems.Add(ea.ToString("G"));
            newOrder.SubItems.Add(price.ToString("G"));

            order_list.Items.Add(newOrder);

        }


        // 주문 취소 버튼
        private void btn_cancel_Click(object sender, EventArgs e)
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
