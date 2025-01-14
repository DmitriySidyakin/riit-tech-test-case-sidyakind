using System.ComponentModel.DataAnnotations;

namespace WebApi.DB
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string? Name { get; set; }
    }
}
