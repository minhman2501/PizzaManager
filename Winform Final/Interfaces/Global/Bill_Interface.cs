using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
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

namespace Winform_Final.Interfaces.Global
{
    public partial class Bill_Interface : Form
    {
        Client buyingUser;
        string billContent;
        string orderingStatus;

        
        string err = "khongggg";
        bool isValid = false;
        private List<Product> productList = new List<Product>();


        BSBill billDatabase = new BSBill();
        public Bill_Interface()
        {
            InitializeComponent();
        }

        public Bill_Interface(List<Product> products, Client user)
        {
            InitializeComponent();
            productList = new List<Product>();
            foreach (Product item in products)
            {
                productList.Add(item);
            }

            this.buyingUser = user;
        }
        private void LoadBill()
        {
            clientName.Text = buyingUser.getFullName();
            clientAddressTxt.Text = buyingUser.getAddress();
            billContent = "";
            foreach (Product item in productList)
            {
                int n = bill_itemGridView.Rows.Add();
                bill_itemGridView.Rows[n].Cells["quantity"].Value = n+1;
                bill_itemGridView.Rows[n].Cells["description"].Value = item.printContent();
                bill_itemGridView.Rows[n].Cells["unitPrice"].Value = item.getPrice().ToString();
                bill_itemGridView.Rows[n].Cells["amountPrice"].Value = item.calculate().ToString();
                getBillContent(item.printContent());
            }
            this.total_priceLB.Text = calculateTotalInvoice().ToString();
        }
        private int calculateTotalInvoice()
        {
            int total = 0;
            foreach(Product item in productList)
            {
                total += item.calculate();
            }
            return total;
        }

        private void Bill_Interface_Load(object sender, EventArgs e)
        {
            LoadBill();
        }
        private void getBillContent(string itemContent)
        {
            this.billContent = this.billContent + $"{itemContent}    " ;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            bool isDone = false;
            isValid = validate();
            if (isValid)
            {
                try
                {
                    billDatabase = new BSBill();
                    billDatabase.addingBill(buyingUser.getID().ToString(), total_priceLB.Text.Trim(), billContent, clientAddressTxt.Text, invoiceDateDTP.Text, ref err);
                    orderingStatus = "Succesfully Odered! Have a nice meal";
                    isDone = true;
                }
                catch(SqlException)
                {
                    orderingStatus = "Bug";
                }
            }
            MessageBox.Show(orderingStatus);
            if (isDone) this.Close();
        }
        private bool validate()
        {
            if (String.IsNullOrEmpty(clientAddressTxt.Text) || total_priceLB.Text.Equals("0"))
            {
                orderingStatus = "Missing information for the ordering process";
                return false;
            }
            return true;
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
