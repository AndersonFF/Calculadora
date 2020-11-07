using CalculadoraApi.Models;
using CalculadoraApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApi.Services
{
    public class MultiplicacaoService : ICalculadoraService
    {
        public Operacao CodigoOperador => Operacao.Multiplicacao;

        public decimal Executar(IRequestCalculadoraModel request) => request.Valor1 * request.Valor2;
    }
}
