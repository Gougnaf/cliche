using System.Collections.Generic;

namespace Cliche.Fluent.Models
{
    public class Movie
    {
        public long MovieId { get; set; }

        public string Name { get; set; }

        public string Poster { get; set; }

        public string Thumbnail { get; set; }

        public string Description { get; set; }

        public double Duration { get; set; }

        public List<string> Tags { get; set; }
    }
}
