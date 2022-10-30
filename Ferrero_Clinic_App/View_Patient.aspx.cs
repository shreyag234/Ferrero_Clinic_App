using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ferrero_Clinic_App
{

    public partial class View_Patient : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_BTN_01_Click(object sender, EventArgs e)
        {

            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT Patient_Name, Patient_Surname,DOB FROM Patients WHERE Patient_ID=" + Convert.ToInt32(ID_Number_TB01.Text), con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PF_Name_LB01.Visible = true;
                PF_Name_TB01.Visible = true;
                PF_Name_TB01.Text = rdr["Patient_Name"].ToString();
                PS_Name_LB01.Visible = true;
                PS_Name_TB01.Visible = true;
                PS_Name_TB01.Text = rdr["Patient_Surname"].ToString();
                P_DOB_LB01.Visible = true;
                P_DOB_TB01.Visible = true;
                P_DOB_TB01.Text = rdr["DOB"].ToString().Substring(0,10);

            }
            
 
        }
    }
}