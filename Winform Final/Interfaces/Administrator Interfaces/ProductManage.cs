using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Final.Business_Layers;

namespace Winform_Final.Administrator_Interfaces
{
    public partial class ProductManage : Form
    {
        DataTable dtProduct = null;
        string err;

        int buttonIndex = 0;

        BSProduct productDatbase = new BSProduct();
        DataSet dataset;

        bool isChange = false;

        public ProductManage()
        {
            InitializeComponent();

        }
        private void LoadData()
        {
            try
            {
                dtProduct = new DataTable();
                dtProduct.Clear();

                dataset = productDatbase.getProductFullDetail();


                dtProduct = dataset.Tables[0];

                productGridView.DataSource = dtProduct;
                productGridView.AutoResizeColumns();

                addProductPanel.Enabled = false;

                //load amount of product into the interface
                loadProductCount();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            buttonIndex = 1;
            addPanel_eventHandler(buttonIndex);
        }
        private void addPanel_eventHandler(int index)
        {
            switch (index)
            {
                case 1:
                    addProductPanel.Enabled = true;
                    productGridView.Enabled = false;
                    newProductCategoryCb.Enabled = true;
                    resetAllTextBoxes();
                    newProductNameTxt.Focus();
                    break;
                case 2:
                    addProductPanel.Enabled = true;
                    productGridView.Enabled = false;
                    newProductCategoryCb.Enabled = false;
                    newProductNameTxt.Focus();
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetAllTextBoxes();
            addProductPanel.Enabled = false;
            productGridView.Enabled = true;
        }

        private void productGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = productGridView.CurrentCell.RowIndex;
            newProductNameTxt.Text = productGridView.Rows[selectedIndex].Cells["ProductName"].Value.ToString();
            newProductCategoryCb.Text = productGridView.Rows[selectedIndex].Cells["Category"].Value.ToString();
            newProductPriceTxt.Text = productGridView.Rows[selectedIndex].Cells["price"].Value.ToString();
            idProductLB.Text = productGridView.Rows[selectedIndex].Cells["ID"].Value.ToString();
            
        }
        private void resetAllTextBoxes()
        {
            newProductCategoryCb.ResetText();
            newProductNameTxt.ResetText();
            newProductPriceTxt.ResetText();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            buttonIndex = 2;
            addPanel_eventHandler(buttonIndex);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BSProduct productData = new BSProduct();
            switch (buttonIndex)
            {
                case 1:
                    productData.addingProduct(newProductNameTxt.Text, newProductCategoryCb.Text, newProductPriceTxt.Text, ref err);
                    LoadData();
                    MessageBox.Show("Successfully Added!");

                    break;
                case 2:
                    if(isChange)
                    {
                        productData.updateProduct(idProductLB.Text, newProductNameTxt.Text, newProductPriceTxt.Text, ref err);
                        LoadData();
                        MessageBox.Show("Successfully Edited!");
                    }

                    break;
            }
            addProductPanel.Enabled = false;
            productGridView.Enabled = true;
        }
        private void loadProductCount()
        {
            totalProductLabel.Text = productDatbase.countProducts(ref err).ToString();
            totalPizzaLabel.Text = productDatbase.countProductTypes(ref err, "Pizza").ToString();
            totalDrinkLabel.Text = productDatbase.countProductTypes(ref err, "Drink").ToString();
        }

        private void newProductNameTxt_TextChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = productGridView.CurrentCell.RowIndex;
            string productID = productGridView.Rows[selectedIndex].Cells["ID"].Value.ToString();

            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Confirm Deleting Product", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                productDatbase.deletingProduct(ref err, productID);
                // Cập nhật lại DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Product has been deleted!");
            }
            else
            {
                // Thông báo 
                MessageBox.Show("Cancel deleting..!");
            }
        }
    }
}
