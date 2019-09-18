using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.PCon.Api.V1
{
    //[ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Fornecedores")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {

    }
}