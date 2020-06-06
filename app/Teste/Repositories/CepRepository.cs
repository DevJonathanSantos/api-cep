using Correios;
using System.Threading.Tasks;
using Teste.Interfaces.Repositories;

namespace Teste.Repositories
{
    public class CepRepository:ICepRepository
    {
        public async Task<Endereco> Buscar(string cep)
        {
            var correiosApi = new CorreiosApi();
            var retorno = await correiosApi.consultaCEPAsync(cep);

            var endereco = new Endereco()
            {
                Bairro = retorno.@return.bairro,
                Complemento = retorno.@return.complemento,
                Cidade = retorno.@return.cidade,
                Logradouro = retorno.@return.end,
                Uf = retorno.@return.uf
            };

            return (endereco);
        }

    }
}
