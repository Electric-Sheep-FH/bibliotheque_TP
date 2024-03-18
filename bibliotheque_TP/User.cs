using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_TP
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public User(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.Available)
            {
                book.Available = false;
                BorrowedBooks.Add(book);
            }
            else
            {
                Console.WriteLine($"Impossible d'emprunter ce livre {Firstname}, \"{book.Title}\" est déjà emprunté par quelqu'un d'autre.");
                Console.WriteLine();
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{Firstname} a emprunté le/les livre(s) suivant(s) :");
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine($"- \"{book.Title}\"");
            }
            Console.WriteLine();
        }
    }
}
