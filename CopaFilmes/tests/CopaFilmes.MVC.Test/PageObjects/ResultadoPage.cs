using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.MVC.Test.PageObjects
{
    public class ResultadoPage
    {
        #region Campos da página

        [FindsBy(How = How.ClassName, Using = "filme-vencedor")]
        private IList<IWebElement> filmesVencedores;

        #endregion

        private readonly IWebDriver _webDriver;

        public ResultadoPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _webDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            PageFactory.InitElements(_webDriver, this);
        }

        public List<string> ObterVencedores()
        {
            return filmesVencedores.Select(filme => filme.Text).ToList();
        }
    }
}
