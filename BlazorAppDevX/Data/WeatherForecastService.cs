namespace BlazorAppDevX.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<List<WeatherForecastModel>> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
            {
                Id= index,
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                SomeStatistic = Random.Shared.Next(1000000,5000000),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList());
        }
    }
}