using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace ValidatorProject
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProducts.Items.Add("Laptop");
                ddlProducts.Items.Add("Mobile");
                ddlProducts.Items.Add("Headphones");
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "Laptop")
                imgProduct.ImageUrl = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8bGFwdG9wJTIwY29tcHV0ZXJ8ZW58MHx8MHx8fDA%3D"; 
            else if (ddlProducts.SelectedValue == "Mobile")
                imgProduct.ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";

            else if (ddlProducts.SelectedValue == "Headphones")
                imgProduct.ImageUrl = "https://plus.unsplash.com/premium_photo-1678099940967-73fe30680949?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8d2lyZWxlc3MlMjBoZWFkcGhvbmVzfGVufDB8fDB8fHww";
        }
        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "Laptop")
                lblPrice.Text = "Price: ₹50,000";

            else if (ddlProducts.SelectedValue == "Mobile")
                lblPrice.Text = "Price: ₹20,000";

            else if (ddlProducts.SelectedValue == "Headphones")
                lblPrice.Text = "Price: ₹2,000";
        }

    }
}