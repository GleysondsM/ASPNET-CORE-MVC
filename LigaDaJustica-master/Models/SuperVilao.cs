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

        //quando colocamos o [nome de uma propriedade] + Id,  o Entity entende automaticamente
        //que esse é o Id do outro objeto. Nesse caso SuperHeroiId é a chave estrangeira de SuperHeroi.
        public int SuperHeroiId { get; set; }
        public SuperHeroi SuperHeroi { get; set; }
    }
}
