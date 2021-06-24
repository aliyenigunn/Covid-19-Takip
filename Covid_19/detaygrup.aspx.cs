using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid_19
{
    public partial class detaygrup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("filyasyonatama.aspx");
        }
    }
}