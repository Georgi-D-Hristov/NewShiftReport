namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Status
    {
        [Key]
        public int Id { get; init; }
        [Required]
        public string Discription { get; init; }
    }
}
