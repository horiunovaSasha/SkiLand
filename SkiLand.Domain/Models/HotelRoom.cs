using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class HotelRoom : IEntity
    {
        public long Id { get; set; }
        //public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomsCount { get; set; }
        //public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public string Description { get; set; }
        //public int SeasonRoomPricingId { get; set; }
    }
}
