using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Final.Client_Interface
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        private string foodName;
        private string foodPrice;
        private Image foodImg;

        

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodNameLb.Text = value; }
        }

        

        public string FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; foodPriceLb.Text = value; }
        }


        public Image FoodImg
        {
            get { return foodImg; }
            set { foodImg = value; foodImgPB.Image = value; }
        }





    }
}
