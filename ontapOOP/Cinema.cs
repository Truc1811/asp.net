class Cinema{
    private List<Customer> customers=new List<Customer>();

    private List<Movie> movies=new List<Movie>();

    public List<Customer> Customers{
        get{
            return customers;
        }
        set{
            customers = value;
        }
    }

    public List<Movie> Movies{
        get{
            return movies;
        }
        set{
            movies = value;
        }
    }
    

    private TicketManager ticketManager=new TicketManager();
    
    public void AddCustomer(Customer customer){
        customers.Add(customer);
        Console.WriteLine("Customer added");
    }


    public void AddMovie(Movie movie){
        movies.Add(movie);
        Console.WriteLine("Movie added");
    }


    public void bookTicket(Movie movie, Customer customer, double price){
        Ticket ticket = ticketManager.createTicket(movie, customer, price);
        customer.addTicket(ticket);
        Console.WriteLine($"Ticket booked by customer {customer.Name}");
    }

}