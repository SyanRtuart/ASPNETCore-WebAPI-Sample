﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SampleWebApiAspNetCore.Domain.Entities
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Calories { get; set; }
        public DateTime Created { get; set; }
    }
}
