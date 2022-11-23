using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class View_Appointments : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select Patient_ID, FORMAT (Appointment_Date,'dd-MM-yyyy') AS Date, Left(Convert(TIME,Appointment_Time),5) As Time from [dbo].[Appointments] Where Appointment_Date Between '" + DateTime.Today + "' and '" + DateTime.Today.AddDays(3)+"'", con);
                

                adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
                {
                    adapter.Fill(dt);
                Appointment_Grid.DataSource = dt;
                Appointment_Grid.DataBind();
                }
            
        }

        protected void Back_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}