using System;
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
        [Display(Name = "Email")]
        public string Login { get; set; }
        [MaxLength(800)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Genero")]
        public string genre { get; set; }
 
        public bool isActive { get; set; }

        [Display(Name = "Data de Nascimento")]
        public Nullable<System.DateTime> DateBorn { get; set; }   
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    }
}
