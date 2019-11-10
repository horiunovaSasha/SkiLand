using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class Photo : IEntity
    {
        public long Id { get; set; }
        public string Path { get; set; }
    }
}
