using Book;
using System.Collections;

namespace ClassesHomeWork2;

public class Book : IEnumerable<Page>, IEnumerator<Page>
{
    private int position = -1;

    public Page[] Pages { get; }

    public string Title { get; } 

    public AuthorBook Author { get; }

    public required uint PagesCount { get; init; }

    public DateOnly PublicationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public Publisher? Publisher { get; set; }

    public Page Current => Pages[position];

    object IEnumerator.Current => Current;

    public Book(string title, AuthorBook author, Page[] bookPages)
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
        Pages = bookPages;
    }

    public Book(string title, AuthorBook author, Page[] bookPages, Publisher publisher)
        : this(title, author, bookPages)
    {

        Publisher = publisher;
    }

    public void Open()
    {
        Console.WriteLine($"Book: {Title}, author: {Author.Name} {Author.SurName}, pages: {PagesCount}");
        Reset();
        MoveNext(); 
    }

    //Override ToString() method for easy display of book information
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author.Name} {Author.SurName}, Publisher: {Publisher.Name}";
    }

    public IEnumerator<Page> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public virtual void ShowCurrentPage()
    {
        Console.WriteLine($"Number of Page: {Current.Number}");
        Console.WriteLine($"Text: {Pages?[position]?.Text};");
    }

    public void Dispose()
    {
        Reset();
    }

    public bool MoveNext()
    {
        if (position < Pages.Length - 1)
        {
            position++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        position = -1;
    }
}
