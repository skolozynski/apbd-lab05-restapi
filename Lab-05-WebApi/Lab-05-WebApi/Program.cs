using Lab_05_WebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// tu dodajemy kontrolery
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// MinimalAPI
/*app.MapGet("/animals", () =>
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
});*/


// Minimap Api
// app.MapAnimalEndpoints();


//Controllers
// tu dodajemy po stworzeniu Controlerow
app.MapControllers();

app.Run();