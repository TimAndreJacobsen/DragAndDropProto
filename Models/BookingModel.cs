using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragAndDropProto.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public BookingStatuses Status { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public enum BookingStatuses
    {
        Free,
        Started,
        Completed
    }
}
