using System.Threading.Tasks;

namespace Teste.Interfaces.Repositories
{
    public interface ICepRepository
    {
        Task<Endereco> Buscar(string cep);
    }
}
