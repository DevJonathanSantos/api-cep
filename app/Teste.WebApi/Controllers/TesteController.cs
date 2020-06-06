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
        [HttpPost("buscar")]
        public async Task<ActionResult<Endereco>> Buscar(
            [FromServices] IEnderecoService enderecoService,
            [FromBody] CepViewModel model)
        {
            var endereco = await enderecoService.Buscar(model.Cep);
            return endereco;
        }
    }
}