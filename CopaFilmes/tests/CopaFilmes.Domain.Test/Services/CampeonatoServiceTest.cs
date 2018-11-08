using System.Linq;
using CopaFilmes.Domain.Services;
using CopaFilmes.Domain.Test.MockTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CopaFilmes.Domain.Test.Services
{
    [TestClass]
    public class CampeonatoServiceTest
    {
        private readonly CampeonatoService campeonatoService = new CampeonatoService();

        [TestMethod]
        public void CampeonatoService_RealizarOrdenacao()
        {
            // Arrange
            var filmes = FilmeMock.Filmes;

            // Act
            var filmesOrdenados = campeonatoService.OrdernarFilmesPorOrdemAlfabetica(filmes);

            // Assert
            Assert.AreEqual("Deadpool 2", filmesOrdenados[0].PrimaryTitle);
            Assert.AreEqual("Han Solo: Uma História Star Wars", filmesOrdenados[1].PrimaryTitle);
            Assert.AreEqual("Hereditário", filmesOrdenados[2].PrimaryTitle);
            Assert.AreEqual("Jurassic World: Reino Ameaçado", filmesOrdenados[3].PrimaryTitle);
            Assert.AreEqual("Oito Mulheres e um Segredo", filmesOrdenados[4].PrimaryTitle);
            Assert.AreEqual("Os Incríveis 2", filmesOrdenados[5].PrimaryTitle);
            Assert.AreEqual("Thor: Ragnarok", filmesOrdenados[6].PrimaryTitle);
            Assert.AreEqual("Vingadores: Guerra Infinita", filmesOrdenados[7].PrimaryTitle);
        }

        [TestMethod]
        public void CampeonatoService_RealizarPrimeiraFase()
        {
            // Arrange
            var filmes = FilmeMock.Filmes;

            // Act
            var vencedoresDaPrimeiraFase = campeonatoService.DefinirVencedoresDaPrimeiraFase(filmes);

            // Assert
            Assert.AreEqual("Vingadores: Guerra Infinita", vencedoresDaPrimeiraFase[0].PrimaryTitle);
            Assert.AreEqual("Thor: Ragnarok", vencedoresDaPrimeiraFase[1].PrimaryTitle);
            Assert.AreEqual("Os Incríveis 2", vencedoresDaPrimeiraFase[2].PrimaryTitle);
            Assert.AreEqual("Jurassic World: Reino Ameaçado", vencedoresDaPrimeiraFase[3].PrimaryTitle);
        }

        [TestMethod]
        public void CampeonatoService_RealizarFaseEliminatoria()
        {
            // Arrange
            var filmes = FilmeMock.Filmes;

            // Act
            var vencedoresDaPrimeiraFase = campeonatoService.DefinirVencedoresDaPrimeiraFase(filmes);
            var vencedoresDaFaseEliminatoria = campeonatoService.DefinirVencedoresDaFaseEliminatoria(vencedoresDaPrimeiraFase);

            // Assert
            Assert.AreEqual("Vingadores: Guerra Infinita", vencedoresDaFaseEliminatoria[0].PrimaryTitle);
            Assert.AreEqual("Os Incríveis 2", vencedoresDaFaseEliminatoria[1].PrimaryTitle);
        }

        [TestMethod]
        public void CampeonatoService_DefinirCampeao()
        {
            // Arrange
            var filmes = FilmeMock.Filmes;

            // Act
            var vencedoresDaPrimeiraFase = campeonatoService.DefinirVencedoresDaPrimeiraFase(filmes);
            var vencedoresDaFaseEliminatoria = campeonatoService.DefinirVencedoresDaFaseEliminatoria(vencedoresDaPrimeiraFase);
            var campeao = campeonatoService.DefinirCampeao(vencedoresDaFaseEliminatoria);

            // Assert
            Assert.AreEqual("Vingadores: Guerra Infinita", campeao.PrimaryTitle);
        }
    }
}
