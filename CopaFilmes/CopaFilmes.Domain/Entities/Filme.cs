using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Entities
{
    public class Filme
    {
        public string id { get; set; }
        public string primaryTitle { get; set; }
        public int year { get; set; }
        public string averageRating { get; set; }
    }
}
