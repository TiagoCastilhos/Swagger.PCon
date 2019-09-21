using Microsoft.AspNetCore.Mvc;
using Swagger.PCon.Domain.Models;
using System.Threading.Tasks;

namespace Swagger.PCon.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/Fornecedores")]
    public class FornecedoresController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(typeof(Fornecedor), 200)]
        public async Task<IActionResult> GetAsync(int id)
        {
            if (id <= 0)
                return BadRequest();

            //Pega fornecedor do banco
            //Retorna o fornecedor

            Fornecedor fornecedor = null;

            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Fornecedor fornecedor)
        {
            if (id <= 0 || fornecedor == null)
                return BadRequest();

            //Atualiza o registro
            //Retorna ok

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> PostAsync([FromBody]Fornecedor fornecedor)
        {
            if (fornecedor == null)
                return BadRequest();

            //Aplica regras de negocio, através de um service/command handler
            //Insere ou não, dependendo do caso
            //Retorna a devida resposta para o client

            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (id <= 0)
                return BadRequest();

            //Delete registro do banco

            return Ok();
        }
    }
}