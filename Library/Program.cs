internal class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine("$Book title: {Title}");
        Console.WriteLine("$Book Author: {Author}");
        Console.WriteLine("$Book ISBN: {ISBN}");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        // Create a new instance (object) of the book class
        //Note how the object name differs from the class name
        Book book = new Book();

        //This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        //Another book object.
        //Note the object name is 'book1' and not 'book'
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

       //Output book info to the console using DisplayInfo

        book.DisplayInfo();
        book1.DisplayInfo();

    }
}

