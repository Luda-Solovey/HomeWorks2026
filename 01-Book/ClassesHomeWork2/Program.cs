namespace ClassesHomeWork2
{
    internal class Program
    {
        static void Main()
        {

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


            //книжки
            Book book1 = new Book("Kobzar", autorBook1, publisher1);
            book1.OpenBook();
            Console.WriteLine(book1.ToString());

            Book book2 = new Book("programming in C#", autorBook3, publisher2)
            { PagesCount = 350};
            book2.OpenBook();
            Console.WriteLine(book2.ToString());

            Book book3 = new Book("Poetry", autorBook2)
            { PagesCount = 125, Publisher = publisher1};
            book3.OpenBook();
        }
    }
}
