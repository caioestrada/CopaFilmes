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

        public HomeController(IFilmeAppService filmeAppService)
        {
            _filmeAppService = filmeAppService;
        }

        public ActionResult Index()
        {
            var filmes =_filmeAppService.ObterTodos();
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