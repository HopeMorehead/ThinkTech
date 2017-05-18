﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThinkTech.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public String TechnologyDevice { get; set; }
    }
}