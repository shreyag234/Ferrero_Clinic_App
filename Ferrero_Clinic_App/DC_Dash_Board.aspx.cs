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

        }

        protected void Add_Patient_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Patient.aspx");
        }

        protected void Veiw_Patient_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Patient.aspx");
        }

        protected void Generate_Report_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void View_Past_Reports_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Reports.aspx");
        }

        protected void Add_appointment_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Appointment.aspx");
        }

        protected void LogOUT_btn_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current != null)
            {
                int cookieCount = HttpContext.Current.Request.Cookies.Count;
                for (var i = 0; i < cookieCount; i++)
                {
                    var cookie = HttpContext.Current.Request.Cookies[i];
                    if (cookie != null)
                    {
                        var expiredCookie = new HttpCookie(cookie.Name)
                        {
                            Expires = DateTime.Now.AddDays(-1),
                            Domain = cookie.Domain
                        };
                        HttpContext.Current.Response.Cookies.Add(expiredCookie); // overwrite it
                    }
                }

                // clear cookies server side
                HttpContext.Current.Request.Cookies.Clear();
            }
            Response.Redirect("index.aspx");

        }

        protected void Diagnosis_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Diagnosis.aspx");
        }

        protected void Veiw_Calandar_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Appointments.aspx");
        }
    }
}