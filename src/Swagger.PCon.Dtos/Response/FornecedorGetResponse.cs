using System.Collections.Generic;

namespace Swagger.PCon.Dtos.Response
{
    public class FornecedorGetResponse
    {
        public string Nome { get; set; }

        public IEnumerable<ProdutoGetResponse> Produtos { get; set; }
    }

    public class ProdutoGetResponse
    {
        public int Id { get; }

        public string Descricao { get; set; }
    }
}