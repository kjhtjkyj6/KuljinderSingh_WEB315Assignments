using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesDogs.Models
{
    public class Dogs
    {
        public int ID { get; set; }
        public string Breed { get; set; }

        [DataType(DataType.Date)]
        public DateTime Age { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}