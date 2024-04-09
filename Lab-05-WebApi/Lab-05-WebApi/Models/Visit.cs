namespace Lab_05_WebApi.Models;

public class Visit
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    
    public Visit(int id, int animalId, DateTime date, string? description, double price)
    {
        Id = id;
        AnimalId = animalId;
        Date = date;
        Description = description;
        Price = price;
    }
}