using CopaFilmes.Application.Interfaces;
using CopaFilmes.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CopaFilmes.MVC.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeAppService _filmeAppService;
        private readonly ICampeonatoAppService _campeonatoAppService;

        public FilmeController(IFilmeAppService filmeAppService, ICampeonatoAppService campeonatoAppService)
        {
            _filmeAppService = filmeAppService;
            _campeonatoAppService = campeonatoAppService;
        }

        // GET: Filme
        public ActionResult Index()
        {
            return View(_filmeAppService.ObterTodos().ToList());
        }

        [HttpPost]
        public ActionResult Index(List<FilmeViewModel> filmesSelecionados)
        {
            _campeonatoAppService.RelizarCampeonato(filmesSelecionados.Where(x => x.Selecionado));
            return View("ResultadoFinal", _campeonatoAppService.CampeonatoViewModel);
        }
    }
}