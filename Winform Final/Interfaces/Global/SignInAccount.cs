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
        string errorValidate;
        string emptyText;
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
            isInvalid = validateSignUp();

            if(isInvalid == false)
            {
                userDatabase = new BSUser();
                userDatabase.addingUser(signUp_usernameTxt.Text, signUp_passwordTxt.Text, signUp_fullNameTxt.Text, adressTxt.Text, ref err);
                MessageBox.Show("Sucessfully Registerd");
            }
            else
            {
                MessageBox.Show(errorValidate);
            }
        }

        private void signUp_usernameTxt_Leave(object sender, EventArgs e)
        {
            if(isNullorSpace(signUp_fullNameTxt.Text))
            {
                emptyText = "username";
            }
        }

        private void signUp_passwordTxt_Leave(object sender, EventArgs e)
        {
            if (isNullorSpace(signUp_fullNameTxt.Text))
            {
                emptyText = "password";
            }
        }

        private void signUp_fullNameTxt_Leave(object sender, EventArgs e)
        {
            if (isNullorSpace(signUp_fullNameTxt.Text))
            {
                emptyText = "full name";
            }
        }
        private bool validateSignUp()
        {
            bool isDone = false;
            bool hasError = false;
            List<string> textboxes = new List<string>() { signUp_fullNameTxt.Text, signUp_passwordTxt.Text, signUp_usernameTxt.Text };
            while (hasError == false && isDone == false)
            {
                //check for empty textboxes
                foreach (string textbox in textboxes)
                {
                    if(isNullorSpace(textbox))
                    {
                        errorValidate = $"Empty {emptyText}";
                        hasError = true;
                    }
                }
                //check if username have spacebetween
                string username = signUp_usernameTxt.Text.ToString();
                username.Trim();
                if (username.Contains(" "))
                {
                    errorValidate = "có khoảng trắng";
                    hasError = true;
                }

                //check if username has already exist in the database
                userDatabase = new BSUser();
                Int32 usernameCount = Convert.ToInt32(userDatabase.countUsers_username(ref err, username));
                if (usernameCount > 0)
                {
                    errorValidate = "có tài khoản rồi";
                    hasError = true;
                }
                if (!reenterTxt.Text.Equals(signUp_passwordTxt.Text))
                {
                    errorValidate = "mật khẩu nhập lại không khớp";
                    hasError = true;
                }
                isDone = true;
            }
            return hasError;
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
