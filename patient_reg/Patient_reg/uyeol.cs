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
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }
        public String tc;
        public String name;
        public String surname;
        public String gender;
        public String birthday;
        public String phone;
        public String password;
        public char update;

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 gri = new Form1();
            this.Close();
            gri.Show();
        }
        bool durum;
        void mukerrer()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from register where tcno=@tcno", baglan);
            komut.Parameters.AddWithValue("@tcno", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglan.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //if (maskedTextBox1.Text != null && maskedTextBox2.Text != null && textBox2.Text != null && textBox3.Text != null && 
            //    textBox9.Text != null && comboBox1.Text != null )
            if (update != 'X')
            {
                mukerrer();
            }
            else { durum = true; }

            if (durum == true)
            {
                if (maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                        textBox9.Text != "" && comboBox1.Text != "")
                {


                    baglan.Open();
                    if (update == 'X') {
                        SqlCommand komut1 = new SqlCommand("Update register set name='" + textBox2.Text + "',surname='" + textBox3.Text + "',gender='" + comboBox1.Text + "',birthday='" + dateTimePicker1.Text + "',phone='" + maskedTextBox2.Text + "',password='" + textBox9.Text + "' where tcno='" + tc + "'", baglan);
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("Bilgileriniz güncellendi!");
                    }
                    else
                    {
                        SqlCommand komut = new SqlCommand("Insert into register (tcno,name,surname,gender,birthday,phone,password) Values ('" + maskedTextBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + maskedTextBox2.Text.ToString() + "','" + textBox9.Text.ToString() + "')", baglan);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla kayıt oldunuz!");
                    }
                        
                    
                    baglan.Close();

                }
                else
                {
                    MessageBox.Show("Kayıt alınmadı!\nGirilen bilgileri kontrol edin!");
                }
            }
            else
            {
                MessageBox.Show("Girmiş Olduğunuz Tc Kimlik Numarası Sisteme Kayıtlı!");
            }
        }

 
        //int a;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan fark;
            //int yas;
            //DateTime dogumtarihi;

            //dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            //fark = DateTime.Now.Date.Subtract(dogumtarihi);
            //yas = Convert.ToInt32(fark.TotalDays);
            //a =  yas / 365;
        }

        private void uyeol_Load(object sender, EventArgs e)
        {
            if(tc!=null && tc!=" ")
            {
                maskedTextBox1.Text = tc;
                maskedTextBox1.ReadOnly = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From register where tcno ='" + tc + "'" , baglan);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader.GetString(2);
                    textBox3.Text = reader.GetString(3);
                    comboBox1.Text = reader.GetString(4);
                    dateTimePicker1.Text = reader.GetString(5);
                    maskedTextBox2.Text = reader.GetString(6);
                    textBox9.Text = reader.GetString(7);
                }
                reader.Close();
                baglan.Close();

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
