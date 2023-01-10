using minimalAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var perritos = new List<Perro>()
{
    new Perro{ Name="firulais",Raza="chichuahua",Age=2},
    new Perro{ Name="tigger",Raza="chichuahua",Age=2},
    new Perro{ Name="comino",Raza="chichuahua",Age=2},
    new Perro{ Name="manzana",Raza="chichuahua",Age=2},
};
app.MapGet("/perros", ()=> {
    return perritos;
});

app.MapPost("/crear", (Perro perro) =>
{
    perritos.Add(perro);
    return "Agregado correctamente";
});

app.MapDelete("/eliminar/{index}", (int index) =>
{
    perritos.RemoveAt(index);
    return "Eliminado correctamente";
});

app.Run();
