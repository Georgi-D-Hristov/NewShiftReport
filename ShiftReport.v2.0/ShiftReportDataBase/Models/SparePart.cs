namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SparePart
    {
        public SparePart()
        {
            CasesWithUsedParts = new HashSet<CaseUsedSparePart>();
        }
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
        [Required]
        public int Quantity { get; init; }
        [Required]
        public string Location { get; init; }

        public ICollection<CaseUsedSparePart> CasesWithUsedParts { get; init; }
    }
}
