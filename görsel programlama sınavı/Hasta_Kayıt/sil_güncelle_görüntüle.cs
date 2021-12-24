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
    public partial class sil_güncelle_görüntüle : Form
    {
        public sil_güncelle_görüntüle()
        {
            InitializeComponent();
        }
        public string tc;
        private void button1_Click(object sender, EventArgs e)
        {
            görüntüle grnt = new görüntüle();
            
            grnt.tc = tc;
            grnt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcı_veri kv = new kullanıcı_veri();
            this.Hide();
            kv.TC = tc; 
            kv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //kullnaıcıgüncelle kgcn = new kullnaıcıgüncelle();
            uyeol uye = new uyeol();
            
            uye.tc = tc;
            uye.update = 'X';
            uye.Show();
            //kgcn.Show();
        }

        private void sil_güncelle_görüntüle_Load(object sender, EventArgs e)
        {

        }
    }
}
