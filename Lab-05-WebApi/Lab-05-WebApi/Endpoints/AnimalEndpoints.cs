using Lab_05_WebApi.Database;
using Lab_05_WebApi.Models;

namespace Lab_05_WebApi.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            var animals = StaticData.animals;
            return Results.Ok(animals);
        });
        app.MapGet("/animals/{id:int}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("", animal);
        });
        
    }
    
}