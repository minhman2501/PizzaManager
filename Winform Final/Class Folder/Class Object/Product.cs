using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Final.Class_Folder.Class_Object
{
    class Product
    {
        protected int amount;
        protected string name;
        protected string category;
        protected int price;

        public Product(string name, int price, int amount)
        {
            this.amount = amount;
            this.name = name;
            this.price = price;
        }
        
        public int getPrice()
        {
            return this.price;
        }

        public int calculate()
        {
            return this.getPrice() * this.amount;
        }
        protected string printContent()
        {
            string content = $"{this.category}: {this.name}; Amount: x{this.amount}; Price:{this.calculate()}";
            return content;

        }

    }
}
