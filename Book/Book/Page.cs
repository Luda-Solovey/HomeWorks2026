namespace Book;

public class Page(uint number, string text)
{
    public string Text { get; } = text;

    public uint Number { get; } = number;
}