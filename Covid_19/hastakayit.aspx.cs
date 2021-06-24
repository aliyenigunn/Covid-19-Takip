using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace Covid_19
{
    
    public partial class hastakayit : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
            
        }

        protected void btnhastaekle(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into hasta (tcno,hastaadsoyad,cinsiyet,yas,durum) values (@tcno,@hastaadsoyad,@cinsiyet,@yas,@durum)", conn);
            cmd.Parameters.AddWithValue("@tcno", txttc.Text);
            cmd.Parameters.AddWithValue("@hastaadsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.SelectedValue);
            cmd.Parameters.AddWithValue("@yas", txtyas.Text);
            cmd.Parameters.AddWithValue("@durum", cbdurum.SelectedValue);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hasta Ekleme İşlemi Başarılı");
         }

        protected void btnmetintemizle(object sender, EventArgs e)
        {
            txtadsoyad.Text = "";
            txttc.Text = "";
            txtyas.Text = "";
            cbcinsiyet.SelectedValue = null;
            cbdurum.SelectedValue = null;
        }

        protected void btnhastagor(object sender, EventArgs e)
        {
            Response.Redirect("hastagoruntule.aspx");
           
        }
    }
}