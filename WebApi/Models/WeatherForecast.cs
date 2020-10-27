using System;

namespace WebApi.Models
{
    // There are six main components, or parts, of weather. They are temperature, atmospheric pressure, wind, humidity, precipitation, and cloudiness. 
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
