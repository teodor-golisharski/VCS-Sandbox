
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {

        [Required]
        public int GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public virtual Game Game { get; set; } = null!;

        [Required]
        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public virtual Player Player { get; set; } = null!;

        [Required]
        public sbyte ScoredGoals { get; set; }

        [Required]
        public sbyte Assists { get; set; }

        [Required]
        public ushort MinutesPlayed { get; set; }
    }
}
