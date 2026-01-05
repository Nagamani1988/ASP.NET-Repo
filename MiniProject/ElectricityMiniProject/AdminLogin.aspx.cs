using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityMiniProject
{
    public partial class AdminLogin : System.Web.UI.Page

    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Mani" && txtPassword.Text == "Sam2019")
            {
                Session["Admin"] = "true";   
                Response.Redirect("AddBill.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid Username or Password";
            }
        }
    }
    }
