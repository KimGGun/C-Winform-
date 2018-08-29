using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.KimRice
{
    public class menu
    {
        public menu(String name, String kind, int price)
        {
            this.name = name;
            this.kind = kind;
            this.price = price;
            ea = 0;
        }

        public int price;
        public int ea;
        public String name;
        public String kind;

        public String Get_kind()
        {
            return kind;
        }

        public String Get_name()
        {
            return name;
        }

        public int Get_ea()
        {
            return ea;
        }

        public int Get_price()
        {
            return price;
        }

        public void Set_kind(String kind)
        {
            this.kind = kind;
        }

        public void Set_name(String name)
        {
            this.name = name;
        }

        public void Set_ea(int ea)
        {
            this.ea = ea;
        }

        public void Set_price(int price)
        {
            this.price = price;
        }
    }
}
