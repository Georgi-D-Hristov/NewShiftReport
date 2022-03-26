namespace ShiftReportDataBase.Models
{
    public class Case
    {

        public Case()
        {
            UsedSpareParts = new HashSet<SparePart>();
        }
        public int Id { get; init; }
        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int EngineerId { get; init; }

        public Engineer Engineer { get; init; }

        public int TestEquipmentId { get; set; }
        public TestEquipment TestEquipment { get; set; }

        public string ProductVariant { get; init; }

        public string IssueDescription { get; set; }

        public string Action { get; set; }

        public int StatusId { get; init; }
        public Status Status { get; init; }

        public ICollection<SparePart> UsedSpareParts { get; init; }
    }
}
