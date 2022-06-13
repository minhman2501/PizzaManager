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
using Winform_Final.Administrator_Interfaces;
using Winform_Final.Client_Interface;

namespace Winform_Final.Global
{
    public partial class LoginAccount : Form
    {
        BSUser userDatabase;
        string err;
        string loginStatus;
        bool isConfirmed = false;
        
        public LoginAccount()
        {
            InitializeComponent(); 
        }

        private void LoginAccount_Load(object sender, EventArgs e)
        {
            resetAll();
            usernameTxt.Focus();
        }
        private void resetAll()
        {
            usernameTxt.ResetText();
            passwordTxt.ResetText();
            clientRadioBtn.Checked = false;
            administratorRadioBtn.Checked = false;
        }
        private bool validate()
        {
            bool hasError = true;
            if (clientRadioBtn.Checked)
            {
                userDatabase = new BSUser();
                Int32 userCount = Convert.ToInt32(userDatabase.countUsers_login(ref err, usernameTxt.Text, passwordTxt.Text));
                if (userCount > 0)
                {
                    loginStatus = "Successfully Signed In";
                    hasError = false;
                    return hasError;
                }
            }
            else if (administratorRadioBtn.Checked)
            {
                if(usernameTxt.Text.Equals("admin") && passwordTxt.Text.Equals("admin"))
                {
                    loginStatus = "Successfully Signed In";
                    hasError = false;
                    return hasError;
                }
            }
            loginStatus = "Invalid login information";
            return hasError;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            isConfirmed = validate();
            MessageBox.Show(loginStatus);
            if (isConfirmed)
            {
                sentToMain();
            }
        }
        public bool sentToMain()
        {
            return isConfirmed;
        }
    }
}
