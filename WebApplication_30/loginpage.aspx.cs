using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_30
{
    public partial class loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Welcome to Login Page");
            }
            else
            {
                if (txtusername.Text == "sravani" && txtpassword.Text == "sravani@123")
                {
                    
                    Response.Write("You have logged in successfully");

                    
                   
                }
                else
                {
                    lblmessage.Text = "Invalid userid/password... Pls check..";
                }

            }

        }
    }
}