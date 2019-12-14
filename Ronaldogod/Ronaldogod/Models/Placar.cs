using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ronaldogod.Models
{
    public class Placar
    {
        public int Id { get; set; }
        
        public Jogador Jogador { get; set; }
        
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatorio")]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "O valor dos pontos não pode ser negativo")]
        public int TotalPontos { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatorio")]
        public DateTime Dia { get; set; }
    }
}
