﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class propertyList: BaseModel
    {
        public Guid PropertyListId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid UserId { get; set; }
    }
}
