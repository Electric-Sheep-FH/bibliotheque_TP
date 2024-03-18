using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_TP
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberPages { get; set; }
        public bool Available { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, string author, int numberPages, Genre genre)
        {
            Title = title;
            Author = author;
            NumberPages = numberPages;
            Genre = genre;
            Available = true;

            Database.Books.Add(this);
        }
    }
}
