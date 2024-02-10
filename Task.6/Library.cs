namespace Task._6;

public class Library : Ilibrary
{
    List<Book> _books = new List<Book>();
    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void DeleteBook(int id)
    {
        var a = _books.FirstOrDefault(p => p.Id == id);
        _books.Remove(a);
    }

    public List<Book> DisplayBooks()
    {
        return _books;
    }

    public List<Book> SearchByAuthor(string author)
    {
        List<Book> search = _books.Where(p=>p.Author.ToLower()==author.ToLower()).ToList();
        return search;
    }

    public Book SearchByTitle(string title)
    {
        var a = _books.FirstOrDefault(p => p.Title == title);
        return a;
    }

    public void UpdateBook(Book book)
    {
        var a = _books.FirstOrDefault(p=>p.Id==book.Id);
        a.Author=book.Author;
        a.Title=book.Title;
        
    }

}
