using Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomeWork2
{
    //новий синтаксис Primary constructor (C# 9.0 and later)

    //public class BookWithImages(string title, AuthorBook author, string[] images, string[] pages) : Book(title, author)
    //{
    //    private string[] images;

    //    private string[] pages;

    //    public string[] Images
    //    {
    //        get => images;
    //        set => images = value ?? Array.Empty<string>();
    //    }
    //    public string[] Pages
    //    {
    //        get => pages;
    //        set => pages = value ?? Array.Empty<string>();
    //    }

    //}

    public class BookWithImages : Book
    {
        private string[] images;
        private uint[] pagesForImages;
        public BookWithImages(string title, AuthorBook author, string[] images, uint[] pagesForImages)
            : base(title, author)
        {
            this.images = images ?? Array.Empty<string>();
            this.pagesForImages = pagesForImages ?? Array.Empty<uint>();
        }


        public void NextPage(uint startedPage)
        {
            if (CurrentPage < PagesCount)
            {
                ShowCurrentPage(CurrentPage);
                CurrentPage++;
            }
            //Console.WriteLine($"Book: {Title} Images:");
            //for (int i = 0; i < images.Length; i++)
            //{
            //    Console.WriteLine($"Page {pagesForImages[i]}: {images[i]}");
            //}
        }

        public void ShowCurrentPage(uint currentPage)
        {
            Console.WriteLine($"Current Page: {CurrentPage}");

            Console.WriteLine($"Text: {Pages[currentPage - 1].Text};");

            for (int i = 0; i < pagesForImages.Length; i++)
            {
                if (pagesForImages[i] == currentPage)
                {
                    Console.WriteLine($"Image on Page {currentPage}: {images[i]}");

                    return;
                }
            }
        }
    }
}
