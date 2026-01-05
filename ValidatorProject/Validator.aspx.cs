using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace ValidatorProject
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =
                UnobtrusiveValidationMode.None;
        }
        protected void ValidateNameFamily(object source, ServerValidateEventArgs args)
        {
            args.IsValid = txtName.Text != txtFamily.Text;
        }
    }
}