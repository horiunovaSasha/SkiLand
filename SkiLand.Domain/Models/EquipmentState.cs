﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class EquipmentState : IEntity
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
}
