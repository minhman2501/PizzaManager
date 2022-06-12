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

namespace Winform_Final.Interfaces.Global
{
    public partial class Bill_Interface : Form
    {
        private List<Product> productList = new List<Product>();
        public Bill_Interface()
        {
            InitializeComponent();
        }

        public Bill_Interface(List<Product> products)
        {
            InitializeComponent();
            productList = new List<Product>();
            foreach(Product item in products)
            {
                productList.Add(item);
            }
        }
        private void LoadBill()
        {
            foreach (Product item in productList)
            {
                int n = bill_itemGridView.Rows.Add();
                bill_itemGridView.Rows[n].Cells["quantity"].Value = n+1;
                bill_itemGridView.Rows[n].Cells["description"].Value = item.printContent();
                bill_itemGridView.Rows[n].Cells["unitPrice"].Value = item.getPrice().ToString();
                bill_itemGridView.Rows[n].Cells["amountPrice"].Value = item.calculate().ToString();
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
    }
}
