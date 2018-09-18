using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.KimRice
{
    public class menu
    {
        public menu(String name, String kind, int price, String imgpath)
        {
            this.name = name;
            this.kind = kind;
            this.price = price;
            this.imgpath = imgpath;
            ea = 1;
        }

        
        public int price;
        public int ea;
        public String name;
        public String kind;
        public String imgpath;

    }
}
