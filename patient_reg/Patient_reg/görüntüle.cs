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
    public partial class görüntüle : Form
    {
        public görüntüle()
        {
            InitializeComponent();

        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        public string tc;

        private void görüntüle_Load(object sender, EventArgs e)
        {
            
        }
        

        private void GncBtn_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand komut = new SqlCommand("update appo set policlinic='" + comboBox1.Text + "',doctor='" + comboBox2.Text + "',tarih='" + dateTimePicker1.Text + "' where policlinic='" + comboBox1.Text + "'", con);
            //komut.ExecuteNonQuery();

            

            verilerigöster();
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow drow1 = dataGridView1.SelectedRows[0];
            kullanıcı_veri kv = new kullanıcı_veri();
            kv.update = 'X';
            kv.TC = tc;
            kv.poli = drow1.Cells["policlinic"].Value.ToString();
            kv.doc = drow1.Cells["doctor"].Value.ToString();
            kv.tarih = drow1.Cells["tarih"].Value.ToString();
            kv.saat = drow1.Cells["time"].Value.ToString();
            kv.Show();


            


            //con.Close();

        }

      
        
        private void SilBtn_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.SelectedRows; i++)
            //{

            //    con = new SqlConnection("Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
            //    con.Open();
            //    SqlCommand komut = new SqlCommand("delete from appo where tcno='" + dataGridView1.SelectedRows.Cells["tcno"].Value.ToString() + "'", con);
            //    komut.ExecuteNonQuery();
            //    con.Close();
            //    verilerigöster();
            //}
               con = new SqlConnection("Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
                con.Open();
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                
                SqlCommand komut = new SqlCommand("delete from appo where tcno='" + drow.Cells["tcno"].Value.ToString() + "'AND policlinic='"+ drow.Cells["policlinic"].Value.ToString() + "' AND doctor='"+ drow.Cells["doctor"].Value.ToString() + "' AND tarih ='"+ drow.Cells["tarih"].Value.ToString() + "' AND time ='"+ drow.Cells["time"].Value.ToString() + "' ", con);
                komut.ExecuteNonQuery();

            }
            MessageBox.Show("Kayıt Silindi");
            verilerigöster();

        }
        public void verilerigöster()
        {
            con = new SqlConnection("Data Source=DESKTOP-4EIAID8;Initial Catalog=hasta_kayıtt;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select tcno,policlinic,doctor,tarih,time from appo where tcno ='" + tc + "'", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, " ");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            //kullanıcı_veri kv = new kullanıcı_veri();
            //kv.update = 'X';
            //kv.TC = tc;
            //kv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-4EIAID8\\MYSQLSERVER;Initial Catalog=hasta_kayıt;Integrated Security=True");
            //con.Open();
            //da = new SqlDataAdapter("Select * from appo where tcno ='" + tc + "'", con);
            //cmdb = new SqlCommandBuilder(da);
            //ds = new DataSet();
            //da.Fill(ds, " ");
            //dataGridView1.DataSource = ds.Tables[0];
            //con.Close();
            verilerigöster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            ////string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            //string tcno = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            //string policlinic = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            //string doctor = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            //string tarih = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            //string time = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();

            //kullanıcı_veri kv = new kullanıcı_veri();
            //groupBox1.Visible = true;
            //kv.comboBox1.Text = policlinic;
            //comboBox2.Text = doctor;
            //dateTimePicker1.Text = tarih;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
