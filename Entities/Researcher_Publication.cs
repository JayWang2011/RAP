using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAP.Entities
{
    internal class Researcher_Publication
    {
        [Column("Researcher_Id")]
        public int ResearcherId { get; set; }

        [MaxLength(256)]
        public string Doi { get; set; }
    }
}
