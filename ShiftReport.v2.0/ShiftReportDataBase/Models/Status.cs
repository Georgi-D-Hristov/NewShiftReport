namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Status
    {

        public Status()
        {
            Cases = new HashSet<Case>();
        }

        [Key]
        public int Id { get; init; }
        [Required]
        public string Discription { get; init; }

        public ICollection<Case> Cases { get; set; }
    }
}
