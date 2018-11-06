using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Entities
{
    public class Filme
    {
        public string Id { get; set; }
        public string PrimaryTitle { get; set; }
        public int Year { get; set; }
        public string AverageRating { get; set; }
    }
}
