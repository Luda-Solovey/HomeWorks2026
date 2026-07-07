using Book;

namespace ClassesHomeWork2
{
    internal class Program
    {
        static void Main()
        {
            Page[] pages =
            [
                new Page(1, "Hello! This is the first paragraph"),
                new Page(2, "This is the second paragraph"),
                new Page(3, "This is the last paragraph")
            ];

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

            Page[] pagesForBook =
            [
                 new Page(1, "Some text for page1"),
                 new Page(2, "Some text for page2"),
                 new Page(3, "Some text for page3")
            ];
            //звичайні книжки поки закоментувала, щоб не заважали тестувати книжку з малюнками
            //книжки
            Book book1 = new Book("Kobzar", autorBook1, pagesForBook, publisher1)
            {
                PagesCount = 12
            };

            foreach (var page in book1)
            {
                Console.WriteLine($"Page number {page.Number}, text - {page.Text}");
            }

            Console.WriteLine("------------------------------------");

            //це те, що знаходиться "під капотом" foreach-a (тобто, можна і так ітерувати)

            IEnumerator<Page> enumerator = book1.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine($"While. Page number {item.Number}, text - {item.Text}");
            }

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
            //string[] images = { "Sea", "Tree", "Bird", "Sun", "Mountain", "Cat" };
            //uint[] pagesForImages = [2, 3, 4, 5, 7, 8];

            //BookWithImages bookWithImages1 = new BookWithImages("Fairy Tales", autorBook2, images, pagesForImages)
            //{
            //    PagesCount = 12,
            //    PublicationDate = new DateOnly(2020, 5, 15),
            //    Pages = pages

            //};

            book1.Open();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("What should we do next");
                Console.WriteLine("1-Next page");
                Console.WriteLine("2-Go to the begging");
                Console.WriteLine("3-Exit");

                string answer = Console.ReadLine() ?? string.Empty;

                switch (answer)
                {
                    case "1":    
                    {
                            if (book1.MoveNext())
                            {
                                book1.ShowCurrentPage();
                            }
                            else
                            {
                                Console.WriteLine("It`s end of the book");
                            }
                    }
                    break;
                    case "2":
                    {
                       book1.Open();
                       book1.ShowCurrentPage();
                    }
                    break;
                    case "3":
                        flag = false;   
                        break;
                }
             
            }

            Console.ReadKey();
        }
    }
}
