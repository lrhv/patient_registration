
namespace Hasta_Kayıt
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.TCBOX = new System.Windows.Forms.MaskedTextBox();
            this.KODTEXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KOD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NEW = new System.Windows.Forms.Button();
            this.OLD = new System.Windows.Forms.Button();
            this.picBoxTCKimlikNo = new System.Windows.Forms.PictureBox();
            this.picBoxGüvenlikKoduSimgesi = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTCKimlikNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGüvenlikKoduSimgesi)).BeginInit();
            this.SuspendLayout();
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PASSWORD.Location = new System.Drawing.Point(213, 94);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(156, 28);
            this.PASSWORD.TabIndex = 0;
            this.PASSWORD.UseSystemPasswordChar = true;
            this.PASSWORD.TextChanged += new System.EventHandler(this.ADBOX_TextChanged);
            // 
            // TCBOX
            // 
            this.TCBOX.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCBOX.Location = new System.Drawing.Point(213, 53);
            this.TCBOX.Mask = "00000000000";
            this.TCBOX.Name = "TCBOX";
            this.TCBOX.Size = new System.Drawing.Size(156, 28);
            this.TCBOX.TabIndex = 1;
            this.TCBOX.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TCBOX_MaskInputRejected);
            // 
            // KODTEXT
            // 
            this.KODTEXT.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KODTEXT.Location = new System.Drawing.Point(193, 203);
            this.KODTEXT.Name = "KODTEXT";
            this.KODTEXT.Size = new System.Drawing.Size(147, 28);
            this.KODTEXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // KOD
            // 
            this.KOD.AutoSize = true;
            this.KOD.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KOD.Location = new System.Drawing.Point(219, 146);
            this.KOD.Name = "KOD";
            this.KOD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KOD.Size = new System.Drawing.Size(0, 33);
            this.KOD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(190, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yukardaki kodu giriniz";
            // 
            // NEW
            // 
            this.NEW.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NEW.Location = new System.Drawing.Point(94, 281);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(107, 42);
            this.NEW.TabIndex = 7;
            this.NEW.Text = "Yeni Üye";
            this.NEW.UseVisualStyleBackColor = true;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // OLD
            // 
            this.OLD.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OLD.Location = new System.Drawing.Point(303, 281);
            this.OLD.Name = "OLD";
            this.OLD.Size = new System.Drawing.Size(107, 42);
            this.OLD.TabIndex = 8;
            this.OLD.Text = "Giriş";
            this.OLD.UseVisualStyleBackColor = true;
            this.OLD.Click += new System.EventHandler(this.OLD_Click);
            // 
            // picBoxTCKimlikNo
            // 
            this.picBoxTCKimlikNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxTCKimlikNo.BackgroundImage")));
            this.picBoxTCKimlikNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxTCKimlikNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxTCKimlikNo.Location = new System.Drawing.Point(168, 53);
            this.picBoxTCKimlikNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxTCKimlikNo.Name = "picBoxTCKimlikNo";
            this.picBoxTCKimlikNo.Size = new System.Drawing.Size(40, 29);
            this.picBoxTCKimlikNo.TabIndex = 25;
            this.picBoxTCKimlikNo.TabStop = false;
            // 
            // picBoxGüvenlikKoduSimgesi
            // 
            this.picBoxGüvenlikKoduSimgesi.BackColor = System.Drawing.Color.Red;
            this.picBoxGüvenlikKoduSimgesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxGüvenlikKoduSimgesi.BackgroundImage")));
            this.picBoxGüvenlikKoduSimgesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxGüvenlikKoduSimgesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxGüvenlikKoduSimgesi.Location = new System.Drawing.Point(168, 94);
            this.picBoxGüvenlikKoduSimgesi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxGüvenlikKoduSimgesi.Name = "picBoxGüvenlikKoduSimgesi";
            this.picBoxGüvenlikKoduSimgesi.Size = new System.Drawing.Size(40, 28);
            this.picBoxGüvenlikKoduSimgesi.TabIndex = 33;
            this.picBoxGüvenlikKoduSimgesi.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(344, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 47);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBoxGüvenlikKoduSimgesi);
            this.Controls.Add(this.picBoxTCKimlikNo);
            this.Controls.Add(this.OLD);
            this.Controls.Add(this.NEW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KODTEXT);
            this.Controls.Add(this.TCBOX);
            this.Controls.Add(this.PASSWORD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTCKimlikNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGüvenlikKoduSimgesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PASSWORD;
        public System.Windows.Forms.MaskedTextBox TCBOX;
        public System.Windows.Forms.TextBox KODTEXT;
        public System.Windows.Forms.Label KOD;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button NEW;
        public System.Windows.Forms.Button OLD;
        public System.Windows.Forms.PictureBox picBoxTCKimlikNo;
        public System.Windows.Forms.PictureBox picBoxGüvenlikKoduSimgesi;
        public System.Windows.Forms.Button button1;
    }
}

