namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Case
    {

        public Case()
        {
            UsedSpareParts = new HashSet<SparePart>();
        }

        [Key]
        public int Id { get; init; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]

        public DateTime EndTime { get; set; }
        [Required]
        public int EngineerId { get; init; }

        public Engineer Engineer { get; init; }

        [Required]
        public int TestEquipmentId { get; set; }
        public TestEquipment TestEquipment { get; set; }

        [Required]
        public string ProductVariant { get; init; }

        public string IssueDescription { get; set; }

        public string Action { get; set; }

        [Required]
        public int StatusId { get; init; }
        public Status Status { get; init; }

        public ICollection<SparePart> UsedSpareParts { get; init; }

        public string Notes { get; init; }
    }
}
