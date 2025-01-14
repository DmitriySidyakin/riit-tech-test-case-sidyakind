using WebApi.DB;

namespace WebApi.Entities
{
    public class LoadResponse
    {
        public int totalCount { get; set; }

        public List<ComputerEquipment> data { get; set; }
    }
}
