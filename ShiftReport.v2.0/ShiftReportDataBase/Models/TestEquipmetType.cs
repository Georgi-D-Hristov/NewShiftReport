namespace ShiftReportDataBase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TestEquipmetType
    {
        public TestEquipmetType()
        {
            TestEquipments=new HashSet<TestEquipment>();
        }
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }

        public ICollection<TestEquipment> TestEquipments { get; set; }
    }
}
