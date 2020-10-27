using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Humidity
    {
        // Humidity above 50% is typically considered too high, while humidity below 30% is usually too low.
        // The ideal range of relative humidity for a home is between 30% and 50%.
        public int Percentage { get; set; }
    }
}
