using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ContactInfo2
{
    public partial class DeletContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString); //connect with db
                con.Open();

                String delete = "DELETE FROM Contact WHERE Name =@NameToDelete";  //find the name that matches NameToDelete(from text box) and use command delete
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@NameToDelete", NameToDelete.Text);
                cmd.ExecuteNonQuery(); //now complete the delete comand on the db we connected with
                Response.Redirect("ViewContacts.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Navigation.aspx");
        }



        /*
        protected void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                con.Open();
                string delete = "DELETE FROM Contact WHERE Name LIKE @DELETE";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@Name", NameToDelete.Text);

                cmd.ExecuteNonQuery();
                Response.Redirect("ViewContacts.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
        */

        /*
        protected void Delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            //string sqlStatement = "DELETE FROM Contact Where Name LIKE @NameToDelete";

            string sqlStatement = "DELETE FROM Contact Where PhoneNumber ...= @NameToDelete";
            SqlCommand cmd = new SqlCommand(sqlStatement, con);
            con.Open();

            if (cmd.Parameters.Contains(sqlStatement))
                cmd.Parameters.Remove(sqlStatement);
            con.Close();
            Response.Redirect("ViewContacts.aspx");

        }*/
    }
}