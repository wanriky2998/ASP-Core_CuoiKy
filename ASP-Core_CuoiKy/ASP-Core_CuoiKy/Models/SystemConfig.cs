﻿using System;
using System.Collections.Generic;

namespace ASP_Core_CuoiKy.Models
{
    public partial class SystemConfig
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool? Status { get; set; }
    }
}
