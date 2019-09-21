using Microsoft.AspNetCore.Mvc;

namespace Swagger.PCon.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/Produtos")]
    public class ProdutosController : ControllerBase
    {

    }
}