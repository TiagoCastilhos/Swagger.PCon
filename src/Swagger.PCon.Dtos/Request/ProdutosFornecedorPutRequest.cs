using System.Collections.Generic;

namespace Swagger.PCon.Dtos.Request
{
    public class ProdutosFornecedorPutRequest
    {
        public IEnumerable<ProdutoFornecedorPutRequest> Produtos { get; set; }
    }

    public class ProdutoFornecedorPutRequest
    {
        public string Descricao { get; set; }
    }
}