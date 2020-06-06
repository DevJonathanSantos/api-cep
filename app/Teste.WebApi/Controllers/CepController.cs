using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Teste.Interfaces.Repositories;
using Teste.WebApi.ViewModels;

namespace Teste.WebApi.Controllers
{
    [Route("api/cep")]
    [ApiController]
    public class CepController : ControllerBase
    {
        [HttpPost("buscar")]
        public async Task<ActionResult<Endereco>> Buscar(
            [FromServices] ICepRepository enderecoService,
            [FromBody] CepViewModel model)
        {
            var endereco = await enderecoService.Buscar(model.Cep);
            return endereco;
        }
    }
}