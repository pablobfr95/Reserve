using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Reserve.Dominio.Interface;

namespace Reserve.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : Controller
    {
        private readonly ICovidServico _covidServico;
        private readonly IConfiguration _configuration;

        public CovidController(ICovidServico covidServico, IConfiguration configuration)
        {
            _covidServico = covidServico;
            _configuration = configuration;
        }
       
        [HttpGet("ListarPaisesMaisAtivos")]
        public async Task<IActionResult> ListarPaisesMaisAtivos()
        {
            try
            {
                var consulta = _covidServico.ListarPaisesComMaisCasosAtivos(_configuration.GetSection("EndPointCovid").Value);
                

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
