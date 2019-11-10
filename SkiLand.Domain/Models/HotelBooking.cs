using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class HotelBooking : IEntity
    {
        public long Id { get; set; }
        //public int HotelRoomId { get; set; }
        public HotelRoom HotelRoom { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
