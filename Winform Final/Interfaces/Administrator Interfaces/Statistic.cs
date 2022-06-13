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

        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
