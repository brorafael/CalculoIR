using CalculoIR.Model.DTO;
using CalculoIR.Model.Entities;
using System.Collections.Generic;

namespace CalculoIR.Model.Services
{
    public interface ICalculoIRService
    {
        List<CalculoIRResultado> CalcularIRContribuintes(List<Contribuinte> contribuintes, double valorSalarioMinimo);
    }
}