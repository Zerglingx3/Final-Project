using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person
{
  //properties
  private List<Book> BookList = new List<Book>();

  public Author() : base()
  {
    
  }

  public Author(string firstname, string lastname) : base(firstname, lastname)
  {

  }


  public void DisplayInfo() //displays first name, last name, and email
  {
    Console.WriteLine(FirstName);
    Console.WriteLine(LastName);
    Console.WriteLine(Email);
  }

  public void DisplayBooks()
  {
    foreach(Book b in BookList)
    {
      b.Display();
    }
  }

  public void AddBook(Book cnb)
  {
    BookList.Add(cnb);
  }

  // accessing Book.cs, initializes bk if ISBN is matched in BookList list
  public void RemoveBook(string temp)
  {
    // book class 
    Book bk = BookList.Find(b=>b.ISBN == temp);
    BookList.Remove(bk);
  }



}