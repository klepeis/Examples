using System;

namespace GlobalExceptionHandler
{
    public class WeatherForecast
    {
        public int Id { get; set; }

        public string Type { get; set; } = "weatherForecast";

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
