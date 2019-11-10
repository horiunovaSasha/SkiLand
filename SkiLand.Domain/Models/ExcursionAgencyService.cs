﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkiLand.Domain.Models
{
    public class ExcursionAgencyService : IEntity
    {
        public long Id { get; set; }
        public ExcursionAgency ExcursionAgency { get; set; }
        public ExcursionService ExcursionService { get; set; }
    }
}
