using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.MVC.Test.PageObjects
{
    public class FilmesPage
    {
        #region Campos da página
        
        [FindsBy(How = How.XPath, Using = "//input[@id='tt3606756']")]
        private IWebElement checkOsIncriveis2;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt4881806']")]
        private IWebElement checkJurassicWorld;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt5164214']")]
        private IWebElement checkOitoMulheres;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt7784604']")]
        private IWebElement checkHereditario;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt4154756']")]
        private IWebElement checkVingadores;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt5463162']")]
        private IWebElement checkDeadpool2;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt3778644']")]
        private IWebElement checkHanSolo;

        [FindsBy(How = How.XPath, Using = "//input[@id='tt3501632']")]
        private IWebElement checkThor;

        [FindsBy(How = How.XPath, Using = "//input[@id='btnGerarCampeonato']")]
        private IWebElement btnGerarCampeonato;

        #endregion

        private readonly IWebDriver _webDriver;
        private readonly ResultadoPage _resultadoPage;

        public FilmesPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _webDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            _resultadoPage = new ResultadoPage(_webDriver);

            PageFactory.InitElements(_webDriver, this);
        }

        public List<string> RealizarCampeonato()
        {
            IrParaPagina();
            SelecionarOsIncriveis2();
            SelecionarJurassicWorld();
            SelecionarOitoMulheres();
            SelecionarHereditario();
            SelecionarVingadores();
            SelecionarDeadpool2();
            SelecionarHanSolo();
            SelecionarThor();
            ClicarEmGerarCampeonato();

            return _resultadoPage.ObterVencedores();
        }

        private void IrParaPagina()
        {
            _webDriver.Url = "http://localhost/App/CopaFilmes";
            Task.Delay(2000).Wait();
        }

        private void SelecionarOsIncriveis2() => checkOsIncriveis2.Click();

        private void SelecionarJurassicWorld() => checkJurassicWorld.Click();

        private void SelecionarOitoMulheres() => checkOitoMulheres.Click();

        private void SelecionarHereditario() => checkHereditario.Click();

        private void SelecionarVingadores() => checkVingadores.Click();

        private void SelecionarDeadpool2() => checkDeadpool2.Click();

        private void SelecionarHanSolo() => checkHanSolo.Click();

        private void SelecionarThor() => checkThor.Click();

        private string ClicarEmGerarCampeonato()
        {
            btnGerarCampeonato.Click();
            Task.Delay(2000).Wait();
            return _webDriver.Url;
        }
    }
}
