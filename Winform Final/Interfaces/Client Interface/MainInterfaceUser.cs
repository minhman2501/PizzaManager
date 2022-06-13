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

namespace Winform_Final
{
    public partial class MainInterfaceUser : Form
    {
        string username;
        HomeScreen userHome;
        PizzaMenu menu;

        public MainInterfaceUser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userHome = new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menu = new PizzaMenu(this.username) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.wrapperPanel.Controls.Add(userHome);
            this.wrapperPanel.Controls.Add(menu);
            userHome.Show();
        }
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            userHome.Hide();
            menu.Show();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            menu.Hide();
            userHome.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection forms = Application.OpenForms;
            forms[0].Show();
        }
    }
}
