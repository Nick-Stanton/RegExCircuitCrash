using System.ComponentModel.DataAnnotations;

namespace BlazorAppDevX.Data
{
    public class WeatherForecastModel: WeatherForecast
    {
        [Range(0,99,ErrorMessage="Some Stat must be between {0} and {1}")]
        public decimal UpdatedSomeStatistic
        {
            get => this.SomeStatistic / (decimal)Math.Pow(10, 6);
            set
            {
                this.SomeStatistic = value * (decimal)Math.Pow(10, 6);
            }
        }
    }
}
