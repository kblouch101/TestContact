using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContactInfo2
{
    public partial class Navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoToDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteContact.aspx");
        }

        protected void btnGoToUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateContact.aspx");
        }

        protected void btnGoToView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewContacts.aspx");
        }

        protected void btnGoToAdd_Click(object sender, EventArgs e)
        {
                Response.Redirect("AddContact.aspx");
        }
    }
}