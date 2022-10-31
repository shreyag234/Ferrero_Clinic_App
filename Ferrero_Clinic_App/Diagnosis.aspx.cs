using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{
    public partial class Diagnosis : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into [dbo].[Diagnosis](Patient_ID, Diagnosis, Date_of_diagnosis, Medication)" +
               "values(@Patient_ID,@Diagnosis,@Date_of_diagnosis,@Medication)", con);

            cmd.Parameters.AddWithValue("@Patient_ID", patientID_tb.Text);
            cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis_tb.Text);
            cmd.Parameters.AddWithValue("@Date_of_diagnosis", DiagnosisDate_cal.SelectedDate);
            cmd.Parameters.AddWithValue("@Mecdication", Medication_tb.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Patient diagnosis added!');", true);

           // Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}