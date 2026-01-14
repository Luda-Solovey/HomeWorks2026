using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHomeWork2
{
    public class AuthorBook
    {
        public string Name { get; }

        public string SurName { get; }

        public required DateOnly BirthDate { get; init; } //тут поле помічене як required для прикладу використання required

        public List<Book> Books { get; set; } 

        public AuthorBook(string name, string surName)
        { 
            Name = name;
            SurName = surName;
            Books = new List<Book>();
        }
    }
}
