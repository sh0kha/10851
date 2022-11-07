using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_0851_view.Models
{
    public class Room
    {
        public int? RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public string Brief { get; set; }
    }
}
