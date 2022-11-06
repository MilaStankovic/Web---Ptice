using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.JSInterop;

namespace Models
{
    public class Podrucje
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }

        public List<Vidjenje> Vidjanja { get; set; }
    }
}
