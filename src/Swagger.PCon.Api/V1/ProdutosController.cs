using Microsoft.AspNetCore.Mvc;

namespace Swagger.PCon.Api.V1
{
    [Route("api/v{version:apiVersion}/Produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
    }
}