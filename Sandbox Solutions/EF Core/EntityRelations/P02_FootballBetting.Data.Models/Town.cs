using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            Teams = new HashSet<Team>();
            Players = new HashSet<Player>();
        }

        [Key]
        public int TownId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; } = null!;

        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
