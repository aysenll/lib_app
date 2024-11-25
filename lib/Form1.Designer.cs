namespace lib
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sifre_yenile = new System.Windows.Forms.Button();
            this.button_yonetici_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_yonetici_sifre = new System.Windows.Forms.TextBox();
            this.textBox_yonetici_ad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_yeni_dergi_ekle = new System.Windows.Forms.Button();
            this.button_yeni_kitap_ekle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_kitap_kaydet = new System.Windows.Forms.Button();
            this.textBox_kitap_yayinyili = new System.Windows.Forms.TextBox();
            this.textBox_kitap_isbn = new System.Windows.Forms.TextBox();
            this.textBox_yazar_adi = new System.Windows.Forms.TextBox();
            this.textBox_kitap_adi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_dergi_kaydet = new System.Windows.Forms.Button();
            this.textBox_yayinyili = new System.Windows.Forms.TextBox();
            this.textBox_sayi = new System.Windows.Forms.TextBox();
            this.textBox_yayinci = new System.Windows.Forms.TextBox();
            this.textBox_dergi_adi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ara = new System.Windows.Forms.Button();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_tum_kutup = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button_sfr_dgtr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_yeni_sifre = new System.Windows.Forms.TextBox();
            this.textBox_mvct_sifre = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(22, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button_sifre_yenile);
            this.groupBox1.Controls.Add(this.button_yonetici_giris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_yonetici_sifre);
            this.groupBox1.Controls.Add(this.textBox_yonetici_ad);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ";
            // 
            // button_sifre_yenile
            // 
            this.button_sifre_yenile.Location = new System.Drawing.Point(476, 267);
            this.button_sifre_yenile.Name = "button_sifre_yenile";
            this.button_sifre_yenile.Size = new System.Drawing.Size(210, 45);
            this.button_sifre_yenile.TabIndex = 5;
            this.button_sifre_yenile.Text = "şifre yenileme";
            this.button_sifre_yenile.UseVisualStyleBackColor = true;
            this.button_sifre_yenile.Click += new System.EventHandler(this.button_sifre_yenile_Click);
            // 
            // button_yonetici_giris
            // 
            this.button_yonetici_giris.Location = new System.Drawing.Point(178, 267);
            this.button_yonetici_giris.Name = "button_yonetici_giris";
            this.button_yonetici_giris.Size = new System.Drawing.Size(100, 45);
            this.button_yonetici_giris.TabIndex = 4;
            this.button_yonetici_giris.Text = "giriş yap";
            this.button_yonetici_giris.UseVisualStyleBackColor = true;
            this.button_yonetici_giris.Click += new System.EventHandler(this.button_yonetici_giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "kullanıcı adı :";
            // 
            // textBox_yonetici_sifre
            // 
            this.textBox_yonetici_sifre.Location = new System.Drawing.Point(178, 158);
            this.textBox_yonetici_sifre.Name = "textBox_yonetici_sifre";
            this.textBox_yonetici_sifre.Size = new System.Drawing.Size(100, 31);
            this.textBox_yonetici_sifre.TabIndex = 1;
            // 
            // textBox_yonetici_ad
            // 
            this.textBox_yonetici_ad.Location = new System.Drawing.Point(178, 94);
            this.textBox_yonetici_ad.Name = "textBox_yonetici_ad";
            this.textBox_yonetici_ad.Size = new System.Drawing.Size(100, 31);
            this.textBox_yonetici_ad.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.button_yeni_dergi_ekle);
            this.tabPage2.Controls.Add(this.button_yeni_kitap_ekle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button_yeni_dergi_ekle
            // 
            this.button_yeni_dergi_ekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yeni_dergi_ekle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_yeni_dergi_ekle.Location = new System.Drawing.Point(239, 179);
            this.button_yeni_dergi_ekle.Name = "button_yeni_dergi_ekle";
            this.button_yeni_dergi_ekle.Size = new System.Drawing.Size(277, 42);
            this.button_yeni_dergi_ekle.TabIndex = 1;
            this.button_yeni_dergi_ekle.Text = "YENİ DERGİ EKLEME";
            this.button_yeni_dergi_ekle.UseVisualStyleBackColor = true;
            this.button_yeni_dergi_ekle.Click += new System.EventHandler(this.button_yeni_dergi_ekle_Click);
            // 
            // button_yeni_kitap_ekle
            // 
            this.button_yeni_kitap_ekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yeni_kitap_ekle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_yeni_kitap_ekle.Location = new System.Drawing.Point(239, 118);
            this.button_yeni_kitap_ekle.Name = "button_yeni_kitap_ekle";
            this.button_yeni_kitap_ekle.Size = new System.Drawing.Size(277, 42);
            this.button_yeni_kitap_ekle.TabIndex = 0;
            this.button_yeni_kitap_ekle.Text = "YENİ KİTAP EKLEME";
            this.button_yeni_kitap_ekle.UseVisualStyleBackColor = true;
            this.button_yeni_kitap_ekle.Click += new System.EventHandler(this.button_yeni_kitap_ekle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.button_kitap_kaydet);
            this.tabPage3.Controls.Add(this.textBox_kitap_yayinyili);
            this.tabPage3.Controls.Add(this.textBox_kitap_isbn);
            this.tabPage3.Controls.Add(this.textBox_yazar_adi);
            this.tabPage3.Controls.Add(this.textBox_kitap_adi);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(742, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(441, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 173);
            this.listBox1.TabIndex = 10;
            // 
            // button_kitap_kaydet
            // 
            this.button_kitap_kaydet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kitap_kaydet.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_kitap_kaydet.Location = new System.Drawing.Point(441, 310);
            this.button_kitap_kaydet.Name = "button_kitap_kaydet";
            this.button_kitap_kaydet.Size = new System.Drawing.Size(219, 35);
            this.button_kitap_kaydet.TabIndex = 9;
            this.button_kitap_kaydet.Text = "Kaydet";
            this.button_kitap_kaydet.UseVisualStyleBackColor = true;
            this.button_kitap_kaydet.Click += new System.EventHandler(this.button_kitap_kaydet_Click);
            // 
            // textBox_kitap_yayinyili
            // 
            this.textBox_kitap_yayinyili.Location = new System.Drawing.Point(178, 267);
            this.textBox_kitap_yayinyili.Name = "textBox_kitap_yayinyili";
            this.textBox_kitap_yayinyili.Size = new System.Drawing.Size(100, 20);
            this.textBox_kitap_yayinyili.TabIndex = 8;
            // 
            // textBox_kitap_isbn
            // 
            this.textBox_kitap_isbn.Location = new System.Drawing.Point(178, 216);
            this.textBox_kitap_isbn.Name = "textBox_kitap_isbn";
            this.textBox_kitap_isbn.Size = new System.Drawing.Size(100, 20);
            this.textBox_kitap_isbn.TabIndex = 7;
            // 
            // textBox_yazar_adi
            // 
            this.textBox_yazar_adi.Location = new System.Drawing.Point(178, 164);
            this.textBox_yazar_adi.Name = "textBox_yazar_adi";
            this.textBox_yazar_adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_yazar_adi.TabIndex = 6;
            // 
            // textBox_kitap_adi
            // 
            this.textBox_kitap_adi.Location = new System.Drawing.Point(178, 110);
            this.textBox_kitap_adi.Name = "textBox_kitap_adi";
            this.textBox_kitap_adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_kitap_adi.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(68, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Yayın Yılı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "ISBN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yazar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kitap Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yeni Kitap Ekleme Ekranı";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.listBox2);
            this.tabPage4.Controls.Add(this.button_dergi_kaydet);
            this.tabPage4.Controls.Add(this.textBox_yayinyili);
            this.tabPage4.Controls.Add(this.textBox_sayi);
            this.tabPage4.Controls.Add(this.textBox_yayinci);
            this.tabPage4.Controls.Add(this.textBox_dergi_adi);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(742, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(430, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(229, 173);
            this.listBox2.TabIndex = 10;
            // 
            // button_dergi_kaydet
            // 
            this.button_dergi_kaydet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dergi_kaydet.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_dergi_kaydet.Location = new System.Drawing.Point(430, 293);
            this.button_dergi_kaydet.Name = "button_dergi_kaydet";
            this.button_dergi_kaydet.Size = new System.Drawing.Size(229, 38);
            this.button_dergi_kaydet.TabIndex = 9;
            this.button_dergi_kaydet.Text = "Kaydet";
            this.button_dergi_kaydet.UseVisualStyleBackColor = true;
            this.button_dergi_kaydet.Click += new System.EventHandler(this.button_dergi_kaydet_Click);
            // 
            // textBox_yayinyili
            // 
            this.textBox_yayinyili.Location = new System.Drawing.Point(150, 262);
            this.textBox_yayinyili.Name = "textBox_yayinyili";
            this.textBox_yayinyili.Size = new System.Drawing.Size(100, 20);
            this.textBox_yayinyili.TabIndex = 8;
            // 
            // textBox_sayi
            // 
            this.textBox_sayi.Location = new System.Drawing.Point(150, 206);
            this.textBox_sayi.Name = "textBox_sayi";
            this.textBox_sayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_sayi.TabIndex = 7;
            // 
            // textBox_yayinci
            // 
            this.textBox_yayinci.Location = new System.Drawing.Point(150, 156);
            this.textBox_yayinci.Name = "textBox_yayinci";
            this.textBox_yayinci.Size = new System.Drawing.Size(100, 20);
            this.textBox_yayinci.TabIndex = 6;
            // 
            // textBox_dergi_adi
            // 
            this.textBox_dergi_adi.Location = new System.Drawing.Point(150, 111);
            this.textBox_dergi_adi.Name = "textBox_dergi_adi";
            this.textBox_dergi_adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_dergi_adi.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(68, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Yayın Yılı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(68, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Sayı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(68, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Yayıncı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(68, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dergi Adı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(67, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yeni Dergi Ekleme Ekranı ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Controls.Add(this.button_ara);
            this.tabPage5.Controls.Add(this.textBox_arama);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.button_tum_kutup);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(742, 380);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(43, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(308, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Kitapları ve dergileri başlık bilgisine göre arayın";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_ara
            // 
            this.button_ara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ara.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_ara.Location = new System.Drawing.Point(627, 141);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 23);
            this.button_ara.TabIndex = 3;
            this.button_ara.Text = "Ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(45, 144);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(568, 20);
            this.textBox_arama.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 1;
            // 
            // button_tum_kutup
            // 
            this.button_tum_kutup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tum_kutup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_tum_kutup.Location = new System.Drawing.Point(46, 30);
            this.button_tum_kutup.Name = "button_tum_kutup";
            this.button_tum_kutup.Size = new System.Drawing.Size(657, 50);
            this.button_tum_kutup.TabIndex = 0;
            this.button_tum_kutup.Text = "KÜTÜPHANEDEKİ TÜM KİTAP VE DERGİLER";
            this.button_tum_kutup.UseVisualStyleBackColor = true;
            this.button_tum_kutup.Click += new System.EventHandler(this.button_tum_kutup_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage6.Controls.Add(this.button_sfr_dgtr);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.textBox_yeni_sifre);
            this.tabPage6.Controls.Add(this.textBox_mvct_sifre);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(742, 380);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            // 
            // button_sfr_dgtr
            // 
            this.button_sfr_dgtr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sfr_dgtr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_sfr_dgtr.Location = new System.Drawing.Point(228, 186);
            this.button_sfr_dgtr.Name = "button_sfr_dgtr";
            this.button_sfr_dgtr.Size = new System.Drawing.Size(220, 53);
            this.button_sfr_dgtr.TabIndex = 4;
            this.button_sfr_dgtr.Text = "şifre güncelle";
            this.button_sfr_dgtr.UseVisualStyleBackColor = true;
            this.button_sfr_dgtr.Click += new System.EventHandler(this.button_sfr_dgtr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(225, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "yeni şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(225, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "mevcut şifre :";
            // 
            // textBox_yeni_sifre
            // 
            this.textBox_yeni_sifre.Location = new System.Drawing.Point(348, 129);
            this.textBox_yeni_sifre.Name = "textBox_yeni_sifre";
            this.textBox_yeni_sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_yeni_sifre.TabIndex = 1;
            // 
            // textBox_mvct_sifre
            // 
            this.textBox_mvct_sifre.Location = new System.Drawing.Point(348, 69);
            this.textBox_mvct_sifre.Name = "textBox_mvct_sifre";
            this.textBox_mvct_sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_mvct_sifre.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_yonetici_sifre;
        private System.Windows.Forms.TextBox textBox_yonetici_ad;
        private System.Windows.Forms.Button button_yonetici_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_yeni_dergi_ekle;
        private System.Windows.Forms.Button button_yeni_kitap_ekle;
        private System.Windows.Forms.Button button_kitap_kaydet;
        private System.Windows.Forms.TextBox textBox_kitap_yayinyili;
        private System.Windows.Forms.TextBox textBox_kitap_isbn;
        private System.Windows.Forms.TextBox textBox_yazar_adi;
        private System.Windows.Forms.TextBox textBox_kitap_adi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_dergi_kaydet;
        private System.Windows.Forms.TextBox textBox_yayinyili;
        private System.Windows.Forms.TextBox textBox_sayi;
        private System.Windows.Forms.TextBox textBox_yayinci;
        private System.Windows.Forms.TextBox textBox_dergi_adi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_tum_kutup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_sifre_yenile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_yeni_sifre;
        private System.Windows.Forms.TextBox textBox_mvct_sifre;
        private System.Windows.Forms.Button button_sfr_dgtr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

