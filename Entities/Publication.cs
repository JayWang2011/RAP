using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAP.Entities
{
    [Table("Publication")]
    internal class Publication
    {
        [Key]
        [MaxLength(256)]
        public string Doi { get; set; }

        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(256)]
        public string Authors { get; set; }

        [Column(TypeName = "YEAR")]
        public short Year { get; set; }

        public string Type { get; set; }

        [MaxLength(1024)]
        public string Cite_As { get; set; }

        public DateTime Available { get; set; }

        public List<Researcher_Publication> Researcher_Publications { get; set; }
    }
}
