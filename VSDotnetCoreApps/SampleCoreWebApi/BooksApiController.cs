using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCoreWebApi.Models;

namespace SampleCoreWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksApiController : ControllerBase
    {
        private IBookRepository _repo;
        public BooksApiController(IBookRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public List<Books> GetAllBooks() 
        {
            return _repo.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public Books GetBook(int id)
        {
            return _repo.GetBook(id);
        }

        [HttpPost]
        public string AddBook(Books book)
        {
            try
            {
                _repo.AddBook(book);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Book added to the database";
        }

        [HttpPut]
        public string UpdateBook(Books book) 
        {
            try
            {
                _repo.UpdateDetails(book.BookId, book);
                return "Book updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
