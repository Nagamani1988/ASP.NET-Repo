using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityMiniProject
{
    public partial class AddBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (Session["TotalBills"] == null)
            {
                int totalBills = Convert.ToInt32(txtTotalBills.Text);

                Session["TotalBills"] = totalBills;
                Session["CurrentCount"] = 0;
            }

         
            int total = (int)Session["TotalBills"];
            int current = (int)Session["CurrentCount"];

            if (current >= total)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "Bill limit reached. You cannot add more bills.";
                return; 
            }

            try
            {
                BillValidator validator = new BillValidator();
                ElectricityBoard board = new ElectricityBoard();
                ElectricityBill eb = new ElectricityBill();

                eb.ConsumerNumber = txtConsumerNo.Text;
                eb.ConsumerName = txtName.Text;

                int units = Convert.ToInt32(txtUnits.Text);

                string msg = validator.ValidateUnitsConsumed(units);
                if (msg != "Valid")
                {
                    lblMsg.Text = msg;
                    return;
                }

                eb.UnitsConsumed = units;

                board.CalculateBill(eb);
                board.AddBill(eb);

                
                Session["CurrentCount"] = current + 1;

                
                if ((int)Session["CurrentCount"] < (int)Session["TotalBills"])
                {
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Text = "Bill added. Enter next bill.";

                    txtConsumerNo.Text = "";
                    txtName.Text = "";
                    txtUnits.Text = "";
                }
                else
                {
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Text = "All bills added successfully!";
                    btnAdd.Enabled = false; 
                }
            }
            catch (FormatException ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

    }
}
