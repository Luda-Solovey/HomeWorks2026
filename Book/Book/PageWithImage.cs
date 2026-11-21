namespace Book;

public class PageWithImage(uint number, string text, byte[] image) : Page(number, text)
{
    public byte[] Image { get; } = image;
}
