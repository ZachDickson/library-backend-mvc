using System;

namespace csLibrary
{
  public class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Id { get; set; }


    public Book(string title, string author)
    {
      Title = title;
      Author = author;
      Id = Guid.NewGuid().ToString();
    }

    public Book()
    {
      Id = Guid.NewGuid().ToString();
    }
  }
}