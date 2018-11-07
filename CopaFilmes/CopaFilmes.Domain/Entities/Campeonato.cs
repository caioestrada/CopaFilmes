using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Entities
{
    public class Campeonato
    {
        public Filme Campeao { get; set; }
        public Filme ViceCampeao { get; set; }
    }
}
