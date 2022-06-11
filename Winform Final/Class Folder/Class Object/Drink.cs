using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Final.Class_Folder.Class_Object
{
    public class Drink : Product
    {
        public Drink(string name, int price, int amount) : base(name, price, amount)
        {
            this.category = "Drink";
        }
    }
}
