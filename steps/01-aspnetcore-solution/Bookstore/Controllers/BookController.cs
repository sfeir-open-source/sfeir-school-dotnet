using Bookstore.Models;

using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers;

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
            new Book { Id = 2, Title = "Foundation", Author = "Isaac Asimov", Price = 9, Tags = ["SF", "Politics"] },
            new Book { Id = 3, Title = "3 Body Problem", Author = "Liu Cixin", Price = 11, Tags = ["SF", "Mystery"] },
        ];
    }

    [HttpPost]
    public IActionResult Post(Book book)
    {
        if (book.Title is null || book.Author is null) return BadRequest();
        _bookstore.Add(book);
        return Created("", book);
    }

    [HttpGet]
    public IActionResult Get()
    {
        if (_bookstore.Count > 0) return Ok(_bookstore);
        return NotFound();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var result = _bookstore.Find(w => w.Id == id);
        if (result is null) return NotFound();
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var bookToRemove = _bookstore.Find(w => w.Id == id);
        if (bookToRemove is null) return NotFound();
        _bookstore.Remove(bookToRemove);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Book book)
    {
        if (!_bookstore.Exists(w => w.Id == id)) return NotFound();
        _bookstore[id] = book;
        return Ok(book);
    }
}
