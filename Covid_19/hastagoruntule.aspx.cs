using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Covid_19
{
    public partial class hastagoruntule : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select h.tcno as TC,h.hastaadsoyad as ADSOYAD,h.cinsiyet as CİNSİYET,h.yas as YAŞ,h.durum as DURUMU, f.ekipadi as FİLYASYON_GRUBU,r.ilacadi as İLAC_ADI from hasta as h left join filyasyonekip as f on h.filyasyonID=f.filyasyonID left join recete as r  on h.ilacID=r.ilacID", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();
        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("hastakayit.aspx");
        }
    }
}