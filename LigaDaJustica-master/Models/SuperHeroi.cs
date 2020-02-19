using System.ComponentModel.DataAnnotations;

namespace LigaDaJustica.Models
{
    public class SuperHeroi
	{	
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }	

        [Required, Display(Name = "Super Poder")]
        public string SuperPoder {get; set; }	

        //quando colocamos o [nome de uma propriedade] + Id,  o Entity entende automaticamente
        //que esse é o Id do outro objeto. Nesse caso SuperVilaoId é a chave estrangeira de SuperVilão.
        public int SuperVilaoId { get; set; }
        public SuperVilao SuperVilao { get; set; }
    }
}