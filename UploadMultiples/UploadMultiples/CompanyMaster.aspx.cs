using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace UploadMultiples
{
    public partial class fileUpload : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
   
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into CompanyMaster values(@name,@status,@path)";
            con.Open();
            Label1.Text = "";
            if (FileUpload1.HasFiles)
            {
                foreach(HttpPostedFile fu in FileUpload1.PostedFiles)
                {
                    string path ="/images/" +fu.FileName;
                    cmd.Parameters.AddWithValue("@name", fu.FileName);
                    cmd.Parameters.AddWithValue("@path", path);
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        fu.SaveAs(Path.Combine(Server.MapPath("/images"), fu.FileName));
                        Label1.Text += string.Format("{0}<br>", fu.FileName+ "Uploaded and save to Database");
                        cmd.Parameters.Clear();
                    }
                    
                   
                }

            }else
            {
                Label1.Text = "Select a file First";
            }
        }
    }
}