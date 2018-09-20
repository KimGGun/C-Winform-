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
        public int menu_int =0;
        public int[] food_arr = new int[100];
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
                text_order_price.Text = "전체 금액 : 0";
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
            order_list.Columns.Add("음식명", 210, HorizontalAlignment.Center);
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
            menu 떡라면 = new menu("떡라면", "noodle", 3499, "ttukmen");
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
            all_food.Add(라볶이);
            all_food.Add(떡볶이);
            all_food.Add(만두국);
            all_food.Add(고기만두);
            all_food.Add(비빔밥);
            all_food.Add(김치덮밥);
            all_food.Add(뚝배기불고기);
            all_food.Add(고등어조림);
            all_food.Add(황태해장국);
            all_food.Add(오므라이스);
            all_food.Add(육개장);


            menu_int = all_food.Count;
        }

        private void Set_foodlist()
        {
            try
            {
                ResourceManager rm = Properties.Resources.ResourceManager;
                food_list.AutoScroll = true;
                int buttonWidth = 260;
                int buttonHeight = 256;
                for (int i = 0; i < all_food.Count; i++)
                {
                
                    Button thisButton = new Button
                    {
                        Width = buttonWidth,
                        Height = buttonHeight
                    };
                    thisButton.Click += menu_click;
                    
                    Bitmap backImage = (Bitmap)rm.GetObject(all_food[i].imgpath);
                    backImage = new Bitmap(backImage, new Size(260, 256));
                    thisButton.BackgroundImage = backImage;

                    thisButton.Text = all_food[i].name;//+"  "+all_food[i].price+"원";
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

        

        private void btn_back_toMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void menu_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = 0;
            String menu_name = btn.Text;
            for(int i =  0; i < all_food.Count; i++)
            {
                if (all_food[i].name.Equals(menu_name))
                {
                    index = i;
                }
            }

            ex_image.BackgroundImage = btn.BackgroundImage;
            ex_image.BackgroundImage = new Bitmap(ex_image.BackgroundImage, new Size(490, 235));


            menu_name = null;

            
            add_order(index);
            Set_orderPrice();
        }

        private void add_order(int index)
        {
            ListViewItem newOrder = new ListViewItem(all_food[index].name);
            for(int i = 0; i < order_list.Items.Count; i++)
            {
                if(order_list.Items[i].Text == all_food[index].name)
                {
                    int new_ea = Int32.Parse(order_list.Items[i].SubItems[1].Text);
                    int new_price = Int32.Parse(order_list.Items[i].SubItems[2].Text);

                    new_ea += 1;
                    new_price = new_ea * all_food[i].price;

                    order_list.Items[i].SubItems[1].Text = new_ea.ToString("G");
                    order_list.Items[i].SubItems[2].Text = new_price.ToString("G");

                    return;
                }
            }

            newOrder.SubItems.Add(all_food[index].ea.ToString("G"));
            newOrder.SubItems.Add(all_food[index].price.ToString("G"));

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

            Set_orderPrice();
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

            Set_orderPrice();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            var selected_idx = order_list.SelectedIndices;
            for(int i = selected_idx.Count - 1; i >= 0 ; i--)
            {
                int new_ea = Int32.Parse(order_list.Items[i].SubItems[1].Text);
                int now_price = Int32.Parse(order_list.Items[i].SubItems[2].Text);
                int ori_price = now_price / new_ea;
                int new_price;
                new_ea++;
                new_price = new_ea * ori_price;

                order_list.Items[i].SubItems[1].Text = new_ea.ToString("G");
                order_list.Items[i].SubItems[2].Text = new_price.ToString("G");

                Set_orderPrice();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            var selected_idx = order_list.SelectedIndices;
            for (int i = selected_idx.Count - 1; i >= 0; i--)
            {
                
                int new_ea = Int32.Parse(order_list.Items[i].SubItems[1].Text);
                int now_price = Int32.Parse(order_list.Items[i].SubItems[2].Text);
                if(new_ea == 1)
                {
                    order_list.Items[i].Remove();
                    Set_orderPrice();
                    return;
                }
                int ori_price = now_price / new_ea;
                int new_price;
                new_ea--;
                new_price = new_ea * ori_price;

                order_list.Items[i].SubItems[1].Text = new_ea.ToString("G");
                order_list.Items[i].SubItems[2].Text = new_price.ToString("G");

                Set_orderPrice();
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Reset_foodlist();
            Set_foodlist();
        }

        private void Reset_foodlist()
        {
            for(int i = food_list.Controls.Count - 1; i >= 0; i--)
            {
                food_list.Controls.RemoveAt(i);
            }
        }

        private void btn_kimbab_Click(object sender, EventArgs e)
        {
            remake_list("kimbab");
        }

    

        private void remake_list(String kind)
        {
         
            Reset_foodlist();

            for (int i = 0; i < all_food.Count; i++)
            {
                if (all_food[i].kind.Equals(kind))
                {
                    try
                    {
                        ResourceManager rm = Properties.Resources.ResourceManager;
                        food_list.AutoScroll = true;
                        int buttonWidth = 260;
                        int buttonHeight = 256;


                        Button thisButton = new Button
                        {
                            Width = buttonWidth,
                            Height = buttonHeight
                        };
                        thisButton.Click += menu_click;

                        Bitmap backImage = (Bitmap)rm.GetObject(all_food[i].imgpath);
                        backImage = new Bitmap(backImage, new Size(260, 256));
                        thisButton.BackgroundImage = backImage;

                        thisButton.Text = all_food[i].name;
                        thisButton.TextAlign = ContentAlignment.BottomLeft;
                        thisButton.Font = new Font("Serif", 16, FontStyle.Bold);

                        food_list.Controls.Add(thisButton);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
            }
        }

        private void btn_bs_Click(object sender, EventArgs e)
        {
            remake_list("bs");
        }

        private void btn_meal_Click(object sender, EventArgs e)
        {
            remake_list("meal");
        }

        private void btn_noodle_Click(object sender, EventArgs e)
        {
            remake_list("noodle");
        }
    }
}
