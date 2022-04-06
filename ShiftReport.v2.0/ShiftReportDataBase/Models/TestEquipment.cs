namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TestEquipment
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        [Required]
        public TestEquipmetType Type { get; init; }

        public int TestEquipmentTypeId { get; set; }
    }
}
