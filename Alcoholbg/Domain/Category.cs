﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alcoholbg.Domain
{
    public class Category
    {
        //public int id { get; set; }
        public int Id { get; internal set; }
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
