using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace WebApi.DB
{
    public class ComputerEquipment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(32)]
        public string? AccountNumber { get; set; }
        public int EquipmentTypeId { get; set; }
        [ForeignKey("EquipmentTypeId")]
        public EquipmentType? EquipmentType { get; set; }
        [MaxLength(256)]
        public string? Name { get; set; }
        [Range(1, 1000)]
        public int AccommodationRoom { get; set; }
    }
}
