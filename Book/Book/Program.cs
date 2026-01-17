using Book;
using static System.Net.Mime.MediaTypeNames;

namespace ClassesHomeWork2
{
    internal class Program
    {
        static void Main()
        {
            Page[] pages = new Page[12]
            {
                new Page(1, "Some text of page 1"),
                new Page(2, "Some text of page 2"),
                new Page(3, "Some text of page 3"),
                new Page(4, "Some text of page 4"),
                new Page(5, "Some text of page 5"),
                new Page(6, "Some text of page 6"),
                new Page(7, "Some text of page 7"),
                new Page(8, "Some text of page 8"),
                new Page(9, "Some text of page 9"),
                new Page(10, "Some text of page 10"),
                new Page(11, "Some text of page 11"),
                new Page(12, "Some text of page 12")
            };

            //автори книжок
            var autorBook1 = new AuthorBook("Taras", "Shevchenko")
            {
                BirthDate = new DateOnly(1814, 3, 9)
            };

            var autorBook2 = new AuthorBook("Lesia", "Ukrainka")
            {
                BirthDate = new DateOnly(1871, 2, 25)
            };

            var autorBook3 = new AuthorBook("Jefry", "Rihter")
            {
                BirthDate = new DateOnly(1935, 11, 30)
            };


            //друкарні
            var publisher1 = new Publisher("Lvivska drukarnia")
            {
                Country = "Ukraine",
                City = "Lviv",
                Street = "Shevchenka St",
                PostalCode = "79000",
                EstablishYear = 1892
            };

            var publisher2 = new Publisher("London printing house")
            {
                Country = "UK",
                City = "London",
                Street = "Baker St",
                PostalCode = "EC1A 1BB",
                EstablishYear = 1850
            };

            //звичайні книжки поки закоментувала, щоб не заважали тестувати книжку з малюнками
            //книжки
            //Book book1 = new Book("Kobzar", autorBook1, publisher1)
            //{ PagesCount = 12 
            //};
            //book1.OpenBook();
            //Console.WriteLine(book1.ToString());

            //Book book2 = new Book("programming in C#", autorBook3, publisher2)
            //{ PagesCount = 350};
            //book2.OpenBook();
            //Console.WriteLine(book2.ToString());

            //Book book3 = new Book("Poetry", autorBook2)
            //{ PagesCount = 125, Publisher = publisher1};
            //book3.OpenBook();

            //книжка з малюнками
            string[] images = { "Sea", "Tree", "Bird", "Sun", "Mountain", "Cat" };
            uint[] pagesForImages = [2, 3, 4, 5, 7, 8];

            BookWithImages bookWithImages1 = new BookWithImages("Fairy Tales", autorBook2, images, pagesForImages)
            {
                PagesCount = 12,
                PublicationDate = new DateOnly(2020, 5, 15),
                Pages = pages

            };

            bookWithImages1.OpenBook();
            while (bookWithImages1.CurrentPage < bookWithImages1.PagesCount)

                bookWithImages1.NextPage(1);

            Console.ReadKey();
        }
    }
}
