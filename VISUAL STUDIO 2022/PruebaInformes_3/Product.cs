﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInformes_3
{
    internal class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image {  get; set; }
        public Rating rating { get; set; }
    }

    internal class Rating
    {
        public float Rate { get; set; }
        public int Count { get; set; }

    }
}
