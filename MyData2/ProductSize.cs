﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyData
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? PremiumPrice { get; set; }
        public decimal? ToppingPrice { get; set; }
        public bool? IsGlutenFree { get; set; }
    }
}
