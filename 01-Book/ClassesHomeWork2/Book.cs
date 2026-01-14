using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomeWork2
{
    public class Book
    {
        public string Title { get; } //для авто-властивості поле оголошувати не треба, - його створить під капотом компілятор
        public AuthorBook Author { get; } //для авто-властивості поле оголошувати не треба, - його створить під капотом компілятор

        public uint PagesCount { get; set; }

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
    }
}
