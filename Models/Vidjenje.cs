using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Vidjenje
    {
        [Key]
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Vreme { get; set; }

        [JsonIgnore]
        public Ptica Ptica { get; set; }
        
        public Podrucje Podrucje { get; set; }
    }
}
