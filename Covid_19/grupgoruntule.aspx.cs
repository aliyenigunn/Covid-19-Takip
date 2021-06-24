
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class grupgoruntule : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btngoruntule(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ekipadi as EKİP,tcno as TC,filadsoyad as ADSOYAD,cinsiyet as CİNSİYET,yas as YAŞ,meslek as MESLEK from filyasyonbilgi where ekipadi='"+cbekip.SelectedValue.ToString()+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();
            
        }

        protected void btnyukle(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select distinct ekipadi from filyasyonbilgi", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbekip.Items.Add(dr["ekipadi"].ToString());

            }
            cbekip.SelectedValue = null;
        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("filyasyonkayit.aspx");
        }
    }
}