using CopaFilmes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CopaFilmes.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilmeAppService _filmeAppService;
        private readonly ICampeonatoAppService _campeonatoAppService;

        public HomeController(IFilmeAppService filmeAppService, ICampeonatoAppService campeonatoAppService)
        {
            _filmeAppService = filmeAppService;
            _campeonatoAppService = campeonatoAppService;
        }

        public ActionResult Index()
        {
            var filmes =_filmeAppService.ObterTodos();
            var filmesSelecionados = filmes.Skip(30).Take(8).ToList();
            var filmesVencederosDaPrimeiraFase = _campeonatoAppService.DefinirVencedoresDaPrimeiraFase(filmesSelecionados);
            var filmesVencederosDaFaseEliminatoria = _campeonatoAppService.DefinirVencedoresDaFaseEliminatoria(filmesVencederosDaPrimeiraFase);
            var campeao = _campeonatoAppService.DefinirCampeao(filmesVencederosDaFaseEliminatoria);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}