using CalculadoraApi.Models;

namespace CalculadoraApi.Services.Interfaces
{
    public interface ICalculadoraService
    {
        Operacao CodigoOperador { get;  }

        decimal Executar(IRequestCalculadoraModel request);
    }
}
