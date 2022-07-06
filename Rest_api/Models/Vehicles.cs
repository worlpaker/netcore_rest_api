// Data Models
using System.Text.Json.Serialization;

namespace Rest_api.Models
{
    public class Vehicles
    {  
        public Cars? Cars { get; set; }
        public Buses? Buses { get; set; } 
        public Boats? Boats { get; set; } 
    }

   public enum Colours
    {
        Red = 0,
        Blue = 1,
        Black = 2,
        White = 3
    }

    public class Cars
    {
        public int Id { get; set; }
        public int Wheels { get; set; } 
        public bool Headlights { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Colours? Colours { get; set; } 
    }
    
    public class Buses
    {
        public int Id { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Colours? Colours { get; set; }

    }

    public class Boats
    {
        public int Id { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Colours? Colours { get; set; }

    }


    
}
