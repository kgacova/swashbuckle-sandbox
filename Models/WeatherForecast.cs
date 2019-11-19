using Microsoft.AspNetCore.Http;
using System;

namespace Models
{
    /// <summary>
    /// Detailed weather forecast
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// The date for the forecast
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in degrees Celsius 
        /// </summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public IFormFile File { get; set; }
    }
}
