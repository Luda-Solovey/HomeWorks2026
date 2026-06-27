namespace ClassesHomeWork2;

public class BookWithImages(string title, AuthorBook author, string[] images, uint[] pagesForImages) : Book(title, author)
{
    public string[] Images { get; } = images ?? [];
    public uint[] PagesForImages = pagesForImages ?? [];

    public bool NextPage()
    {
        if (this.currentPage < PagesCount)
        {
            currentPage++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        currentPage = 1;
    }

    public override void ShowCurrentPage()
    {
        base.ShowCurrentPage();

        for (int i = 0; i < pagesForImages.Length; i++)
        {
            if (pagesForImages[i] == currentPage)
            {
                Console.WriteLine($"Image on Page {currentPage}: {images[i]}");

                break;
            }
        }
    }
}
