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
    public partial class UpdateContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString); //connect w/ database
                con.Open();

                if (!(Number.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET PhoneNumber = @PhoneNumber WHERE Name = @Name"; //where the names match, replace phone #
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text); //withouth this line - get following error: System.Data.SqlClient.SqlException: 'Must declare the scalar variable "@Name".'
                    cmd.Parameters.AddWithValue("@PhoneNumber", Number.Text);
                    cmd.ExecuteNonQuery();
                }

                if (!(Email.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET Email =@Email WHERE Name = @Name"; //where the names match, replace email
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.ExecuteNonQuery();
                }

                if (!(StAddress.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET StAddress =@StAddress WHERE Name = @Name";//where the names match, replace st address
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@StAddress", StAddress.Text);
                    cmd.ExecuteNonQuery();
                }

                if (!(City.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET City =@City WHERE Name = @Name"; //where the names match, replace city
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@City", City.Text);
                    cmd.ExecuteNonQuery();
                }

                if (!(State.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET State =@State WHERE Name = @Name"; //where the names match, replace state
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@State", State.Text);
                    cmd.ExecuteNonQuery();
                }
                if (!(NewName.Text == String.Empty)) //not empty
                {
                    string insert = "UPDATE Contact SET Name = @NewName WHERE Name = @Name"; //where the names match, replace phone #
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Name", Name.Text); //withouth this line - get following error: System.Data.SqlClient.SqlException: 'Must declare the scalar variable "@Name".'
                    cmd.Parameters.AddWithValue("@NewName", NewName.Text);
                    cmd.ExecuteNonQuery();
                }
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
    }
}