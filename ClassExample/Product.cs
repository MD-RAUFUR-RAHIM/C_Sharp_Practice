using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
 public class Product
    {
        public double price;
        public string name;
        public virtual string GetUrlFriendName()
        {
            return name.ToLower().Replace(' ', '-');
        }
        public string GetUrlFriendName(char c)
        {
            return name.ToLower().Replace(' ', c);
        }
        public double GetRoundedPrice()
        {
            return Math.Round(price);
        }



        public Product(string name, double price)
        {
            this.price = price;
            this.name = name;
           
        }
        public Product() : this("Maruf", 0)
        {

        }
        public Product(int x, int z, int y) : this()
        {
            if (x > 0)
            {
                this.name = "khan";
            }
        }



        protected int id;

    }
   
}
