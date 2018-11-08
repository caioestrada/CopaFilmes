using System;
using CopaFilmes.MVC.Test.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
                var url = filmesPage.RealizarCampeonato();

                // Assert
                Assert.AreEqual("http://localhost/App/CopaFilmes/", url);
            }
        }
    }
}
