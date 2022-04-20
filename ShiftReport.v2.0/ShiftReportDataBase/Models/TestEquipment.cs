namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TestEquipment
    {
        public TestEquipment()
        {
            SpareParts = new HashSet<SparePart>();
        }
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        [Required]
        public TestEquipmetType Type { get; init; }

        public int TestEquipmentTypeId { get; init; }

        public ICollection<SparePart> SpareParts { get; init; }
    }
}
