class Book{
    public string id;
    public string name;
    public string title;
    public string author;
    public double price;


    public Book(string id, string name, string title, string author, double price){
        this.id = id;
        this.name = name;
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void showBook(){
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }

}