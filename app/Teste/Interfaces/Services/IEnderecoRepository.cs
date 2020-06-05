
using System.Threading.Tasks;

namespace Teste.Interfaces.Services
{
    public interface IEnderecoService
    {
        Task<Endereco> Buscar(string cep);
    }
}
