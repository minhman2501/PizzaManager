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

using System.Data.SqlClient;
using Winform_Final.Business_Layers;

namespace Winform_Final.Client_Interface
{
    public partial class PizzaMenu : Form
    {
        DataTable dtProduct = null;
        string err;

        BSProduct productDatbase = new BSProduct();

        public PizzaMenu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                dtProduct = new DataTable();
                dtProduct.Clear();
                DataSet ds = productDatbase.getProducts();
                dtProduct = ds.Tables[0];
                foodGridView.Rows.Clear();

                foodGridView.DataSource = dtProduct;

                foodGridView.AutoResizeColumns();

                        

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }
        private void PizzaMenu_Load(object sender, EventArgs e)
        {

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void foodGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void foodGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
            int selectedIndex = foodGridView.CurrentCell.RowIndex;
            foreach (DataGridViewRow item in foodGridView.Rows)
            {
                if ((bool)item.Cells[0].Value == true && item.Cells[0].Value != null)
                {
                    int n = cartGridView.Rows.Add();
                    cartGridView.Rows[n].Cells[2].Value = item.Cells[1].Value.ToString();
                    cartGridView.Rows[n].Cells[4].Value = item.Cells[3].Value.ToString();
                }

            }
        }
        //test hàm



    }
}
