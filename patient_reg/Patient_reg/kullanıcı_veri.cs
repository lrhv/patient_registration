using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hasta_Kayıt
{
    public partial class kullanıcı_veri : Form
    {
        
        private bool button1Clicked = false;
        public kullanıcı_veri()
        {
            InitializeComponent();
        }
        public string TC;
        public string poli;
        public string doc;
        public string tarih;
        public string saat;
        public char update; 

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
        

        private void kullanıcı_veri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT saat FROM saatler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr.GetString(0).Trim());
            }

            //if (dateTimePicker1.Text != null)
            //{
            //    dr.Close();
            //    string deneme = "Select time From appo  where tarih = '" + dateTimePicker1.Text.ToString() + "'";
            //    komut = new SqlCommand(deneme, baglanti);

            //    SqlDataReader reader = komut.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string arananDeger = reader.GetString(0).Trim();
            //        int indexNo = comboBox3.FindStringExact(arananDeger);
            //        if (indexNo != -1)
            //        {
            //            comboBox3.Items.RemoveAt(indexNo);
            //        }
            //    }
            //    reader.Close();
            //}
            baglanti.Close();
            if (update == 'X')
            {
                comboBox1.Text = poli;
                comboBox2.Text = doc;
                comboBox3.Text = saat;
                dateTimePicker1.Text = tarih;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (update == 'X')
            {

                this.Close();
                
            }
            else
            {
                sil_güncelle_görüntüle frm2 = new sil_güncelle_görüntüle();
                frm2.tc = TC;
                this.Close();
                frm2.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                //comboBox2.Items.Clear();
                //comboBox32.Text = "Doktor Seçiniz";
               
                baglanti.Open();
                string sql = "Select * From pol_and_doc where policlinic = '" + comboBox1.SelectedItem.ToString()+ "'";
                // SqlParameter prm1 = new SqlParameter("@blm", comboBox1.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                //komut.Parameters.Add(prm1);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                comboBox2.ValueMember = "id";
                comboBox2.DisplayMember = "doctor";
                comboBox2.DataSource = dt;
                baglanti.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)//randevu alma butonu, girilenleri kaydetmek için
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                if (update == 'X')
                {
                    SqlCommand komutt = new SqlCommand("delete from appo where tcno='" + TC + "'AND policlinic='" + poli + "' AND doctor='" + doc + "' AND tarih ='" + tarih + "' AND time ='" + saat + "' ", baglanti);
                    komutt.ExecuteNonQuery();
                }
 
                    string kayit = "insert into appo(tcno,policlinic,doctor,tarih,time) values (@tcn,@policlinic,@doctor,@date,@time)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@tcn", TC);
                komut.Parameters.AddWithValue("@policlinic", comboBox1.Text.ToString());
                komut.Parameters.AddWithValue("@doctor", comboBox2.Text.ToString());
                komut.Parameters.AddWithValue("@date", dateTimePicker1.Text.ToString());
                komut.Parameters.AddWithValue("@time", comboBox3.Text.ToString());
                komut.ExecuteNonQuery();
                
                baglanti.Close();
                if (update == 'X')
                {
                    MessageBox.Show("Randevunuz Güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Randevunuz Alınmıştır.");
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.ToString());
            }

            alınanrand arnd = new alınanrand();
            arnd.Show();
            arnd.label7.Text = comboBox1.Text.ToString();
            arnd.label5.Text = comboBox2.Text.ToString();
            arnd.label8.Text = dateTimePicker1.Text.ToString();
            arnd.label6.Text = comboBox3.Text.ToString();

            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";


        }
        string time = "";
      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //string st;
            if (dateTimePicker1.Text != null && comboBox1.Text != null && comboBox2.Text != null)
            {
                baglanti.Open();
                string deneme = "Select time From appo  where tarih = '" + dateTimePicker1.Text.ToString() + "'AND doctor='" + comboBox2.Text.ToString() + "'AND policlinic='" + comboBox1.Text.ToString() + "'";
                SqlCommand komut = new SqlCommand(deneme, baglanti);

                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    string arananDeger = reader.GetString(0).Trim();
                    int indexNo = comboBox3.FindStringExact(arananDeger);
                    if (indexNo != -1)
                    {
                        comboBox3.Items.RemoveAt(indexNo);
                    }
                }
                baglanti.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                baglanti.Open();
                string deneme = "Select time From appo  where tarih = '" + dateTimePicker1.Text.ToString() + "'AND doctor='"+comboBox2.Text.ToString()+"'AND policlinic='"+comboBox1.Text.ToString()+"'";
                SqlCommand komut = new SqlCommand(deneme, baglanti);

                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    string arananDeger = reader.GetString(0).Trim();
                    int indexNo = comboBox3.FindStringExact(arananDeger);
                    if (indexNo != -1)
                    {
                        comboBox3.Items.RemoveAt(indexNo);
                    }
                }
                baglanti.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
