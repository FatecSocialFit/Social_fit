﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialFit.Models
{
    public class Client
    {
        public int Id { get; set; }
        [MaxLength(45)]
        [Required]
        public string Login { get; set; }
        [MaxLength(800)]
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string genre { get; set; }
 
        public bool isActive { get; set; }
        public DateTime DateBorn { get; set; }   
        public DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    }
}
