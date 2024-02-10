

using Task._6;

Library libBooks = new Library();

while (true)
{
    System.Console.WriteLine("AddBook");
    System.Console.WriteLine("DisplayBooks");
    System.Console.WriteLine("UpdateBook");
    System.Console.WriteLine("DeleteBook");
    System.Console.WriteLine("SearchByTitle");
    System.Console.WriteLine("SearchByAuthor");
    System.Console.WriteLine("Exit");
    string enter = Console.ReadLine();
    enter = enter.ToLower();
    if (enter == "add")
    {
        Book book = new Book();
        System.Console.Write("ID : ");
        book.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Title : ");

        book.Title = Console.ReadLine();
        System.Console.Write("Author : ");

        book.Author = Console.ReadLine();
        libBooks.AddBook(book);
    }
    if (enter == "displaybooks")
    {

        foreach (var item in libBooks.DisplayBooks())
        {
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Author);
            System.Console.WriteLine("---------------");
        }
    }
    if (enter == "updatebooks")
    {
        Book book = new Book();
        System.Console.Write("ID : ");
        book.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Title : ");

        book.Title = Console.ReadLine();
        System.Console.Write("Author : ");

        book.Author = Console.ReadLine();
        libBooks.UpdateBook(book);
    }
    if (enter == "delete")
    {
        System.Console.Write("ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        libBooks.DeleteBook(id);
    }
    if (enter == "searchbytitle")
    {
        System.Console.Write("Title : ");
        var book = libBooks.SearchByTitle(Console.ReadLine());
        System.Console.WriteLine(book.Id);
        System.Console.WriteLine(book.Title);
        System.Console.WriteLine(book.Author);
    }
    if (enter == "searchbyauthor")
    {
        System.Console.Write("Author : ");

        string author = Console.ReadLine();
        foreach (var item in libBooks.SearchByAuthor(Console.ReadLine()))
        {
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Author);
        }
    }
    if (enter=="exet") return;
}