using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models
{
    public class Color
    {
        public Color()
        {
            TeamPrimaryKitColors = new HashSet<Team>();
            TeamSecondaryKitColors = new HashSet<Team>();
        }

        [Key]
        public int ColorId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [InverseProperty("PrimaryKitColor")]
        public virtual ICollection<Team> TeamPrimaryKitColors { get; set; }
        
        [InverseProperty("SecondaryKitColor")]
        public virtual ICollection<Team> TeamSecondaryKitColors { get; set; }
    }
}
