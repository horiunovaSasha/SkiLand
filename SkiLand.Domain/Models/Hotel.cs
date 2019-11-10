using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class Hotel : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Raiting { get; set; }
        public string Location { get; set; }
        //public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
