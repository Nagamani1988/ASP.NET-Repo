using System;

namespace ElectricityMiniProject
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
            {
                
                lnkAdd.Visible = false;
                lnkView.Visible = false;
                lnkLogout.Visible = false;
            }
            else
            {
          
                lnkAdd.Visible = true;
                lnkView.Visible = true;
                lnkLogout.Visible = true;
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}
