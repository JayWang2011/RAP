using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAP.Entities
{
    [Table("Researcher_Publication")]
    internal class Researcher_Publication
    {
        [Column("Researcher_Id")]
        public int ResearcherId { get; set; }

        [MaxLength(256)]
        public string Doi { get; set; }

        public Researcher Researcher { get; set; }

        public Publication Publication { get; set; }

    }
}
