using System;

namespace RAP.Entities
{
    internal class Position
    {
        public int Id { get; set; }

        public Level Level { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}
