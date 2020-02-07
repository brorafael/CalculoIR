using System.Collections.Generic;
using System.Linq;
using CalculoIR.Model.DataContext;
using CalculoIR.Model.DTO;
using CalculoIR.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculoIR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoIRController : ControllerBase
    {
        private ICalculoIRService calculoService;
        private readonly DataContext context;

        public CalculoIRController(DataContext context, ICalculoIRService service)
        {
            this.context = context;
            calculoService = service;
        }

        [HttpPost]
        public IList<CalculoIRResultado> CalcularIRDosContribuintes(CalculoRequest calculoRequest)
            => calculoService.CalcularIRContribuintes(context.Contribuintes.ToList(), calculoRequest.ValorSalarioMinimo)
                             .OrderBy(c => c.ValorImpostoDeRenda)
                             .ThenBy(c => c.Contribuinte.Nome).ToList();
    }
}
