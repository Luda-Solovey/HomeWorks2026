namespace ClassesHomeWork2;

public class AuthorBook(string name, string surName)
{
    public string Name { get; } = name;

    public string SurName { get; } = surName;

    public required DateOnly BirthDate { get; init; } 

    public List<Book> Books { get; set; } = new List<Book>();
}
