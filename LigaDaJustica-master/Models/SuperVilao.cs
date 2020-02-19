using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LigaDaJustica.Models
{
    public class SuperVilao
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, Display(Name = "Super Poder")]
        public string SuperPoder { get; set; }

        public int SuperHeroiId { get; set; }
        public SuperHeroi SuperHeroi { get; set; }
    }
}
