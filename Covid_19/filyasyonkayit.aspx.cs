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


namespace Covid_19
{
    public partial class filyasyonkayit : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhastaekle(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into filyasyonbilgi (ekipadi,tcno,filadsoyad,cinsiyet,yas,meslek) values (@ekipadi,@tcno,@filadsoyad,@cinsiyet,@yas,@meslek)", conn);
            cmd.Parameters.AddWithValue("@ekipadi", txtgrupad.Text);
            cmd.Parameters.AddWithValue("@tcno", txttc.Text);
            cmd.Parameters.AddWithValue("@filadsoyad", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cbcinsiyet.SelectedValue);
            cmd.Parameters.AddWithValue("@yas", txtyas.Text);
            cmd.Parameters.AddWithValue("@meslek", cbmeslek.SelectedValue);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            cmd.CommandText = "if not exists (Select * from filyasyonekip where ekipadi='"+txtgrupad.Text+"' )begin insert into filyasyonekip (ekipadi) values ('"+txtgrupad.Text+"') end ";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hasta Ekleme İşlemi Başarılı");
        }

        protected void btngrupgor(object sender, EventArgs e)
        {
            Response.Redirect("grupgoruntule.aspx");
        }

        protected void btnmetintemizle(object sender, EventArgs e)
        {
            txtgrupad.Text = "";
            txtadsoyad.Text = "";
            txttc.Text = "";
            txtyas.Text = "";
            cbcinsiyet.SelectedValue = null;
            cbmeslek.SelectedValue = null;
        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}