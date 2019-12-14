using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ronaldogod.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "esse campo é Obrigatorio")]
        public String Nome { get; set; }
        [Required(ErrorMessage = "esse campo é Obrigatorio")]
        public int Idade { get; set; }
        
        public String nascionalidade { get; set; }

    }
}
