using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Teste.Interfaces.Services;
using Teste.WebApi.ViewModels;

namespace Teste.WebApi.Controllers
{
    [Route("api/cep")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService; 
        public TesteController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost("buscar")]
        public async Task<ActionResult<Endereco>> Buscar(EnderecoViewModel model)
        {
            var endereco = await _enderecoService.Buscar(model.Cep);
            return endereco;
        }
    }
}