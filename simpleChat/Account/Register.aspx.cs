using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simpleChat.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMess.Visible = false;
            if (myUser.isLogged())
            {
                Response.Redirect("~");
            }
        }

        private List<string> formErrors;
        protected void Submit_Click(object sender, EventArgs e)
        {
            formErrors = new List<string>();
            this.validateUserName(userName.Text);
            this.validatePassword(password.Text);
            
            if (formErrors.Count > 0)
            {
                errorMess.Visible = true;
                errorMessages.Text="";
                foreach (var error in formErrors)
                {
                    errorMessages.Text +=error+"<br>";
                }
            }
            else
            {
                errorMess.Visible = false;
                myUser usr = new myUser(this.userName.Text, this.password.Text);
                usr.AddNewOne();
                myUser.login(this.userName.Text);
                Response.Redirect("~");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns> [0]bool valid , errors</returns>
        private bool validateUserName(string username)
        {
            bool valid = true;
            if (!validation.LengthValidation(username, 3, 20))
            {
                formErrors.Add("User Name Must Be Between 3 and 20 Characters in Length");
                valid = false;
            }
            if (!validation.IsMatch(username, @"^\w+$"))
            {
                formErrors.Add("Enter a Valid User Name");
                valid = false;
            }

            if (myUser.findUserByUserName(username) != null)
            {
                formErrors.Add("User Already Exists , Please Choose Another Name");
                valid = false;
            }

            return valid;
        }
        private bool validatePassword(string password)
        {

            bool valid = true;
            if (!validation.IsMatch(password, @"^\w+$"))
            {
                formErrors.Add("Enter a Valid Password");
                valid = false;
            }
            if (!validation.LengthValidation(password, 6, 30))
            {
                formErrors.Add("Password Must Be Between 6 and 30 Characters in Length");
                valid = false;
            }
            if (this.password.Text != confirmPassword.Text)
            {
                formErrors.Add("Passwords Aren't Identical");
                valid = false;
            }
            return valid;
        }
    }
}