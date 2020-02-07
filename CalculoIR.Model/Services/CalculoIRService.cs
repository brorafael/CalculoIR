using CalculoIR.Model.DTO;
using CalculoIR.Model.Entities;
using System.Collections.Generic;

namespace CalculoIR.Model.Services
{
    public class CalculoIRService : ICalculoIRService
    {
        public List<CalculoIRResultado> CalcularIRContribuintes(List<Contribuinte> contribuintes, double valorSalarioMinimo)
        {
            var resultado = new List<CalculoIRResultado>();
            contribuintes.ForEach(contribuinte => resultado.Add(new CalculoIRResultado()
            {
                Contribuinte = contribuinte,
                ValorImpostoDeRenda = CalcularIRContribuinte(contribuinte.RendaMensal, valorSalarioMinimo, contribuinte.QtdDependentes)
            }));

            return resultado;
        }

        public double CalcularIRContribuinte(double rendaMensal, double valorSalarioMinimo, int qtdDependentes)
        {
            var baseCalculo = rendaMensal - CalcularDescontoDependentes(valorSalarioMinimo, qtdDependentes);
            var aliquotaCalculo = CalcularAliquota(baseCalculo, valorSalarioMinimo);
            return baseCalculo * aliquotaCalculo / 100;
        }

        public double CalcularAliquota(double baseCalculo, double valorSalarioMinimo)
        {
            if (baseCalculo <= valorSalarioMinimo * 2)
                return 0;
            else if (baseCalculo <= valorSalarioMinimo * 4)
                return 7.5;
            else if (baseCalculo <= valorSalarioMinimo * 5)
                return 15;
            else if (baseCalculo <= valorSalarioMinimo * 7)
                return 22.5;
            else
                return 27.5;
        }

        public double CalcularDescontoDependentes(double valorSalarioMinimo, int qtdDependentes) 
            => valorSalarioMinimo * 5 * qtdDependentes / 100;
    }
}
