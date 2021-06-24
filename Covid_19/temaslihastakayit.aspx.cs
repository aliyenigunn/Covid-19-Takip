using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Covid_19
{
    public partial class temaslihastakayit : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhastaekle(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into temaslihasta (tcno,adsoyad,cinsiyet,yas,yakinlik) values (@tcno,@adsoyad,@cinsiyet,@yas,@yakinlik)", conn);
            cmd.Parameters.AddWithValue("@tcno", txttc.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.SelectedValue);
            cmd.Parameters.AddWithValue("@yas", txtyas.Text);
            cmd.Parameters.AddWithValue("@yakinlik", txtyakinlik.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hasta Ekleme İşlemi Başarılı");
        }

        protected void btnhastagor(object sender, EventArgs e)
        {
            Response.Redirect("temaslihastagoruntule.aspx");
        }

        protected void btnmetintemizle(object sender, EventArgs e)
        {
            txtadsoyad.Text = "";
            txttc.Text = "";
            txtyas.Text = "";
            cbcinsiyet.SelectedValue = null;
            txtyakinlik.Text = "";
        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}