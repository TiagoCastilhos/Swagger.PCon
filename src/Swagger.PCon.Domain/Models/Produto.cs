using Swagger.PCon.Abstractions.Common.Interfaces;

namespace Swagger.PCon.Domain.Models
{
    public class Produto : IEntity
    {
        public int Id { get; }

        public string Descricao { get; set; }
    }
}