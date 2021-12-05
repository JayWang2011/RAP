using System;
using System.ComponentModel.DataAnnotations;

namespace RAP.Entities
{
    internal class Researcher
    {
        public int Id { get; set; }

        public ResearcherType Type { get; set; }

        [MaxLength(20)]
        public string Given_Name { get; set; }

        [MaxLength(20)]
        public string Family_Name { get; set; }

        [MaxLength(10)]
        public string Title { get; set; }

        [MaxLength(64)]
        public string Unit { get; set; }

        public Campus Campus { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(512)]
        public string Photo { get; set; }

        [MaxLength(16)]
        public string Degree { get; set; }

        public int? Supervisor_Id { get; set; }

        public Level Level { get; set; }

        public DateTime Utas_Start { get; set; }

        public DateTime Current_Start { get; set; }
    }
}
