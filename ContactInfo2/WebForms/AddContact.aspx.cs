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
    public partial class AddContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            if (!(Name.Text == String.Empty))
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                    con.Open();
                    string insert = "insert into Contact (Name, PhoneNumber, Email, StAddress, City, State) values(@Name, @PhoneNumber, @Email, @StAddress, @City, @State)";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", Number.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);          //add all the contact info
                    cmd.Parameters.AddWithValue("@StAddress", StAddress.Text);
                    cmd.Parameters.AddWithValue("@City", City.Text);
                    cmd.Parameters.AddWithValue("@State", State.Text);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("ViewContacts.aspx");
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
            else
            {
                Response.Write("Error: Must Enter Name of Contact.");
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Navigation.aspx");
        }
    }
}