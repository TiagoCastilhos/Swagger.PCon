using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swagger.PCon.Domain.Models;
using Swagger.PCon.Dtos.Request;
using Swagger.PCon.Dtos.Response;
using System.Threading.Tasks;

namespace Swagger.PCon.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Authorize]
    [Route("api/v{version:apiVersion}/Fornecedores")]
    public class FornecedoresController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(typeof(FornecedorGetResponse), 200)]
        public async Task<IActionResult> GetAsync(int id)
        {
            if (id <= 0)
                return BadRequest();

            //Pega fornecedor do banco
            //Verifica se existe, se nao existir, retorna um status code diferente
            //Retorna o fornecedor

            Fornecedor fornecedor = null;

            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] FornecedorPutRequest fornecedor)
        {
            if (id <= 0 || fornecedor == null)
                return BadRequest();

            //Atualiza o registro
            //Retorna ok

            return Ok();
        }

        [HttpPut("{id}/Produtos")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] ProdutosFornecedorPutRequest fornecedor)
        {
            if (id <= 0 || fornecedor == null)
                return BadRequest();

            //Atualiza o registro
            //Retorna ok

            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> PostAsync([FromBody]FornecedorPostRequest fornecedor)
        {
            if (fornecedor == null)
                return BadRequest();

            //Aplica regras de negocio, através de um service/command handler
            //Insere ou não, dependendo do caso
            //Retorna a devida resposta para o client

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (id <= 0)
                return BadRequest();

            //Seta deleted = true, no banco

            return Ok();
        }
    }
}