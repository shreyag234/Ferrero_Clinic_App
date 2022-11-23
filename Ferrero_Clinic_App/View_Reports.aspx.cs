using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class View_Reports : System.Web.UI.Page
    {
        List<ListItem> files = new List<ListItem>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie cookieObj = Request.Cookies["userCookie"];
                string cookieObj2 = Request.Cookies["userCookie"].Value;
                string message = "alert('Login Successful! " + cookieObj2 + " , welcome!')";
                // ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", message, true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('No cookies :(');", true);
                Response.Redirect("index.aspx");

            }

            string[] filesPath = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Reports/").ToString());

            foreach (string path in filesPath)
            {
                files.Add(new ListItem(Path.GetFileName(path)));
            }
            gvDetails.DataSource = files;

            gvDetails.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            string id = (string)e.CommandArgument;

            string x = gvDetails.Rows[Convert.ToInt32(id)].Cells[0].Text;


            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + x);
            Response.TransmitFile(HttpContext.Current.Server.MapPath("~/Reports/").ToString()+ x);
            Response.End();

        }

        protected void Back_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}