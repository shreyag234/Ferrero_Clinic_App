using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iText.Kernel;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using Paragraph = iText.Layout.Element.Paragraph;
using iText.Kernel.Colors;

namespace Ferrero_Clinic_App
{
    public partial class Reports : System.Web.UI.Page
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
        /** The below code was taken form an online souce 
         * Link - https://www.aspsnippets.com/Articles/Create-PDF-Report-from-database-in-ASPNet-using-C-and-VBNet.aspx
         * Author - Khan M
         * 
         */
        private DataTable GetData(string query)
        {

            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection("Data Source =(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Ferrero_DBM.mdf;Integrated Security = True;"))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    adapter.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        protected void Gen_btn_Click(object sender, EventArgs e)
        {
          //  DataRow dr = GetData("SELECT * FROM Diagnosis WHERE Date_of_diagnosis BETWEEN '"+StartDate_cal.SelectedDate+"' AND '"+EndDate_cal.SelectedDate+"' AND Diagnosis= '" + Diagnosis_tb.Text + "'").Rows[0]; ;
            DataTable dt =  GetData("SELECT * FROM Diagnosis WHERE Date_of_diagnosis BETWEEN '"+StartDate_cal.SelectedDate+"' AND '"+EndDate_cal.SelectedDate+"' AND Diagnosis= '" + Diagnosis_tb.Text + "'");
            Document document = new Document(PageSize.A4, 88f, 88f, 10f, 10f);
            Font NormalFont = FontFactory.GetFont("Times New Roman", 12, Font.NORMAL, BaseColor.BLACK);

            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                Phrase phrase = null;
                PdfPCell cell = null;
                PdfPTable table = null;
                Color color = null;

                document.Open();

                //Header Table
                table = new PdfPTable(2);
                table.TotalWidth = 500f;
                table.LockedWidth = true;
                table.SetWidths(new float[] { 0.3f, 0.7f });

                //Company Logo
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(HttpContext.Current.Server.MapPath("~/Images/ferrero_logo.png"));
                PdfPCell imageCell = new PdfPCell(png);
                imageCell.Colspan = 2; // either 1 if you need to insert one cell
                imageCell.Border = 0;
                imageCell.HorizontalAlignment = Element.ALIGN_CENTER;

                table.AddCell(imageCell);

                //Company Name and Address
                phrase = new Phrase();
                Paragraph paragraph = new Paragraph();
                phrase.Add(new Chunk("Ferrero\n\n", FontFactory.GetFont("Times New Roman", 16, Font.BOLD, BaseColor.ORANGE)));
                phrase.Add(new Chunk("Walkerville,\n", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                phrase.Add(new Chunk("177 Daleside Rd,\n", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                phrase.Add(new Chunk("Gauteng, SA", FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)));
                cell = PhraseCell(phrase, PdfPCell.ALIGN_CENTER);
                cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
                table.AddCell(cell);

                //Separater Line
               // color = new Color(System.Drawing.ColorTranslator.FromHtml("#A9A9A9"));
                DrawLine(writer, 25f, document.Top - 79f, document.PageSize.Width - 25f, document.Top - 79f, BaseColor.LIGHT_GRAY);
                DrawLine(writer, 25f, document.Top - 80f, document.PageSize.Width - 25f, document.Top - 80f, BaseColor.LIGHT_GRAY);
                document.Add(table);

                table = new PdfPTable(2);
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.SetWidths(new float[] { 0.3f, 1f });
                table.SpacingBefore = 20f;

                //Diagnosis Details
                cell = PhraseCell(new Phrase("Diagnosis Record", FontFactory.GetFont("Times New Roman", 12, Font.UNDERLINE, BaseColor.BLACK)), PdfPCell.ALIGN_CENTER);
                cell.Colspan = 2;
                table.AddCell(cell);
                cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                cell.Colspan = 2;
                cell.PaddingBottom = 30f;
                table.AddCell(cell);

                foreach (DataRow dr in dt.Rows)
                {
                    //Name
                    phrase = new Phrase();
                    phrase.Add(new Chunk(dr["Diagnosis"].ToString(), FontFactory.GetFont("Times New Roman", 10, Font.BOLD, BaseColor.BLACK)));
                    phrase.Add(new Chunk("(List of patients with the diagnosis)", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)));
                    cell = PhraseCell(phrase, PdfPCell.ALIGN_LEFT);
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);
                    document.Add(table);

                    DrawLine(writer, 160f, 80f, 160f, 690f, BaseColor.BLACK);
                    DrawLine(writer, 115f, document.Top - 200f, document.PageSize.Width - 100f, document.Top - 200f, BaseColor.BLACK);

                    table = new PdfPTable(2);
                    table.SetWidths(new float[] { 0.5f, 2f });
                    table.TotalWidth = 340f;
                    table.LockedWidth = true;
                    table.SpacingBefore = 20f;
                    table.HorizontalAlignment = Element.ALIGN_RIGHT;

                    //Diagnosis Name
                    table.AddCell(PhraseCell(new Phrase("Diagnosis:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    table.AddCell(PhraseCell(new Phrase("" + dr["Diagnosis"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 10f;
                    table.AddCell(cell);

                    //Patient Id
                    table.AddCell(PhraseCell(new Phrase("Patient ID:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    table.AddCell(PhraseCell(new Phrase("" + dr["Patient_ID"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 10f;
                    table.AddCell(cell);
                    //Date of diagnosis
                    table.AddCell(PhraseCell(new Phrase("Date diagnosed:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    table.AddCell(PhraseCell(new Phrase("" + dr["Date_of_diagnosis"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 10f;
                    table.AddCell(cell);
                    //Medication
                    table.AddCell(PhraseCell(new Phrase("Medication:", FontFactory.GetFont("Times New Roman", 8, Font.BOLD, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    table.AddCell(PhraseCell(new Phrase("" + dr["Medication"], FontFactory.GetFont("Times New Roman", 8, Font.NORMAL, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
                    cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
                    cell.Colspan = 2;
                    cell.PaddingBottom = 10f;
                    table.AddCell(cell);
                }

                document.Add(table);
                document.Close();
                
                byte[] bytes = memoryStream.ToArray();
                
                System.IO.File.WriteAllBytes(HttpContext.Current.Server.MapPath("~/Reports/").ToString() + DateTime.Now.ToString("dd-MM-yyyy-HH") + "_DiagnosisReport.pdf", bytes);
                memoryStream.Close();
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "attachment; filename=DiagnosisReport.pdf");
                Response.ContentType = "application/pdf";
                Response.Buffer = true;
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(bytes);
                Response.End();
                Response.Close();


            }
        }

        private static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, BaseColor c)
        {
            PdfContentByte contentByte = writer.DirectContent;
            contentByte.SetColorStroke(c);
            contentByte.MoveTo(x1, y1);
            contentByte.LineTo(x2, y2);
            contentByte.Stroke();
        }
        private static PdfPCell PhraseCell(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
        }

        protected void Back_BTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("DC_Dash_Board.aspx");
        }
    }
}