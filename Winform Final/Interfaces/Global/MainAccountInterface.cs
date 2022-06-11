using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Final.Global
{
    public partial class MainAccountInterface : Form
    {
        LoginAccount loginInterface;
        SignInAccount signInInterface;
        bool isLogging = true;
        public MainAccountInterface()
        {
            InitializeComponent();
            loginInterface = new LoginAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            signInInterface = new SignInAccount() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.contentPanel.Controls.Add(loginInterface);
            loginInterface.Show();
            changeButtonContent(isLogging);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeButtonContent(bool panelState)
        {
            switch (isLogging)
            {
                case true:
                    this.askingLB.Text = "New member ?";
                    this.changeBtn.Text = "Sign Up Now !";
                    break;
                case false:
                    this.askingLB.Text = "Already a member ?";
                    this.changeBtn.Text = "Sign In Now !";
                    break;
                default:
                    this.askingLB.Text = "New member ?";
                    this.changeBtn.Text = "Sign Up Now !";
                    break;
            }  
        }
        private void MainAccountInterface_Load(object sender, EventArgs e)
        {
            changeButtonContent(isLogging);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            switch (isLogging)
            {
                case true:
                    this.contentPanel.Controls.Remove(loginInterface);
                    this.contentPanel.Controls.Add(signInInterface);
                    
                    isLogging = false;
                    changeButtonContent(isLogging);
                    signInInterface.Show();
                    break;
                case false:
                    this.contentPanel.Controls.Remove(signInInterface);
                    this.contentPanel.Controls.Add(loginInterface);
                    isLogging = true;
                    changeButtonContent(isLogging);
                    loginInterface.Show();
                    break;;
                
            }
            
        }
    }
}
