namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SparePart
    {
        public SparePart()
        {
            //CasesWithUsedParts = new HashSet<CaseUsedSparePart>();
        }
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
        [Required]
        public int Quantity { get; init; }
        [Required]
        public int LocationId { get; init; }

        public SparePartsLocation Location { get; init; }

        public int TestEquipmentId { get; init; }

        public TestEquipment TestEquipment { get; init; }

        // public ICollection<CaseUsedSparePart> CasesWithUsedParts { get; init; }
    }
}
