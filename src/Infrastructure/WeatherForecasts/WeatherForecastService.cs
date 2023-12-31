﻿namespace CleanArchitecture.Infrastructure.WeatherForecasts;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    public Task<IEnumerable<WeatherForecast>> GetForecasts(CancellationToken cancellationToken)
    {
        var rng = new Random();

        var vm = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        });

        return Task.FromResult(vm);
    }
}
