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
using Winform_Final.Class_Folder.Class_Object;

namespace Winform_Final.Interfaces.Client_Interface
{
    public partial class Client_HistoryOrdering : Form
    {
        Client user;
        BSBill billDatabase = new BSBill();
        DataSet dataset;
        DataTable dataOrderTable;
        public Client_HistoryOrdering(string username)
        {
            InitializeComponent();
            user = new Client(username);

            user.getClientDetails();
        }

        private void Client_HistoryOrdering_Load(object sender, EventArgs e)
        {
            loadData();  
        }
        public void loadData()
        {
            dataOrderTable = new DataTable();
            dataOrderTable.Clear();

            dataset = billDatabase.getBills_baseOnUser(user.getID());

            dataOrderTable = dataset.Tables[0];
            orderGridView.DataSource = dataOrderTable;
            orderGridView.AutoResizeColumns();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
