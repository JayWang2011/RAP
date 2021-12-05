using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAP.Entities
{
    [Table("Position")]
    internal class Position
    {
        public int Id { get; set; }

        public string Level { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }
    }
}
