using System.Collections.Generic;

namespace Pokedex.Api.Domain.Models
{
    public class Type
    {
        public string Description { get; set; }
        public List<Type> Weaknesses { get; set; }
    }
}
