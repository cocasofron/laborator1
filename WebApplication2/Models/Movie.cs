using System;

namespace WebApplication2.Models
{
    public class Movie
    {
        //[Key()]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public string Storyline { get; set; }
    }
}
