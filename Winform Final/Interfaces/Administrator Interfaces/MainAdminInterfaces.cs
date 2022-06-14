using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Final.Interfaces.Administrator_Interfaces;

namespace Winform_Final.Administrator_Interfaces
{
    public partial class MainAdminInterfaces : Form
    {
        ProductManage productInterface;
        Statistic statisticInterface;
        public MainAdminInterfaces()
        {
            InitializeComponent();
            productInterface = new ProductManage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            statisticInterface = new Statistic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.contentPanel.Controls.Add(productInterface);
            this.contentPanel.Controls.Add(statisticInterface);
            productInterface.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection forms = Application.OpenForms;
            forms[0].Show();
        }

        

        private void foodManageBtn_Click(object sender, EventArgs e)
        {
            statisticInterface.Hide();

            productInterface.Show();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            statisticInterface.Show();

            productInterface.Hide();
        }
    }
}
