using System;
using System.Collections.Generic;

namespace Cliche.Fluent.Models
{
    public class Character
    {
        public long CharacterId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public int DejaVuRatio { get; set; }

        public List<string> Tags { get; set; }

        public Type Category { get; set; }

        public string Movie { get; set; }

        public enum Type
        {
            Hero,
            Mentor,
            Sidekick,
            Vilain
        }
    }
}
