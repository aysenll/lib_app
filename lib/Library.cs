using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Library
    {







        //Book classının nesnelerini kitaplar listesinde toplayalım.
        public List<Book> kitaplar { get; set; }
        // Magazine classının nesnelerini dergiler listesinde toplayalım
        public List<Magazine> dergiler { get; private set; }


        // Library classının yapıcı metodunu (constructor) oluşturuyoruz
        public Library()
        {
            // Book ve Magazine nesnelerini saklamak için List<Book> ve List<Magazine> listeleri oluşturduk
            kitaplar = new List<Book>();
            dergiler = new List<Magazine>();
        }







        //Her Library nesnesi başlatmada kitaplar adlı boş liste oluşur ve ekleme yapılır.
        public void KitapEkleme(Book book)
        {
            kitaplar.Add(book);
        }

        public bool KitapCikarma(string isbn)
        {
            //kitaplar nesnesi içinde belirli bir ISBN numaralı kitabı arıyoruz.
            Book kitapkaldir = kitaplar.Find(k => k.ISBN == isbn);
            //k her kitaplar nesnesini temsil eder.


            //Aranan kitap kitaplar listesinde bulunmuşsa kitap listeden kaldırılır.
            if (kitapkaldir != null)
            {
                kitaplar.Remove(kitapkaldir);
                return true;
            }
            return false;
        }

        public Book KitapBul(string isbn)
        {
            //kitaplar listesindeki kitaplar arasında ISBN parametresi isbn değerimize eşit değer aranır.
            Book book = kitaplar.Find(k => k.ISBN == isbn);

            return book;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Kütüphanedeki tüm kitaplar:");
            foreach (var book in kitaplar)
            {
                Console.WriteLine($"{book.Baslik} ve {book.Yazar}");
            }

        }














        
        

       
        //Her Library nesnesi başlatmada dergiler adlı boş liste oluşur ve ekleme yapılır.
        public void DergiEkleme(Magazine magazine)
        {
            dergiler.Add(magazine);
        }

        public bool DergiCikarma(string baslik)
        {
            //dergiler nesnesi içinde belirli baslikli numaralı DERGİYİ arıyoruz.
            Magazine dergikaldir = dergiler.Find(k => k.Baslik == baslik);
            //k her DERGİLER nesnesini temsil eder.


            //Aranan dergi listesinde bulunmuşsa dergi listeden kaldırılır.
            if (dergikaldir != null)
            {
                dergiler.Remove(dergikaldir);
                return true;
            }
            return false;
        }

        public Magazine DergiBul(string baslik)
        {
            //kitaplar listesindeki kitaplar arasında ISBN parametresi isbn değerimize eşit değer aranır.
            Magazine magazine = dergiler.Find(k => k.Baslik == baslik);

            return magazine;
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("Kütüphanedeki tüm dergiler:");
            foreach (var magazine in dergiler)
            {
                Console.WriteLine($"{magazine.Baslik} ve {magazine.Yayinci}");
            }

        }


    }
}

