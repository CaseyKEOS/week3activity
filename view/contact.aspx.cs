using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace weekthree.view
{
    public partial class contact : System.Web.UI.Page
    {
        database db = new database();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            db.save(name.Text, email.Text, phone.Text, message.Text);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record added')", true);
        }
    }
}