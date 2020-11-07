using CalculadoraApi.Models;
using CalculadoraApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApi.Services
{
    public class DivisaoService : ICalculadoraService
    {
        public Operacao CodigoOperador => Operacao.Divisao;

        public decimal Executar(IRequestCalculadoraModel request) => request.Valor1 / request.Valor2;
    }
}
