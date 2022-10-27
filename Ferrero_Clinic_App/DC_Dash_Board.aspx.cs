using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class DC_Dash_Board : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Login Successful!');", true);
        }

        protected void Add_Patient_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Patient.aspx");
        }
    }
}