using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ronaldogod.Models
{
    public class PlacarFormViewmodel
    {
        public PlacarFormViewmodel()
        {
            
        }

        public Placar Placar{ get; set; }
        public IEnumerable<Jogador> Jogadores { get; set; }
    }
}
