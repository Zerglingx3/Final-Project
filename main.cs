using System;

class MainClass {
  public static void Main (string[] args) {
    
    Author author1 = new Author ("John", "Smith");
    author1.DisplayInfo();

    Author author2 = new Author ("Calvin", "Thai");
    author2.DisplayInfo();

    //creating books using first constructor
    Book book1 = new Book ("isbn1", "title1", "info1");
    Book book2 = new Book ("isbn2", "title2", "info2");
    Book book3 = new Book ("isbn3", "title3", "info3");

    //creating books using second constructor
    Book book4 = new Book ("isbn4", "title4", "info4", Convert.ToDateTime("01/01/2021"), "publisher4");
    Book book5 = new Book ("isbn5", "title5", "info5", Convert.ToDateTime("02/01/2021"), "publisher5");
    Book book6 = new Book ("isbn6", "title6", "info6", Convert.ToDateTime("03/01/2021"), "publisher6");

    // assigning author names to authorinfoX
    string authorinfo1 = (author1.FirstName + " " + author1.LastName);

    string authorinfo2 = (author2.FirstName + " " + author2.LastName);

    //modifying AuthorInfo in book class with updated author names
    book1.AuthorInfo = authorinfo1;
    book3.AuthorInfo = authorinfo1;
    book5.AuthorInfo = authorinfo1;

    book2.AuthorInfo = authorinfo2;
    book4.AuthorInfo = authorinfo2;
    book6.AuthorInfo = authorinfo2;

    //adding books to author 1
    author1.AddBook(book1);
    author1.AddBook(book3);
    author1.AddBook(book5);

    author1.DisplayBooks();
    Console.WriteLine("\n");

    //adding books to author 2
    author2.AddBook(book2);
    author2.AddBook(book4);
    author2.AddBook(book6);

    author2.DisplayBooks();
    Console.WriteLine("\n");

    //removing book 1 from list
    author1.RemoveBook("isbn1");
    author1.DisplayBooks();
  }
}