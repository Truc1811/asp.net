class TicketManager{
    //id: t1, t2, t3, t4
    private List<Ticket> tickets=new List<Ticket>();
    private static int ticketCount=1;
    public Ticket createTicket(Movie movie, Customer customer, double price){
        string ticketId="T"+ ticketCount;
        ticketCount++;
        Ticket ticket=new Ticket(ticketId, movie, customer, price);
        tickets.Add(ticket);
        return ticket;
    }
    public void displayTicket(Movie movie, Customer customer, double price){
        Console.WriteLine("Ticket");
        foreach (Ticket ticket in tickets){
            ticket.displayTicket();
        }
    }


}