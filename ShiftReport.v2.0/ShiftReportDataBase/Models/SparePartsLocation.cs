namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SparePartsLocation
    {
        public SparePartsLocation()
        {
            SpareParts = new HashSet<SparePart>();
        }

        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        public string LocationPicture { get; init; }

        public string Description { get; init; }

        public ICollection<SparePart> SpareParts { get; init; }
    }
}
