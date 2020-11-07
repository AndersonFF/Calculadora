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
        [EnableCors("AllowMyOrigin")]
        public ActionResult Calcular([FromBody] Calculadora request)
        {
            var service = _calculadoraServices.FirstOrDefault(c=> c.CodigoOperador == request.Operador);
            var response = service.Executar(request);

            return Ok(response);
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

            var service = _calculadoraServices.FirstOrDefault(c => c.CodigoOperador == request.Operador);

            var response = service.Executar(request);

            return Ok(response);
        }

        [HttpPost]
        [Route("multiplicar")]
        [EnableCors("AllowMyOrigin")]
        public ActionResult Multiplicar([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Multiplicacao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            var service = _calculadoraServices.FirstOrDefault(c => c.CodigoOperador == request.Operador);

            var response = service.Executar(request);

            return Ok(response);
        }

        [HttpPost]
        [Route("subtrair")]
        [EnableCors("AllowMyOrigin")]
        public ActionResult Subtrair([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Subtracao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            var service = _calculadoraServices.FirstOrDefault(c => c.CodigoOperador == request.Operador);

            var response = service.Executar(request);

            return Ok(response);
        }

        [HttpPost]
        [Route("dividir")]
        [EnableCors("AllowMyOrigin")]
        public ActionResult Dividir([FromBody] Calculadora request)
        {
            if (request.Operador != Operacao.Divisao)
            {
                return NotFound("Operador inválido ou inexistente.");
            }

            var service = _calculadoraServices.FirstOrDefault(c => c.CodigoOperador == request.Operador);

            var response = service.Executar(request);

            return Ok(response);
        }
        #endregion

    }
}