namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Engineer
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
