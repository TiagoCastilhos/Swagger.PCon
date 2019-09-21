using System.Collections.Generic;

namespace Swagger.PCon.Dtos.Request
{
    public class FornecedorPostRequest
    {
        public string Nome { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        public int Id { get; }
    }
}