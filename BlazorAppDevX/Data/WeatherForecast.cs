using BlazorAppDevX.ExtensionMethods;

namespace BlazorAppDevX.Data
{
    public class WeatherForecast 
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public decimal SomeStatistic { get; set; }
        public string? Summary { get; set; }

        
    }
}