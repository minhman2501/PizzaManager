using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Final.Class_Folder.Class_Object;

using System.Data.SqlClient;
using Winform_Final.Business_Layers;
using Winform_Final.Interfaces.Global;

namespace Winform_Final.Client_Interface
{
    public partial class PizzaMenu : Form
    {
        Client user;
        DataTable dtProduct = null;
        string err;

        BSProduct productDatbase = new BSProduct();
        DataSet dataset;
       
        public PizzaMenu()
        {
            InitializeComponent();
        }
        public PizzaMenu(string username)
        {
            InitializeComponent();
            user = new Client(username);
        }
        private void LoadData()
        {
            try
            {
                dtProduct = new DataTable();
                dtProduct.Clear();

                dataset = productDatbase.getProducts();
   
                dtProduct = dataset.Tables[0];
                
                
                foodGridView.DataSource = dtProduct;
                foodGridView.AutoResizeColumns();
                this.user.getClientDetails();
                userFullNameTxt.Text = user.getFullName();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }
        private void PizzaMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void foodGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = foodGridView.CurrentCell.RowIndex;

            if (foodGridView.Rows[selectedIndex].Cells[0].Value == null || (bool)foodGridView.Rows[selectedIndex].Cells[0].Value == false)
            {
                foodGridView.Rows[selectedIndex].Cells[0].Value = true;
            }
            else 
            { 
                foodGridView.Rows[selectedIndex].Cells[0].Value = false;
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            int amount = 1;
            foreach (DataGridViewRow item in foodGridView.Rows)
            {
                if (item.Cells["select"].Value == null)
                {
                    item.Cells["select"].Value = false;
                }
                if ((bool)item.Cells[0].Value == true)
                {
                    foreach (DataGridViewRow cart_item in cartGridView.Rows)
                    {
                        amount = Convert.ToInt32(cart_item.Cells["cart_itemAmount"].Value);
                        if (cart_item.Cells["cart_itemName"].Value.ToString().Contains(item.Cells["ProductName"].Value.ToString()))
                        {
                            amount++;
                            cart_item.Cells["cart_itemAmount"].Value = amount.ToString();
                            break;
                        }
                        else 
                        {
                            amount = 1;
                            continue;
                        }
                    }
                    if (amount == 1)
                    {
                        int n = cartGridView.Rows.Add();
                        cartGridView.Rows[n].Cells["cart_itemName"].Value = item.Cells["ProductName"].Value.ToString();
                        cartGridView.Rows[n].Cells["cart_itemCategory"].Value = item.Cells["Category"].Value.ToString();
                        cartGridView.Rows[n].Cells["cart_itemPrice"].Value = item.Cells["Price"].Value.ToString();
                        cartGridView.Rows[n].Cells["cart_itemAmount"].Value = amount.ToString();
                    }
                }

            }
        }
        private void PizzaListBtn_Click(object sender, EventArgs e)
        {
            dataset = productDatbase.getProduct_baseOnCategory("Pizza");
            dtProduct = dataset.Tables[0];
            foodGridView.DataSource = dtProduct;
            foodGridView.AutoResizeColumns();
        }

        private void DrinkListBtn_Click(object sender, EventArgs e)
        {
            dataset = productDatbase.getProduct_baseOnCategory("Drink");
            dtProduct = dataset.Tables[0];
            foodGridView.DataSource = dtProduct;
            foodGridView.AutoResizeColumns();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cartGridView.Rows.RemoveAt(cartGridView.CurrentCell.RowIndex);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cartGridView.Rows.Clear();
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string type;
            List<Product> itemList = new List<Product>();
            foreach(DataGridViewRow item in cartGridView.Rows)
            {
                type = item.Cells["cart_itemCategory"].Value.ToString();
                switch(type)
                {
                    case "Pizza":
                        itemList.Add(new Pizza(item.Cells["cart_itemName"].Value.ToString(), Convert.ToInt32(item.Cells["cart_itemPrice"].Value), Convert.ToInt32(item.Cells["cart_itemAmount"].Value)));
                        break;
                    case "Drink":
                        itemList.Add(new Drink(item.Cells["cart_itemName"].Value.ToString(), Convert.ToInt32(item.Cells["cart_itemPrice"].Value), Convert.ToInt32(item.Cells["cart_itemAmount"].Value)));
                        break;
                }
            }
            Bill_Interface bill = new Bill_Interface(itemList, this.user);
            bill.Show();
        }

        private void allProductBtn_Click(object sender, EventArgs e)
        {
            dataset = productDatbase.getProducts();
            dtProduct = dataset.Tables[0];
            foodGridView.DataSource = dtProduct;
            foodGridView.AutoResizeColumns();
        }
    }
}
