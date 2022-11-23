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
            cmd.Parameters.AddWithValue("@Appointment_Time", Time_List.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
        }

        protected void back_btn0_Click(object sender, EventArgs e)
        {
            Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}