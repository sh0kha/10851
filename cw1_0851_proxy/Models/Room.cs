using System.ComponentModel.DataAnnotations;

namespace cw1_0851_proxy.Models
{
    public class Room
    {
        [Key]
        public int? RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public string Brief { get; set; }
    }
}
