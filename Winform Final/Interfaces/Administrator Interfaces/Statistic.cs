using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Final.Business_Layers;

namespace Winform_Final.Interfaces.Administrator_Interfaces
{
    public partial class Statistic : Form
    {
        BSUser clientDatabase = new BSUser();
        DataSet clientData;
        BSBill billDatabase = new BSBill();
        DataSet billData;

        string err = "Error";
        int totalIncome = 0;

        DataTable clientTable;
        DataTable billTable;


        public Statistic()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            clientTable = new DataTable();

            billTable = new DataTable();
            clientTable.Clear();
            billTable.Clear();

            clientData = clientDatabase.getUserDetails();
            billData = billDatabase.getBills_Full();




            clientTable = clientData.Tables[0];
            billTable = billData.Tables[0];

            orderGridView.DataSource = billTable;
            userGridView.DataSource = clientTable;
            orderGridView.AutoResizeColumns();
            userGridView.AutoResizeColumns();

            totalIncome = calculateTotalIncome();
            totalIIncomeLB.Text = totalIncome.ToString();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = userGridView.CurrentCell.RowIndex;
            string clientID = userGridView.Rows[selectedIndex].Cells["userID"].Value.ToString();

            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Confirm Deleting User Account !", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                clientDatabase.deletingProduct(ref err, clientID);
                billDatabase.deletingBill_basedOnUser(ref err, clientID);
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

        private int calculateTotalIncome()
        {
            int total = 0;
            foreach(DataGridViewRow orderRow in orderGridView.Rows)
            {
                total += Convert.ToInt32(orderRow.Cells["totalPrice"].Value);
            }
            return total;
        }
    }
}
