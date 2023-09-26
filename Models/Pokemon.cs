namespace WebApplication2.Models
{
    public class Pokemon
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime BurthDate { get; set; }
        public ICollection<Review> Reviews { get; set;}
        public ICollection<PokemonOwner> PokemonOwner { get; set; }
        public ICollection<PokemonCategory> PokemonCategory { get; set; }
    }
}
