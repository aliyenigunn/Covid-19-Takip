
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;

namespace Covid_19
{
    public partial class filyasyonatama : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AQD6BC9\\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True");
        public static bool butontiklama=false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cbhasta.Visible = false;
            cbgrup.Visible = false;
            cbilac.Visible = false;
            btnata.Visible = false;
            btndetay.Visible = false;
            
        }
        public void doldur()
        {
            cbhasta.Visible = true;
            cbgrup.Visible = true;
            cbilac.Visible = true;
            btnata.Visible = true;
            btndetay.Visible = true;
            
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select distinct ekipadi from filyasyonbilgi", conn);
            SqlDataReader dr,dr1,dr2;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cbgrup.Items.Add(dr["ekipadi"].ToString());

            }
            dr.Close();

            cmd1.CommandText = "select ilacadi from recete";
            cmd1.Connection = conn;
            dr2 = cmd1.ExecuteReader();
            while(dr2.Read())
            {
                cbilac.Items.Add(dr2["ilacadi"].ToString());
            }
            dr2.Close();
            conn.Close();
        }
        
        public void hastagriddoldur()
        {
            doldur();
            conn.Open();
            SqlCommand cmd = new SqlCommand(" Select h.tcno as TC,h.hastaadsoyad as ADSOYAD,h.cinsiyet as CİNSİYET,h.yas as YAŞ,h.durum as DURUMU, f.ekipadi as FİLYASYON_GRUBU,r.ilacadi as İLAC_ADI from hasta as h left join filyasyonekip as f on h.filyasyonID=f.filyasyonID left join recete as r  on h.ilacID=r.ilacID ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();
        }
        public void temasligriddoldur()
        {
            doldur();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select t.tcno as TC,t.adsoyad as ADSOYAD,t.cinsiyet as CİNSİYET,t.yas as YAŞ,t.yakinlik as YAKINLIK,f.ekipadi as FİLYASYON_GRUBU,r.ilacadi as İLAC_ADI from temaslihasta as t left join filyasyonekip as f on t.filyasyonID=f.filyasyonID left join recete as r  on t.ilacID=r.ilacID", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            GridView1.DataSource = dt1;
            GridView1.DataBind();
            conn.Close();
        }

        protected void btnhastanormal(object sender, EventArgs e)
        {
            butontiklama = true;
            cbhasta.Items.Clear();
            cbgrup.Items.Clear();
            cbilac.Items.Clear();
            cbhasta.Items.Add("HASTA SEÇİNİZ");
            cbgrup.Items.Add("EKİP SEÇİNİZ");
            cbilac.Items.Add("İLAÇ SEÇİNİZ");
            
            hastagriddoldur();
            String butontext = btnnormal.Text;
            if(butontext== "NORMAL HASTA")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select tcno,hastaadsoyad from hasta", conn);
                SqlDataReader dr;
                dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    cbhasta.Items.Add(dr["tcno"].ToString()+"-"+dr["hastaadsoyad"].ToString());

                }
                dr.Close();
            }
            
        }

        protected void btnhastatemasli(object sender, EventArgs e)
        {
            cbhasta.Items.Clear();
            cbgrup.Items.Clear();
            cbilac.Items.Clear();
            cbhasta.Items.Add("HASTA SEÇİNİZ");
            cbgrup.Items.Add("EKİP SEÇİNİZ");
            cbilac.Items.Add("İLAÇ SEÇİNİZ");
            butontiklama = false;
            temasligriddoldur();
            String butontext = btntemasli.Text;
            if (butontext == "TEMASLI HASTA")
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select tcno,adsoyad from temaslihasta", conn);
                SqlDataReader dr1;
                dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    cbhasta.Items.Add(dr1["tcno"].ToString() + "-" + dr1["adsoyad"].ToString());

                }
                dr1.Close();
            }

        }
        public void combotemizle()
        {
            cbhasta.SelectedIndex = 0;
            cbgrup.SelectedIndex = 0;
            cbilac.SelectedIndex = 0;
        }

        protected void btngeri(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void atamayap(object sender, EventArgs e)
        {
            cbhasta.Visible = true;
            cbgrup.Visible = true;
            cbilac.Visible = true;
            btnata.Visible = true;
           
            if (butontiklama==true)
            {

                
                if (cbhasta.SelectedIndex == 0)
                {
                   
                    MessageBox.Show("Lütfen Hasta Seçiniz" + butontiklama.ToString());
                }
                else if (cbhasta.SelectedIndex != 0 && cbgrup.SelectedIndex != 0 && cbilac.SelectedIndex==0)
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("update hasta set filyasyonID=(select filyasyonID from filyasyonekip where ekipadi='" + cbgrup.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "' ", conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    hastagriddoldur();
                    MessageBox.Show("Hastaya Filyasyon Ekibi Başarıyla Atanmıştır");
                    combotemizle();
                }
                else if (cbhasta.SelectedIndex != 0 && cbgrup.SelectedIndex==0 && cbilac.SelectedIndex != 0)
                {
                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("update hasta set ilacID=(select ilacID from recete where ilacadi='" + cbilac.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "'", conn);
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                    hastagriddoldur();
                    MessageBox.Show("Hastaya Reçete Atanmıştır");
                    combotemizle();
                }
                else if(cbhasta.SelectedIndex != 0 && cbgrup.SelectedIndex != 0 && cbilac.SelectedIndex != 0 )
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update hasta set filyasyonID=(select filyasyonID from filyasyonekip where ekipadi='" + cbgrup.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "' ", conn);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update hasta set ilacID=(select ilacID from recete where ilacadi='" + cbilac.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    hastagriddoldur();
                    MessageBox.Show("Hastaya Filyasyon Ekibi ve Reçete Başarıyla Atanmıştır");
                    combotemizle();
                }
                else
                    MessageBox.Show("Lütfen Seçim Yapınız");
            }
            else if(butontiklama==false)
            {
                if (cbhasta.SelectedIndex == 0)
                {

                    MessageBox.Show("Lütfen Hasta Seçiniz" + butontiklama.ToString());
                }
                else if (cbhasta.SelectedIndex != 0 && cbgrup.SelectedIndex != 0 && cbilac.SelectedIndex == 0)
                {
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("update temaslihasta set filyasyonID=(select filyasyonID from filyasyonekip where ekipadi='" + cbgrup.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "' ", conn);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    temasligriddoldur();
                    MessageBox.Show("Temaslı Hastaya Filyasyon Ekibi Başarıyla Atanmıştır");
                    combotemizle();
                }
                else if (cbhasta.SelectedIndex != 0 && cbgrup.SelectedIndex == 0 && cbilac.SelectedIndex != 0)
                {
                    conn.Open();
                    SqlCommand cmd5 = new SqlCommand("update temaslihasta set ilacID=(select ilacID from recete where ilacadi='" + cbilac.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "'", conn);
                    cmd5.ExecuteNonQuery();
                    conn.Close();
                    temasligriddoldur();
                    MessageBox.Show("Temaslı Hastaya Reçete Atanmıştır");
                    combotemizle();
                }
                else if (cbhasta.SelectedIndex != 0 && cbilac.SelectedIndex != 0 && cbgrup.SelectedIndex != 0)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update temaslihasta set filyasyonID=(select filyasyonID from filyasyonekip where ekipadi='" + cbgrup.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "' ", conn);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update temaslihasta set ilacID=(select ilacID from recete where ilacadi='" + cbilac.SelectedValue.ToString() + "') where tcno='" + cbhasta.SelectedValue.Substring(0, 6) + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    temasligriddoldur();
                    MessageBox.Show("Temaslı Hastaya Filyasyon Ekibi ve Reçete Başarıyla Atanmıştır");
                    combotemizle();
                }
                else
                    MessageBox.Show("Lütfen Seçim Yapınız");
            }

        }

        protected void Detay_Click(object sender, EventArgs e)
        {
            String detay = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("detaygrup.aspx");
        }

        protected void Detaygoster(object sender, EventArgs e)
        {
            Response.Redirect("detaygrup.aspx");
        }
    }
    }
