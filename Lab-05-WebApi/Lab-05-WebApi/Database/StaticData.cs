using Lab_05_WebApi.Models;

namespace Lab_05_WebApi.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };
}