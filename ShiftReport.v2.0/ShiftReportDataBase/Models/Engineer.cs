namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Engineer
    {
        public Engineer()
        {
            TakeCases = new List<Case>();
        }

        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        public ICollection<Case> TakeCases { get; set; }
    }
}
