using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApi.Models
{
    public class Calculadora : IRequestCalculadoraModel
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public Operacao Operador { get; set; }
    }
}
