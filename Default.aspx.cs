using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    clsMessaging clsMessage = new clsMessaging();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        clsMessage.ErrorMessage("This is an Error!");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        clsMessage.SuccessMessage("This is an Success!");
    }
}