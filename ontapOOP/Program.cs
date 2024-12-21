internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Cinema cinema=new Cinema();
        Movie movie1= new Movie("M1","The AVENGER","Joss Wehdon",143,8);
        Movie movie2= new Movie("M2","The Matrix","The Wachowski Brothers",136,9);
        cinema.AddMovie(movie1);
        cinema.AddMovie(movie2);

        //main menu
        int choice ;
        bool isRunning = true;

        while(true){
            Console.WriteLine("================================================");
            Console.WriteLine("1.Add a new customer");
            Console.WriteLine("2.Book ticket");
            Console.WriteLine("3.View user's ticket");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("Enter customer name");
                    string customerName = Console.ReadLine();
                    Console.WriteLine("Enter customer email");
                    string customerEmail = Console.ReadLine();
                    Console.WriteLine("Enter customer phone number");
                    string customerPhoneNumber = Console.ReadLine();
                    Customer customer = new Customer(customerName, customerEmail, customerPhoneNumber);
                    cinema.AddCustomer(customer);
                    break;
                case 2:
                    Console.WriteLine("Enter customer email");
                    string email=Console.ReadLine();
                    Customer customer1 = cinema.Customers.Find(c=>c.Email == email);
                    if(customer1==null){
                        Console.WriteLine("Customer not found");

                    }
                    else{
                        Console.WriteLine("Enter movie id");
                        string movieId = Console.ReadLine();
                        Movie movie = cinema.Movies.Find(m=>m.MovieId == movieId);
                        if(movie==null){
                            Console.WriteLine("Movie not found");
                        }
                        Console.WriteLine("Enter price");
                        double price = Convert.ToDouble(Console.ReadLine());
                        cinema.bookTicket(movie, customer1, price);
                        break;
                    }
                    break;
                case 3:
                    foreach (Customer c in cinema.Customers){
                        c.ViewBookingHistory();
                        Console.WriteLine("-----------------------------------------------");
                    }
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }

    }
}