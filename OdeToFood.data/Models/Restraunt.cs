﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data.Models
{
    public class Restraunt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}