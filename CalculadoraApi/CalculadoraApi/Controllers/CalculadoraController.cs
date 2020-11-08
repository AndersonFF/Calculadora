using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraApi.Models;
using CalculadoraApi.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculadoraApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class CalculadoraController : ControllerBase
    {
        private readonly IEnumerable<ICalculadoraService> _calculadoraServices;

        public CalculadoraController(IEnumerable<ICalculadoraService> calculadoraServices)
        {
            _calculadoraServices = calculadoraServices;
        }

        /// <summary>
        /// Calcula tudos os operadores passados no objeto request
        /// </summary>
        /// <param name="Calcular Todos"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Calcular([FromBody] Calculadora request)
        {
            return Ok(Executar(request));
        }

        #region Métodos de operações Matemáticas 
        [HttpPost]
        [Route("somar")]
        [EnableCors("AllowMyOrigin")]
        public ActionResult Somar([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Soma)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            return Ok(Executar(request));
        }

        [HttpPost]
        [Route("multiplicar")]
        public ActionResult Multiplicar([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Multiplicacao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            return Ok(Executar(request));
        }

        [HttpPost]
        [Route("subtrair")]
        public ActionResult Subtrair([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Subtracao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            return Ok(Executar(request));
        }

        [HttpPost]
        [Route("dividir")]
        public ActionResult Dividir([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Divisao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            return Ok(Executar(request));
        }

        private decimal Executar(Calculadora request)
        {
            var service = _calculadoraServices.FirstOrDefault(c => c.CodigoOperador == request.Operador);

            return service.Executar(request);
        }
        #endregion

    }
}