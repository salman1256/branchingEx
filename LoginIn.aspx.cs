using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToExplainBranching
{
    public partial class LoginIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPwd.Text))
            {
                lblMsg.Text = "User Name and password are mandatory!!!";

            }
            else {
                if ((txtUserName.Text == "sam1256") && (txtPwd.Text == "sam@1256@1256"))
                {
                    lblMsg.Text = "Login Success!!!";
                }
                else {
                    lblMsg.Text = "Login Fail";
                }
            }

        }
    }
}