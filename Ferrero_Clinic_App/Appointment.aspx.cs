using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Appointment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie cookieObj = Request.Cookies["userCookie"];
                string cookieObj2 = Request.Cookies["userCookie"].Value;
                string message = "alert('Login Successful! " + cookieObj2 + " , welcome!')";

                List<string> query = Enumerable.Range(0, 40).Select(i =>
                 DateTime.Today.AddHours(7).AddMinutes(i * 15).ToString("HH:mm")).ToList();
                Time_List.DataSource = query;
                Time_List.DataBind();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "alert", "alert('No cookies :(');", true);
                Response.Redirect("index.aspx");

            }
           
        }

        protected void Add_btn_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Appointments](Patient_ID, Appointment_Date, Appointment_Time)" +
                "values(@Patient_ID,@Appointment_Date,@Appointment_Time)", con);

            cmd.Parameters.AddWithValue("@Patient_ID", ID_tb.Text);
            cmd.Parameters.AddWithValue("@Appointment_Date", DatetoBook_cal.SelectedDate);
            cmd.Parameters.AddWithValue("@Appointment_Time", Time_List.SelectedValue.ToString());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Appointment Booked!');", true);

        }
    }
}