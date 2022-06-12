using System;
using System.Windows.Forms;
using Winform_Final.Client_Interface;

namespace Winform_Final
{
    public partial class MainInterfaceUser : Form
    {

        HomeScreen userHome;
        PizzaMenu menu;

        public MainInterfaceUser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            userHome = new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menu = new PizzaMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.wrapperPanel.Controls.Add(userHome);
            this.wrapperPanel.Controls.Add(menu);
            userHome.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
