using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApi.Models
{
    public interface IRequestCalculadoraModel
    {
       decimal Valor1 { get; set; }
       decimal Valor2 { get; set; }
       Operacao Operador { get; set; }
    }
}
