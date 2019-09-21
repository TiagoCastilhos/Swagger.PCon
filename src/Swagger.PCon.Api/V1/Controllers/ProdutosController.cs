using Microsoft.AspNetCore.Mvc;

namespace Swagger.PCon.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Produtos")]
    public class ProdutosController : ControllerBase
    {
    }
}