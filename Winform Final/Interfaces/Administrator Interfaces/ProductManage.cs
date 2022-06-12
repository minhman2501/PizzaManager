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

        BSProduct productDatbase = new BSProduct();
        DataSet dataset;

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

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
