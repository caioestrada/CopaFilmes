using CopaFilmes.MVC.Test.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace CopaFilmes.MVC.Test.Tests
{
    [TestClass]
    public class FrontTest
    {
        [TestMethod]
        public void FilmeView_SelecionarFilmes_GerarCampeonato()
        {
            using (var weDriver = new ChromeDriver())
            {
                // Arrange
                var filmesPage = new FilmesPage(weDriver);

                // Act
                var vencedores = filmesPage.RealizarCampeonato();

                // Assert
                Assert.AreEqual("Vingadores: Guerra Infinita", vencedores[0]);
                Assert.AreEqual("Os Incríveis 2", vencedores[1]);
            }
        }
    }
}
