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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE Patient_ID='" + ID_Number_TB01.Text + "'", con);
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
                P_DOB_TB01.Text = rdr["DOB"].ToString().Substring(0, 10);
                P_Add_LB01.Visible = true;
                P_Add_TB01.Visible = true;
                P_Add_TB01.Text = rdr["Street"].ToString();
                P_City_LB01.Visible = true;
                P_City_TB01.Visible = true;
                P_City_TB01.Text = rdr["City"].ToString();
                P_State_LB01.Visible = true;
                P_State_TB01.Visible = true;
                P_State_TB01.Text = rdr["State"].ToString();
                P_ZIP_LB01.Visible = true;
                P_ZIP_TB01.Visible = true;
                P_ZIP_TB01.Text = rdr["Zip"].ToString();
                P_Phone_LB01.Visible = true;
                P_Phone_TB01.Visible = true;
                P_Phone_TB01.Text = rdr["Phone"].ToString();
                P_Email_LB01.Visible = true;
                P_Email_TB01.Visible = true;
                P_Email_TB01.Text = rdr["Email"].ToString();
                P_Occupation_LB01.Visible = true;
                P_Occupation_TB01.Visible = true;
                P_Occupation_TB01.Text = rdr["Occupation"].ToString();
                P_Employer_LB01.Visible = true;
                P_Employer_TB01.Visible = true;
                P_Employer_TB01.Text = rdr["Employer"].ToString();
                P_M_Stat_LB01.Visible = true;
                P_M_Stat_TB01.Visible = true;
                P_M_Stat_TB01.Text = rdr["Marital_Status"].ToString();
                P_SP_F_Name_LB01.Visible = true;
                P_SP_F_Name_TB01.Visible = true;
                P_SP_F_Name_TB01.Text = rdr["Patient_Spouse_Name"].ToString();
                P_Gender_LB01.Visible = true;
                P_Gender_TB01.Visible = true;
                P_Gender_TB01.Text = rdr["Gender"].ToString();
                P_E_Cont_LB01.Visible = true;
                P_E_Cont_TB01.Visible = true;
                P_E_Cont_TB01.Text = rdr["Emg_Contact"].ToString();
                P_Relation_LB01.Visible = true;
                P_Relation_TB01.Visible = true;
                P_Relation_TB01.Text = rdr["Relation"].ToString();
                P_E_Cont_Phone_LB01.Visible = true;
                P_E_Cont_Phone_TB01.Visible = true;
                P_E_Cont_Phone_TB01.Text = rdr["Emg_Phone"].ToString();

            }


        }
    }
}