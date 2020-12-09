﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        // unique key
        [Key]
        public int Id { get; set; }
        // khong cho phep null
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}