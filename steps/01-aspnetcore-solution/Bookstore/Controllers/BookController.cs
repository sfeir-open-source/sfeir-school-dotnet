using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly List<Book> _bookstore;

        public BookController()
        {
            _bookstore = [
                new Book { Id = 0, Title = "Neuromancer", Author = "William Gibson", Price = 10, Tags = ["SF", "Cyberpunk"] },
                new Book { Id = 1, Title = "Dune", Author = "Franck Herbert", Price = 15, Tags = ["SF", "Politics"] },
                new Book { Id = 1, Title = "Foundation", Author = "Isaac Asimov", Price = 9, Tags = ["SF", "Politics"] },
                new Book { Id = 1, Title = "3 Body Problem", Author = "Liu Cixin", Price = 11, Tags = ["SF", "Mystery"] },
            ];
        }

        [HttpPost]
        public void Post(Book book)
        {
            _bookstore.Add(book);
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookstore.First(w => w.Id == id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bookToRemove = _bookstore.First(w => w.Id == id);
            _bookstore.Remove(bookToRemove);
        }

        [HttpPut("{id}")]
        public void Put(int id, Book book)
        {
            _bookstore.FindIndex(w => w.Id == id);
            _bookstore[id] = book;
        }
    }
}
