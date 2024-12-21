using System.Runtime.CompilerServices;

class Ticket{
    private string ticketId;
    public string TicketId{
        get{
            return ticketId;
        }
        set{
            ticketId = value;
        }
    }
    private Movie movie;
    public Movie Movie{
        get{
            return movie;
        }
        set{
            movie = value;
        }
    }
    
    private Customer customer;
    public Customer Customer{
        get{
            return customer;
        }
        set{
            customer = value;
        }

    }

    private double price;
    public double Price{
        get{
            return price;
        }
        set{
            price = value;
        }
    }

    public Ticket(string ticketId, Movie movie, Customer customer, double price){
        TicketId = ticketId;
        Movie = movie;
        Customer = customer;
        Price = price;

    }

    public void displayTicket(){
        Console.WriteLine($"Ticket ID: {TicketId}, Movie: {Movie.Title}, Customer: {Customer.Name}, Price: {Price}");
    }

    

}