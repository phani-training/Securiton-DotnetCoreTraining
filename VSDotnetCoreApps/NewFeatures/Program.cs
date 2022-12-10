namespace NewFeatures
{
    /*
     * Record types are value types or reference types that allows to create Immutable properties.
     * New in .NET 8, U can declare records at the namespace level.
     * We can create record with class or struct. 
     * U can achieve inheritance with Record classes but not with structs. 
     * 
     */

    //Example for Init setters
    class Person
    {
        private int id;
        public int Id 
        {
            get { return id; }
            init { id = value; }//init makes the property to be settable only in the constructor.
        }
    }
    class Customer
    {
        public Customer(int id)
        {
            CustomerId = id;
        }
        public int CustomerId { get; init; }
    }
    //Old Syntax of C# 7.0
    public record class Book
    {
        public Book(int id, string title, string author)
        {
            BookId= id;
            BookTitle = title;
            BookAuthor = author;
        }
        public int BookId { get; init; }
        public string BookTitle { get; init; }
        public string BookAuthor { get; init; }
    }
    public record Employee(int id, string name, string address);//Positional Parameters Syntax of C# 11. 

    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer cst = new(123);
            //Book bk = new (123, "Testing", "BookAuthor");
            ////bk.BookAuthor = "Testing Modified Data";

            //Employee emp = new(1, "Phaniraj", "Bangalore");
            //Console.WriteLine(emp);

            //Non descriptive Mutations with Records. 
            Employee emp1 = new(123, "Phaniraj", "Bangalore");

            Employee emp2 = emp1 with
            {
                id = 124, address ="Mysore"
            };
            Console.WriteLine(emp2);
            Console.WriteLine(emp1);


            //Using the init setter:
            var person = new Person { Id = 123 };
        }
    }
}