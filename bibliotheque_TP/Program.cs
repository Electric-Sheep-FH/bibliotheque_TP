namespace bibliotheque_TP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.Initialize();
            Book book = new Book("L'empereur Dieu de Dune", "Frank Hebert", 500, Genre.SF);
            Book book2 = new Book("Le Dieu venu du Centaure", "Philip K. Dick", 400, Genre.SF);
            Book book3 = new Book("Don Quichotte", "Cervantes", 604, Genre.satire);
            Book book4 = new Book("Le Horla", "Guy de Maupassant", 132, Genre.horreur);
            Book book5 = new Book("Candide", "Voltaire", 303, Genre.satire);
            Book book6 = new Book("Le crime de l'Orient-Express", "Agatha Christie", 423, Genre.policier);
            Book book7 = new Book("Le prince", "Nicolas Machiavel", 392, Genre.philosophie);
            Book book8 = new Book("Le problème à 3 corps", "Liu Cixin", 626, Genre.SF);

            User fabien = new User("Fabien", "Hass");
            fabien.BorrowBook(book);
            fabien.BorrowBook(book8);

            User john = new User("John", "Doe");
            john.BorrowBook(book2);
            john.BorrowBook(book5);
            john.BorrowBook(book7);
            john.BorrowBook(book);

            fabien.DisplayBorrowedBooks();
            john.DisplayBorrowedBooks();

            Database.DisplayBooks(Genre.SF);
            Database.DisplayBooks("Liu");
            Database.DisplayBooksTitle("le");
            Database.WhatBooksAvailable();

        }
    }
}
