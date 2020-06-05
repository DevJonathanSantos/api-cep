using System.Threading.Tasks;
using Teste.Interfaces.Repositories;
using Teste.Interfaces.Services;

namespace Teste.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public async Task<Endereco> Buscar(string cep)
        {
            return await _enderecoRepository.Buscar(cep);
        }
    }
}
