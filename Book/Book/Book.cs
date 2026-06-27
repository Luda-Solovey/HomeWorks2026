using Book;

namespace ClassesHomeWork2;

public class Book
{
    protected uint currentPage = 1;

    public required Page[] Pages { get; init; }
    public string Title { get; } 
    public AuthorBook Author { get; } 

    public required uint PagesCount { get; init; }
        
    public DateOnly PublicationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public Publisher? Publisher { get; set; }

    public Book(string title, AuthorBook author)
    {
        if (author is null)
        {
            throw new ArgumentException("Author cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title cannot be null or empty.");
        }

        Title = title;
        Author = author;
    }

    public Book(string title, AuthorBook author, Publisher publisher)
        : this(title, author)
    {

        Publisher = publisher;
    }

    public void OpenBook()
    {
        Console.WriteLine($"Book: {Title}, author: {Author.Name} {Author.SurName}, pages: {PagesCount}");
    }

    //Override ToString() method for easy display of book information
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author.Name} {Author.SurName}, Publisher: {Publisher.Name}";
    }

    public virtual void ShowCurrentPage()
    {
        Console.WriteLine($"Current Page: {currentPage}");
        Console.WriteLine($"Text: {Pages?[currentPage - 1]?.Text};");
    }
}
