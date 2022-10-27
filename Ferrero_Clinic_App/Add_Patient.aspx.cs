using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Add_Patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DOB_picker.Height = 30;
            DOB_picker.Width = 30;
        }


        protected void Next_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medical_History.aspx");
        }
    }
}