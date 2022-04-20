namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Case
    {

        //public Case()
        //{
        //    UsedSpareParts = new HashSet<CaseUsedSparePart>();
        //}

        [Key]
        public int Id { get; init; }

        [Required]
        public DateTime Date { get; init; }

        [Required]
        public DateTime StartTime { get; init; }

        [Required]

        public DateTime EndTime { get; init; }
        [Required]
        public int EngineerId { get; init; }

        public Engineer Engineer { get; init; }

        [Required]
        public int TestEquipmentId { get; init; }
        public TestEquipment TestEquipment { get; init; }

        [Required]
        public string ProductVariant { get; init; }

        public string IssueDescription { get; init; }

        public string Action { get; init; }

        [Required]
        public int StatusId { get; init; }
        public Status Status { get; init; }

       // public ICollection<CaseUsedSparePart> UsedSpareParts { get; init; }

        public string Notes { get; init; }
    }
}
