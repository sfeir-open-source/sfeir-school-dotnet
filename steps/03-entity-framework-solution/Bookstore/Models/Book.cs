namespace Bookstore.Models;

public class Book
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public float Price { get; set; }
  public required string Author { get; set; }
  public List<string> Tags { get; set; } = [];
}
