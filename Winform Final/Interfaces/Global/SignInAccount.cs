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

namespace Winform_Final.Global
{
    
    public partial class SignInAccount : Form
    {
        bool isInvalid = false;

        string err = "khonggg";
        BSUser userDatabase;

        public SignInAccount()
        {
            InitializeComponent();
        }

        private void SignInAccount_Load(object sender, EventArgs e)
        {
            
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            validateSignUp();

            if(isInvalid == false)
            {
                userDatabase = new BSUser();
                userDatabase.addingUser(signUp_usernameTxt.Text, signUp_passwordTxt.Text, signUp_fullNameTxt.Text, adressTxt.Text, ref err);
                MessageBox.Show("Sucessfully Registerd");
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void signUp_usernameTxt_Leave(object sender, EventArgs e)
        {
            
        }

        private void signUp_passwordTxt_Leave(object sender, EventArgs e)
        {
            
        }

        private void signUp_fullNameTxt_Leave(object sender, EventArgs e)
        {
            
        }
        private void validateSignUp()
        {
            isInvalid = false;
            //check if username have spacebetween
            string username = signUp_usernameTxt.Text.ToString();
            username.Trim();
            if (username.Contains(" "))
            {
                err = "có khoảng trắng";
                isInvalid = true;

            }

            //check if username has already exist in the database
            userDatabase = new BSUser();
            Int32 usernameCount = Convert.ToInt32(userDatabase.countUsers_username(ref err, username));
            if (usernameCount > 0) 
            {
                err = "có tài khoản rồi";
                isInvalid = true; 
            }
            
        

            if (!reenterTxt.Text.Equals(signUp_passwordTxt.Text))
            {
                err = "mật khẩu nhập lại không khớp";
                isInvalid = true;
            }
            
        }
        private bool isNullorSpace(string original)
        {
            if (String.IsNullOrEmpty(original)) return true;
            return false;
        }

        private void reenterTxt_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
