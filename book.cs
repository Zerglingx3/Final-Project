using System;

class Book {

//auto implemented properties
  public string ISBN {get; set;}
  public string Title {get; set;}
  public string AuthorInfo {get; set;}
  public virtual DateTime PublishedOn {get; set;} 
  public string PublishedBy {get;set;}

  public Book(string isbn, string title, string authorinfo)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = DateTime.Now;
    PublishedBy = "unknown";
  }

  //constructor chaining
  public Book(string isbn, string title, string authorinfo, DateTime publishedon, string publishedby) : this(isbn, title, authorinfo)
  {
    PublishedOn = publishedon;
    PublishedBy = publishedby;

  }

  //display book information
  public void Display(){

    Console.WriteLine("Book '" + Title + "' was written by " + AuthorInfo + " and published on " + PublishedOn);
    
  }

}