using System.Threading.Tasks;

namespace Teste.Interfaces.Repositories
{
    public interface IEnderecoRepository
    {
        Task<Endereco> Buscar(string cep);
    }
}
