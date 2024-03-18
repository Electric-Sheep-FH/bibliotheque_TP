using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_TP
{
    public class Database
    {

        public static List<Book> Books { get; set; }
        public static void Initialize()
        {
            Books = new List<Book>();
        }

        public static void DisplayBooks(Genre genre)
        {
            Console.WriteLine($"Voici la liste des livres dans le genre {genre} : ");
            foreach (Book book in Books)
            {
                if(book.Genre == genre)
                {
                    IsBookAvailable(book);
                }
            }
            Console.WriteLine();
        }
        public static void DisplayBooks(string author)
        {
            Console.WriteLine($"Voici la liste des livres dont l'auteur contient \"{author}\" : ");
            foreach (Book book in Books)
            {
                if (book.Author.ToLower().Contains($"{author.ToLower()}"))
                {
                    IsBookAvailable(book) ;
                }
            }
            Console.WriteLine();
        }
        public static void DisplayBooksTitle(string title)
        {
            Console.WriteLine($"Voici la liste des livres contenant le mot \"{title}\" : ");
            foreach (Book book in Books)
            {
                title = title.ToLower();
                string bookTitleLower = book.Title.ToLower();
                if (bookTitleLower.Contains($"{title}"))
                {
                    IsBookAvailable(book) ;
                }
            }
            Console.WriteLine();
        }

        public static void IsBookAvailable(Book book)
        {
            if (book.Available)
            {
                Console.WriteLine($"- {book.Title}, par {book.Author} est disponible.");
            }
            else
            {
                Console.WriteLine($"- {book.Title}, par {book.Author} n'est pas disponible.");
            }
        }
        public static void WhatBooksAvailable()
        {
            List<Book> availableBooks = new List<Book>(); 
            foreach (Book book in Books)
            {
                if (book.Available)
                {
                    availableBooks.Add(book);
                }
            }
            Console.WriteLine($"Il y actuellement {availableBooks.Count()} livres disponibles. Voici la liste : ");
            foreach (Book book in availableBooks)
            {
                Console.WriteLine($"- {book.Title}.");
            }
            Console.WriteLine();
        }
    }
}
