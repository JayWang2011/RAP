using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAP.Entities
{
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

        public Type Type { get; set; }

        [MaxLength(1024)]
        public string Cite_As { get; set; }

        public DateTime Available { get; set; }
    }
}
