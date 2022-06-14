using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Final.Client_Interface;
using Winform_Final.Interfaces.Client_Interface;

namespace Winform_Final
{
    public partial class MainInterfaceUser : Form
    {
        string username;
        HomeScreen userHome;
        PizzaMenu menu;
        Client_HistoryOrdering orderHistory;

        public MainInterfaceUser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userHome = new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menu = new PizzaMenu(this.username) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            orderHistory = new Client_HistoryOrdering(this.username) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.wrapperPanel.Controls.Add(orderHistory);
            this.wrapperPanel.Controls.Add(userHome);
            this.wrapperPanel.Controls.Add(menu);
            userHome.Show();
        }
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            userHome.Hide();
            orderHistory.Hide();
            menu.Show();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            menu.Hide();
            userHome.Show();
            orderHistory.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection forms = Application.OpenForms;
            forms[0].Show();
        }

        private void buyHistoryBtn_Click(object sender, EventArgs e)
        {
            orderHistory.loadData();
            orderHistory.Show();
            userHome.Hide();
            menu.Hide();
        }
    }
}
