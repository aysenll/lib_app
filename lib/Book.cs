using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Book
    {
        public string ISBN { get; set; }

        public string Baslik { get; set; }

        public string Yazar { get; set; }

        public int Yayinyili { get; set; }


        public Book(string isbn, string title, string author,int year)
        {
            ISBN = isbn;
            Baslik = title;
            Yazar = author;
            Yayinyili = year;
        }
    }
}
