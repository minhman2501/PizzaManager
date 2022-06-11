using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Final.Objects
{
    abstract class Product
    {
        protected int id;

        protected int amount;
        protected string name;
        protected String category = "Pizza";
        protected string price;

        public abstract void Calculate();
        public abstract void printContent();
        
        
    }
}
