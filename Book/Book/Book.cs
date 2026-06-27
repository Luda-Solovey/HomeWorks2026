using Book;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomeWork2;

public class Book
{
    protected uint currentPage = 1;
namespace ClassesHomeWork2
{
    public class Book : IEnumerable<Page>
    {

        private Page[] pages;
        //protected uint currentPage = 1;

        public  Page[] Pages { get; set; }
        public string Title { get; } //для авто-властивості поле оголошувати не треба, - його створить під капотом компілятор
        public AuthorBook Author { get; } //для авто-властивості поле оголошувати не треба, - його створить під капотом компілятор

    public required uint PagesCount { get; init; }
        
    public DateOnly PublicationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public Publisher? Publisher { get; set; }

        

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
            pages = bookPages;
        }

        public Book(string title, AuthorBook author, Page[] bookPages, Publisher publisher)
            : this(title, author, bookPages)
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

        public IEnumerator<Page> GetEnumerator()
        {
            return new PagesEnumerator(pages);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
