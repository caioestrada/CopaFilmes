﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Application.ViewModel
{
    public class FilmeViewModel
    {
        public string id { get; set; }

        [Display(Name = "Título")]
        public string primaryTitle { get; set; }

        [Display(Name = "Ano")]
        public int year { get; set; }

        [Display(Name = "Nota")]
        public string averageRating { get; set; }
    }
}
