using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace SampleCoreWebApi.Models
{
    public class Books
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public long ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorID { get; set; }
        public int Price { get; set; }
        public Authors? Author { get; set; } = new Authors();
    }

    public class Authors
    {
        public int AuthorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Books>? Books { get; set; } = new List<Books>();
    }

    public interface IBookRepository
    {
        List<Books> GetAll();
        Books GetBook(int id);
        void UpdateDetails(int id, Books book);
        void DeleteBook(int id);
        List<Authors> GetAuthors();
        void AddBook(Books book);
    }

    public class BookRepository : IBookRepository
    {
        //private string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=SecuritonDB;Integrated Security=True;TrustServerCertificate=True";

        private readonly IConfiguration _config;
        private readonly string? _connectionString;
        public BookRepository(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("myConn");
        }

        public void AddBook(Books book)
        {
            using(var connection = CreateConnection())
            {
                connection.Open();
                connection.Execute("Insert into Books Values(@title, @year, @isbn, @date, @auId,@price)", new { title = book.Title, year = book.Year, isbn = book.ISBN, date = book.PublishedDate, auId = book.AuthorID, price = book.Price });
                connection.Close();
            }
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
        public void DeleteBook(int id)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                connection.Execute("DELETE FROM Books where BookID =@id", new { id = id });
                connection.Close();
            }
        }

        public List<Books> GetAll()
        {
            //var query = "SELECT b.*, a. from books b inner join authors a on b.AuthorID = a.AuthorID";
            var query = "SELECT * from Books";
            using (var connection = CreateConnection())
            {
                connection.Open();                    
                var data = connection.Query<Books>(query).ToList();
                connection.Close();
                return data;
            }
           
        }

        public List<Authors> GetAuthors()
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                var data = connection.Query<Authors>("SELECT * FROM Authors").ToList();
                connection.Close();
                return data;
            }
        }

        public Books GetBook(int id)
        {
            Books book = new Books();
            using(var connection = CreateConnection())
            {
                connection.Open();
                book = connection.QuerySingle<Books>("SELECT * FROM Books Where BookID = @id", new { id = id });
                connection.Close();
            }
            return book;
        }

        public void UpdateDetails(int id, Books book)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                connection.Execute("Update Books Set Title= @title, Year = @year, ISBN =@isbn, PublishedDate = @date, AuthorId =@auId, Price = @price Where BookID = @id", new { title = book.Title, year = book.Year, isbn =book.ISBN, date  = book.PublishedDate, auId = book.AuthorID, price =book.Price, id = id });
                connection.Close();
            }
        }
    }
}
