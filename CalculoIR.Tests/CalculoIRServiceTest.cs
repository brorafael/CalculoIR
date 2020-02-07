using CalculoIR.Model.Entities;
using CalculoIR.Model.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CalculoIR.Tests
{
    [TestClass]
    public class CalculoIRServiceTest
    {
        [TestMethod]
        public void CalcularAliquota_PassandoContribuinteComRendaMenorQue2Minimos_DeveRetornarZero()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double baseCalculo = 1000;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularAliquota(baseCalculo, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void CalcularAliquota_PassandoContribuinteComRendaDe3SalariosMinimos_DeveRetornarSegundaFaixa()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double baseCalculo = 3000;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularAliquota(baseCalculo, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(7.5, res);
        }

        [TestMethod]
        public void CalcularAliquota_PassandoContribuinteComRendaDe5SalariosMinimos_DeveRetornarTerceiraFaixa()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double baseCalculo = 5000;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularAliquota(baseCalculo, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CalcularAliquota_PassandoContribuinteComRendaDe6SalariosMinimos_DeveRetornarQuartaFaixa()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double baseCalculo = 6000;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularAliquota(baseCalculo, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(22.5, res);
        }

        [TestMethod]
        public void CalcularAliquota_PassandoContribuinteComRendaDe9SalariosMinimos_DeveRetornarQuintaFaixa()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double baseCalculo = 9000;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularAliquota(baseCalculo, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(27.5, res);
        }

        [TestMethod]
        public void CalcularDescontoDependentes_PassandoContribuinteCom2DependentesESalarioMinimoDe1000_DeveRetornar100()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            int qtdDependentes = 2;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularDescontoDependentes(valorSalarioMinimo, qtdDependentes);

            //Assert
            Assert.AreEqual(100, res);
        }

        [TestMethod]
        public void CalcularDescontoDependentes_PassandoContribuinteCom0DependentesESalarioMinimoDe1000_DeveRetornar0()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            int qtdDependentes = 0;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularDescontoDependentes(valorSalarioMinimo, qtdDependentes);

            //Assert
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void CalcularDescontoDependentes_PassandoContribuinteCom5DependentesESalarioMinimoDe1000_DeveRetornar250()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            int qtdDependentes = 5;
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularDescontoDependentes(valorSalarioMinimo, qtdDependentes);

            //Assert
            Assert.AreEqual(250, res);
        }

        [TestMethod]
        public void CalcularIRContribuinte_PassandoContribuinteComRendaDe5000e2DependentesESalarioMinimoDe1000_DeveRetornar735()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double rendaMensal = 5000;
            double valorSalarioMinimo = 1000;
            int qtdDependentes = 2;

            //Act
            var res = servicoCalculo.CalcularIRContribuinte(rendaMensal, valorSalarioMinimo, qtdDependentes);

            //Assert
            Assert.AreEqual(735, res);
        }

        [TestMethod]
        public void CalcularIRContribuinte_PassandoContribuinteComRendaDe3000e3DependentesESalarioMinimoDe1000_DeveRetornar213()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();

            double rendaMensal = 3000;
            double valorSalarioMinimo = 1000;
            int qtdDependentes = 3;

            //Act
            var res = servicoCalculo.CalcularIRContribuinte(rendaMensal, valorSalarioMinimo, qtdDependentes);

            //Assert
            Assert.AreEqual(213.75, res);
        }

        [TestMethod]
        public void CalcularIRContribuintes_PassandoContribuintesDiferentes_DeveRetornarOEsperadoParaCadaContribuinte()
        {
            //Arrange
            var servicoCalculo = new CalculoIRService();
            var contribuintes = new List<Contribuinte>()
            {
                new Contribuinte()
                {
                    Nome = "Teste1",
                    RendaMensal = 5000,
                    QtdDependentes = 2
                },
                new Contribuinte()
                {
                    Nome = "Teste2",
                    RendaMensal = 3000,
                    QtdDependentes = 3
                }
            };
            double valorSalarioMinimo = 1000;

            //Act
            var res = servicoCalculo.CalcularIRContribuintes(contribuintes, valorSalarioMinimo);

            //Assert
            Assert.AreEqual(735, res.FirstOrDefault(r => r.Contribuinte.Nome == "Teste1").ValorImpostoDeRenda);
            Assert.AreEqual(213.75, res.FirstOrDefault(r => r.Contribuinte.Nome == "Teste2").ValorImpostoDeRenda);
        }
    }
}
