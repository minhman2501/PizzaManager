using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Final.Administrator_Interfaces
{
    public partial class MainAdminInterfaces : Form
    {
        ProductManage productInterface;
        public MainAdminInterfaces()
        {
            InitializeComponent();
            productInterface = new ProductManage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.contentPanel.Controls.Add(productInterface);
            productInterface.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection forms = Application.OpenForms;
            forms[0].Show();
        }
    }
}
