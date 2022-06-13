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
using Winform_Final.Class_Folder.Class_Object;

namespace Winform_Final.Global
{
    public partial class LoginAccount : Form
    {
        BSUser userDatabase;
        string err;
        string loginStatus;
        bool isAdmin = false;
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
            bool noError = false;
            if (clientRadioBtn.Checked)
            {
                userDatabase = new BSUser();
                Int32 userCount = Convert.ToInt32(userDatabase.countUsers_login(ref err, usernameTxt.Text, passwordTxt.Text));
                if (userCount > 0)
                {
                    loginStatus = "Successfully Signed In";
                    noError = true;
                    isAdmin = false;
                    return noError;
                    
                }
            }
            else if (administratorRadioBtn.Checked)
            {
                if(usernameTxt.Text.Equals("admin") && passwordTxt.Text.Equals("admin"))
                {
                    loginStatus = "Successfully Signed In";
                    noError = true;
                    isAdmin = true;
                    return noError;
                    
                }
            }
            loginStatus = "Invalid login information";
            return noError;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            isConfirmed = validate();
            MessageBox.Show(loginStatus);
            if (isConfirmed)
            {

                switch(isAdmin)
                {
                    case false:
                        MainInterfaceUser user = new MainInterfaceUser(usernameTxt.Text);
                        user.Show();
                        break;
                    case true:
                        MainAdminInterfaces admin = new MainAdminInterfaces();
                        admin.Show();
                        break;
                }
            }            
        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            SignUpAccount signUp = new SignUpAccount();
            signUp.Show();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            resetAll();
        }
    }
}
