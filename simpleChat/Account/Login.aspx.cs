using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simpleChat.Account
{
    public partial class Login : System.Web.UI.Page
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
        protected void Login_Click(object sender, EventArgs e)
        {
            formErrors = new List<string>();
            this.validateUserName(userName.Text);
            this.validatePassword(password.Text);
            errorMessages.Text = "";
            if (formErrors.Count > 0)
            {
                errorMess.Visible = true;
                foreach (var error in formErrors)
                {
                    errorMessages.Text += error + "<br>";
                }
            }
            else
            {
                if (AuthorizedLogged())
                {

                    errorMess.Visible = false;
                    myUser.login(this.userName.Text);
                    Response.Redirect("~");
                }
                else
                {

                    errorMess.Visible = true;
                    errorMessages.Text += "User Name or Password May Be Wrong" + "<br>";
                }
            }
        }
        private bool AuthorizedLogged()
        {
            chatAppEntities1 db = new chatAppEntities1();
            return db.users.Where(u => u.username == this.userName.Text && u.password == this.password.Text).Count() > 0;
        }
        private bool validateUserName(string username)
        {
            bool valid = true;

            if (!validation.IsMatch(username, @"^\w+$"))
            {
                formErrors.Add("Enter a Valid User Name");
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


            return valid;
        }
    }
}