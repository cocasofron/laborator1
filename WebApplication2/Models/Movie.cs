using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movie
    {
        //[Key()]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public string Storyline { get; set; }
    }
}
