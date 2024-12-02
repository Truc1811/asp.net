class Library
{
    public string LibraryId;
    public string LibraryName;
    public List<Book> books;

    public Library(string libraryId, string libraryName)
    {
        this.LibraryId = libraryId;
        this.LibraryName = libraryName;
        this.books = new List<Book>();
    }

    // Phuong thuc them sach vao thu vien
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void showBook()
    {
        Console.WriteLine($"\n Class: {LibraryName}");
        foreach (Book book in books)
        {

            book.showBook();
        }
    }
}