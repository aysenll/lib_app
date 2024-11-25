using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;

        public  Library library;
        public Form1()
        {
            InitializeComponent();
            library = new Library();

            // NotifyIcon nesnesini oluştur
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;  // Bildirim ikonu
            notifyIcon.Visible = true;  // Bildirimi görünür yap

            // Bildirimde gösterilecek başlık ve mesaj
            notifyIcon.BalloonTipTitle = "Uygulama Başladı!";
            notifyIcon.BalloonTipText = "Uygulamanız sağ altta aktif durumda.";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;

            // BalloonTip'i göster
            notifyIcon.ShowBalloonTip(3000);

    }
         protected override void OnFormClosing(FormClosingEventArgs e)
         {
            base.OnFormClosing(e);
            notifyIcon.Dispose();  // Form kapandığında NotifyIcon'u temizle
         }




         private void button_yonetici_giris_Click(object sender, EventArgs e)
        {
            string yoneticiAdi = textBox_yonetici_ad.Text;
            string yoneticiSifre = textBox_yonetici_sifre.Text;

            tabControl1.SelectedIndex = 1;
        }

        private void button_yeni_kitap_ekle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void button_yeni_dergi_ekle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button_kitap_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string title = textBox_kitap_adi.Text;
                string author = textBox_yazar_adi.Text;
                int year = Convert.ToInt32(textBox_kitap_yayinyili.Text);
                string isbn = textBox_kitap_isbn.Text;

                Book newBook = new Book(isbn, title, author, year);

                library.KitapEkleme(newBook);

                //listeyi güncelleme
                listBox1.Items.Clear();
                foreach (var book in library.kitaplar)
                {
                    listBox1.Items.Add($"{book.Baslik} - {book.Yazar} - {book.Yayinyili} - {book.ISBN}");
                }

                textBox_kitap_adi.Clear();
                textBox_yazar_adi.Clear();
                textBox_kitap_yayinyili.Clear();
                textBox_kitap_isbn.Clear();

                MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_dergi_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string baslik = textBox_dergi_adi.Text;
                string yayinci = textBox_yayinci.Text;

                // Sayı girişinin doğru olup olmadığını kontrol et
                int sayi;
                if (!int.TryParse(textBox_sayi.Text, out sayi))
                {
                    MessageBox.Show("Geçersiz sayı girişi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // İşlem yapılmadan çık
                }

                // Yıl girişinin doğru olup olmadığını kontrol et
                int yyili;
                if (!int.TryParse(textBox_yayinyili.Text, out yyili))
                {
                    MessageBox.Show("Geçersiz yıl girişi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // İşlem yapılmadan çık
                }

                Magazine newMagazine = new Magazine(baslik, yayinci, sayi, yyili);

                library.DergiEkleme(newMagazine);



                listBox2.Items.Clear();
                foreach (Magazine dergi in library.dergiler)
                {
                    listBox2.Items.Add($"{dergi.Baslik}-{dergi.Sayi}-{dergi.Yayinci}-{dergi.Yyili}");
                }




                textBox_dergi_adi.Clear();
                textBox_yayinci.Clear();
                textBox_sayi.Clear();
                textBox_yayinyili.Clear();



            }
            catch(Exception ex)
            {
                MessageBox.Show($"bir hata oldu:{ex.Message}", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_tum_kutup_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Baslik", "Başlık");
            dataGridView1.Columns.Add("Yazar", "Yazar");
            dataGridView1.Columns.Add("Yayinci", "Yayınevi");
            dataGridView1.Columns.Add("Yil", "Yıl");
            dataGridView1.Columns.Add("Sayi", "Sayı");

            foreach (Book kitap in library.kitaplar)
            {
                dataGridView1.Rows.Add(kitap.Baslik, kitap.Yazar, "", kitap.Yayinyili, "");
            }

            foreach (Magazine dergi in library.dergiler)
            {
                dataGridView1.Rows.Add(dergi.Baslik, "", dergi.Yayinci, dergi.Yyili, dergi.Sayi);
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            string kriter = textBox_arama.Text.Trim();

            if (string.IsNullOrEmpty(kriter))
            {
                MessageBox.Show("Arama bilgisi yok");
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Baslik", "Başlık");
            dataGridView1.Columns.Add("Yazar", "Yazar");
            dataGridView1.Columns.Add("Yayinci", "Yayınevi");
            dataGridView1.Columns.Add("Yil", "Yıl");
            dataGridView1.Columns.Add("Sayi", "Sayı");


            // Kitapları arama
            bool kitapBulundu = false;
            foreach (Book kitap in library.kitaplar)
            {
                if (kitap.Baslik.ToLower().Contains(kriter.ToLower())) // ISBN ile arama
                {
                    dataGridView1.Rows.Add(kitap.Baslik, kitap.Yazar, "", kitap.Yayinyili, "");
                    kitapBulundu = true;
                }
            }

            // Dergileri arama
            bool dergiBulundu = false;
            foreach (Magazine dergi in library.dergiler)
            {
                if (dergi.Baslik.ToLower().Contains(kriter.ToLower())) // Başlık ile arama (büyük/küçük harf duyarsız)
                {
                    dataGridView1.Rows.Add(dergi.Baslik, "", dergi.Yayinci, dergi.Yyili, dergi.Sayi);
                    dergiBulundu = true;
                }
            }

            // Arama sonucu bulunmadıysa kullanıcıyı bilgilendirelim
            if (!kitapBulundu && !dergiBulundu)
            {
                MessageBox.Show("Arama kriterinize uyan kitap veya dergi bulunamadı.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void button_sifre_yenile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button_sfr_dgtr_Click(object sender, EventArgs e)
        {
            // Mevcut şifre ve yeni şifre alanlarının boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(textBox_mvct_sifre.Text) || string.IsNullOrWhiteSpace(textBox_yeni_sifre.Text))
            {
                MessageBox.Show("Mevcut şifreyi ve yeni şifre alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Alanlar boşsa işlemi durdur
            }

            // Mevcut şifreyi ve yeni şifreyi değişkenlere alalım
            string mevcutSifre = textBox_mvct_sifre.Text;
            string yeniSifre = textBox_yeni_sifre.Text;

            // Mevcut şifrenin doğru olup olmadığını kontrol edelim (örneğin bir veritabanında ya da bir değişkende saklanan şifre ile karşılaştırma yapılabilir)
            if (mevcutSifre == "kayitliSifre") // Bu kontrolü kendi şifre kontrol sisteminize göre güncelleyin
            {
                // Şifre değiştirme işlemi
                // Örneğin, kaydedilmiş şifreyi yeni şifre ile değiştirme
                // kayitliSifre = yeniSifre;

                MessageBox.Show("Şifre başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TextBox'ları temizle
                textBox_mvct_sifre.Clear();
                textBox_yeni_sifre.Clear();
            }
            else
            {
                // Mevcut şifre doğru değilse hata mesajı göster
                MessageBox.Show("Mevcut şifre hatalı. Lütfen doğru şifreyi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AdminM admin = new AdminM();
            bool sifreDogru = admin.Login("aysen", mevcutSifre);

            if(sifreDogru)
            {
                admin.UpdatePassword("aysen", yeniSifre);
                MessageBox.Show("şifre değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Mevcut şifre yanlış. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}

