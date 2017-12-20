using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using MyFirstWebApp.Helpers;

namespace MyFirstWebApp
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            DataTable dt = new DataTable();
            string cn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cn);
            SqlCommand com = new SqlCommand("sel_ContactsAll", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            try
            {
                con.Open();
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.AutoGenerateColumns = true;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ExportToExcel(GridView1, this);
        }

        DataView ConvertToDataView(DataTable dt)
        {
            DataView dv = new DataView(dt);
            return dv;
        }

        private void ExportToExcel(GridView gridView1, System.Web.UI.Page pPage)
        {

            //DataView dv = ConvertToDataView((DataTable)gridView1.DataSource);
            //DataTable dv1 = ((DataTable)gridView1.DataSource);


            string fileName = Export.ExportHportIDXToOpenXMLCSV(gridView1, "ExportedFile", "Contacts");
            
            pPage.Response.ClearContent();
            pPage.Response.AddHeader("Content-Disposition", "attachment;filename=ExportedFile.xlsx");
            pPage.Response.ContentType = "application/text";
            pPage.Response.Charset = "";
            pPage.Response.Buffer = true;
            pPage.EnableViewState = false;
            pPage.Response.TransmitFile(fileName.ToString());
           
            pPage.Response.Flush();// Sends all currently buffered output to the client.
            pPage.Response.SuppressContent = true;  //Gets or sets a value indicating whether to send HTTP content to the client.
            HttpContext.Current.ApplicationInstance.CompleteRequest();//Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.
            File.Delete(fileName);
        }

        private void ExportToCSV(GridView gridView1, System.Web.UI.Page pPage)
        {
            //DataView dv = ConvertToDataView((DataTable)gridView1.DataSource);

            string fileName = Export.ExportHportIDXToOpenXMLCSV(gridView1, "ExportedFile", "Contacts");
            
            pPage.Response.ClearContent();
            pPage.Response.AddHeader("Content-Disposition", "attachment;filename=ExportedFile.csv");
            pPage.Response.ContentType = "application/text";
            pPage.Response.Charset = "";
            pPage.Response.Buffer = true;
            pPage.EnableViewState = false;

            string exportedFileName = fileName.Replace("xlsx", "csv");
            pPage.Response.TransmitFile(exportedFileName);
            pPage.Response.Flush();// Sends all currently buffered output to the client.
            pPage.Response.SuppressContent = true;  //Gets or sets a value indicating whether to send HTTP content to the client.
            HttpContext.Current.ApplicationInstance.CompleteRequest();//Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.
            File.Delete(exportedFileName);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ExportToCSV(GridView1, this);
        }
    }
}