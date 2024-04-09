﻿namespace Lab_05_WebApi.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            return Results.Ok();
        });
        app.MapGet("/animals/{id:int}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", () =>
        {
            return Results.Created();
        });
        
    }
    
}