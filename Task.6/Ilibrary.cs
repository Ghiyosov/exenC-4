namespace Task._6;

public interface Ilibrary
{
     void AddBook(Book book);
     List<Book> DisplayBooks();
     void UpdateBook(Book book);
     void DeleteBook(int id);
     Book SearchByTitle(string title);
     Book SearchByAuthor(string author);
}
