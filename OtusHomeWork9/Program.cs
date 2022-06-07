using Microsoft.Extensions.Configuration;
using OtusHomeWork9;

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
var configuration = builder.Build();

// <summary>
/// SOLID - L. Принцип Барбары Лисков
/// в объект Game можем передать либой класс реализующий интерфейс IGenerator 
/// и внутри объекта Game обращаться к нему точно так же 
/// </summary>
var game = new Game(new Generator())
{
    BeginRange = Convert.ToInt32(configuration["beginRange"]),
    EndRange = Convert.ToInt32(configuration["endRange"]),
    Attempts = Convert.ToInt32(configuration["attempts"]),
};
game.Play();