using System;
//make 3 classes: exception class, Bk class & a client-class calling upon Book-class-Objects
//Name space is optional if there's ONLY one class. NS is collection of classes
class BookExceptionDemo
{
    static void Main()
    {
        try
        {
            Book book1 = new Book("Goodnight Moon", "Brown",
               12.99, 25);
        }
        catch (BookException e)//except thrown in Book-class-objects are caught here(in client-class)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Book book2 = new Book("World History",
              "Stein", 72.99, 900);
        }
        catch (BookException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Book book3 = new Book("The Grapes of Math", "Stoltz",
               30.99, 300);
        }
        catch (BookException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Book book4 = new Book("Steal This Book",
               "Hoffman", 72.99, 800);
        }
        catch (BookException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class Book
{
    private string title; //since property is NOT auto-implemented, so we need to declare these fields too.
    private string author;
    private double price;
    private int pages;
    const double RATE = 0.10;

    public Book(string title, string author, double price,
       int pages)
    {
        Title = title;
        Author = author;
        if (price > RATE * pages)
            throw (new BookException(title, price, pages)); //no "catch" in this class. excep is caught in the client-class, which must have try-catch block.
        Price = price;
        Pages = pages;
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }
    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public int Pages
    {
        get
        {
            return pages;
        }
        set
        {
            pages = value;
        }
    }

}

public class BookException : Exception
{
    public BookException(string title, double price, int pages) :
        base("For " + title + ", ratio is invalid.\n...Price is " + price.ToString("C") + " for " + pages + " pages.")
    {
    }
}