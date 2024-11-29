class Library{
    public string LibraryId;
    public string LibraryName;

    public List<Library> books;
    public Library(string libraryId, string libraryName){
        LibraryId = libraryId;
        LibraryName = libraryName;
       
        this.books = new List<Library>();
    }

    public void AddBook(Library book){
        books.Add(book);
    }

    public void showBook()
    {
        Console.WriteLine($"\n Class: {LibraryName}");
        foreach (Library book in books)
        {
            book.showBook();
        }
    }
    public void showBookDetails(string bookId){
        foreach (Library book in books)
        {
            if(book.LibraryId == bookId){
                book.showBook();
                return;
            }
        }
        Console.WriteLine("No such book found.");
    }
    
}