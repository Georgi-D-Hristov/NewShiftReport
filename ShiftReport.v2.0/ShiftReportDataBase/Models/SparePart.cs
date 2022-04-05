namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SparePart
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Location { get; set; }

        public int CaseId { get; set; }
        public Case Case { get; set; }
    }
}
