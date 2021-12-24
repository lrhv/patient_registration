using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hasta_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi1, sayi2, sayi3;
            int harfdegeri, harfdegeri2;
            sayi1 = rastgele.Next(1, 9);
            sayi2 = rastgele.Next(0, 9);
            sayi3 = rastgele.Next(0, 9);
            harfdegeri = rastgele.Next(65, 91);
            harfdegeri2 = rastgele.Next(65, 91);
            char karakter;
            char karakter2;
            karakter = Convert.ToChar(harfdegeri);
            karakter2 = Convert.ToChar(harfdegeri2);
            KOD.Text = sayi1.ToString() + karakter2 + sayi2.ToString() + karakter + sayi3.ToString();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        //string deneme;
        private void OLD_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //deneme = "select * FROM register Where tcno=@tcno AND password=@pwd";
            //SqlParameter prm1 = new SqlParameter("@tcno", TCBOX.Text);
            //SqlParameter prm2 = new SqlParameter("@pwd", PASSWORD.Text);
            //cmd.Parameters.Add(prm1);
            //cmd.Parameters.Add(prm2);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //baglanti.Close();
            //baglanti.Open();
            /*SqlCommand cmd = new SqlCommand(" select count(*) from members where tcno='" + TCBOX.Text + "'password='" + PASSWORD + "'", baglanti);
            int sonuc = (int)cmd.ExecuteScalar();*/
            string sorgu = "SELECT *FROM register where tcno=@tcno AND password=@pwd";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@tcno", TCBOX.Text);
            cmd.Parameters.AddWithValue("@pwd", PASSWORD.Text);
            
            
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() && KOD.Text == KODTEXT.Text) 
            {

                //deneme = "Select * From register where tcno=@tcno AND password=@password ";
                //SqlParameter prm1 = new SqlParameter("tcno", TCBOX.Text.Trim());
                //SqlParameter prm2 = new SqlParameter("password", PASSWORD.Text.Trim());
                //SqlCommand komut = new SqlCommand(deneme, baglanti);
                
                sil_güncelle_görüntüle sgg = new sil_güncelle_görüntüle();
                this.Hide();   
                sgg.tc = TCBOX.Text;
                sgg.Show();

                //kullanıcı_veri kv = new kullanıcı_veri();
                //kv.Show();

            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Geçersiz veya Eksik!\nLütfen Kontrol Edin");
                Form1_Load(sender, e);
                TCBOX.Clear();
                PASSWORD.Clear();
                KODTEXT.Clear();
            }

            baglanti.Close();
            /*if (sonuc == 0) 
            {

                MessageBox.Show("Girilen Bilgiler Kayıtlı veya Geçerli Değil!\nLütfen Kontrol Edin");

            }*/
            /* if (KOD.Text == KODTEXT.Text )    
             {
                 baglanti.Open();
                 string sql = "Select * From members where tcno=@tcno AND password=@password ";
                 SqlParameter prm1 = new SqlParameter("tcno", TCBOX.Text.Trim());
                 SqlParameter prm2 = new SqlParameter("password", PASSWORD.Text.Trim());
                 SqlCommand komut = new SqlCommand(sql, baglanti);
                 kullanıcı_veri kv = new kullanıcı_veri();
                 kv.Show(); 
                 baglanti.Close();
             }
             else 
             {
                 MessageBox.Show("Lütfen doğru kodu giriniz!", "Bilgilendirme Penceresi");
                 KODTEXT.Clear();
                 Form1_Load( sender,e );
             }*/


        }

        private void ADBOX_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            uyeol uye = new uyeol();
            this.Hide();
            uye.Show();

        }

        private void TCBOX_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
