using Lab_05_WebApi.Models;

namespace Lab_05_WebApi.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        Animals.Add(
            new Animal(1, "Burek", "Dog", 12.5, "Brown"));
        Animals.Add(
            new Animal(2, "Mruczek", "Cat", 5.5, "Black"));
        Animals.Add(
            new Animal(3, "Puszek", "Hamster", 0.5, "White"));
        Animals.Add(
            new Animal(4, "Krolik", "Rabbit", 1.5, "Grey"));
        
        Visits.Add(
            new Visit(1, 2, DateTime.Now.AddDays(-2), "Vaccination", 50.0));
        Visits.Add(
            new Visit(2, 4, DateTime.Now.AddDays(-4) , "Health Check", 25.0));
    }
}