class Book{
    public string bookid;
    public string bookname;
    public string author;
    public int year;
    public Book(string bookid, string bookname, string author, int year){
        this.bookid = bookid;
        this.bookname = bookname;
        this.author = author;
        this.year = year;
    }
    public virtual void showBook()
    {
        Console.WriteLine("ID: " + bookid);
        Console.WriteLine("Name: " + bookname);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Author: " + author);
        
    }

}