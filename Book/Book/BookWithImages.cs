using Book;

namespace ClassesHomeWork2;

public class BookWithImages(string title, AuthorBook author, PageWithImage[] pages) : Book(title, author, pages)
{

    public override void ShowCurrentPage()
    {
        base.ShowCurrentPage();

        PageWithImage? pageWithImage = Current as PageWithImage;
        if (pageWithImage is not null)
        {
            for (int i=0; i<pageWithImage.Image.Length; i++)
                Console.WriteLine(pageWithImage.Image[i]);
        }
    }
}
