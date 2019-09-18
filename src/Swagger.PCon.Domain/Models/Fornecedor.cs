using Swagger.PCon.Abstractions.Common.Interfaces;
using System.Collections.Generic;

namespace Swagger.PCon.Domain.Models
{
    public class Fornecedor : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}