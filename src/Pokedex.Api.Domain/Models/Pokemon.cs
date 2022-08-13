using Pokedex.Api.Domain.Enums;

namespace Pokedex.Api.Domain.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int NumberId { get; set; }
        public string Description { get; set; }
        public Pokemon PreEvolution { get; set; }
        public Pokemon Evolution { get; set; }
        public Type PrimaryType { get; set; }
        public Type SecondaryType { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Category { get; set; }
        public Abilities Abilities { get; set; }
        public Gender Gender { get; set; }
    }
}
