using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid_19
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhastakayit(object sender, EventArgs e)
        {
            Response.Redirect("hastakayit.aspx");
        }

        protected void btntemaslikayit(object sender, EventArgs e)
        {
            Response.Redirect("temaslihastakayit.aspx");
        }

        protected void btnfilkayit(object sender, EventArgs e)
        {
            Response.Redirect("filyasyonkayit.aspx");
        }

        protected void btnfilatama(object sender, EventArgs e)
        {
            Response.Redirect("filyasyonatama.aspx");
        }
    }
}