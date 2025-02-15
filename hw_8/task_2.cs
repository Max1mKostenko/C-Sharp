class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private int year;

    public int Year
    {
        get { return year; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Year cannot be negative");
            year = value;
        }
    }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, published in {Year}";
    }

    public static bool operator ==(Book b1, Book b2)
    {
        return b1?.Title == b2?.Title && b1?.Author == b2?.Author && b1?.Year == b2?.Year;
    }

    public static bool operator !=(Book b1, Book b2) => !(b1 == b2);
}

class Library
{
    private Book[] books;
    private int count;

    public Library(int size)
    {
        books = new Book[size];
        count = 0;
    }

    public void AddBook(Book book)
    {
        if (count >= books.Length)
        {
            Console.WriteLine("Library is full, cannot add more books.");
            return;
        }
        books[count++] = book;
    }

    public void RemoveBook(string title)
    {
        int index = Array.FindIndex(books, 0, count, b => b?.Title == title);
        if (index < 0)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        books[index] = books[--count];
        Console.WriteLine($"Book '{title}' removed.");
    }

    public bool ContainsBook(string title) => books.Any(b => b?.Title == title);

    public Book this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index is out of range");
            return books[index];
        }
        set
        {
            if (index < 0 || index >= books.Length)
                throw new IndexOutOfRangeException("Index is out of range");
            books[index] = value;
        }
    }

    public void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("Library is empty.");
            return;
        }
        Console.WriteLine("Library books:");
        foreach (var book in books.Take(count))
        {
            Console.WriteLine(book);
        }
    }

    public static Library operator +(Library library, Book book)
    {
        library.AddBook(book);
        return library;
    }

    public static Library operator -(Library library, string title)
    {
        library.RemoveBook(title);
        return library;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library(5);

        library += new Book("1984", "George Orwell", 1949);
        library += new Book("Brave New World", "Aldous Huxley", 1932);
        library += new Book("Fahrenheit 451", "Ray Bradbury", 1953);
        library.DisplayBooks();

        Console.WriteLine(library.ContainsBook("1984") ? "Book found" : "Book not found");

        library -= "1984";
        library.DisplayBooks();
    }
}
